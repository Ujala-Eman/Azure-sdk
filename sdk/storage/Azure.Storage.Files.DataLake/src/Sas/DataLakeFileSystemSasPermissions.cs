﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using System.Text;
using Azure.Storage;
using Azure.Storage.Files.DataLake.Sas;
using Internals = Azure.Storage.Shared;

namespace Azure.Storage.Files.DataLake.Sas
{
    /// <summary>
    /// <see cref="DataLakeFileSystemSasPermissions"/> contains the list of
    /// permissions that can be set for a file systems's access policy.  Use
    /// <see cref="DataLakeSasBuilder.SetPermissions(DataLakeSasPermissions)"/>
    /// to set the permissions on the <see cref="DataLakeSasBuilder"/>.
    /// </summary>
    [Flags]
    public enum DataLakeFileSystemSasPermissions
    {
        /// <summary>
        /// Indicates that Read is permitted.
        /// </summary>
        Read = 1,

        /// <summary>
        /// Indicates that Add is permitted.
        /// </summary>
        Add = 2,

        /// <summary>
        /// Indicates that Create is permitted.
        /// </summary>
        Create = 4,

        /// <summary>
        /// Indicates that Write is permitted.
        /// </summary>
        Write = 8,

        /// <summary>
        /// Indicates that Delete is permitted.
        /// </summary>
        Delete = 16,

        /// <summary>
        /// Indicates that List is permitted.
        /// </summary>
        List = 32,

        /// <summary>
        /// Indicates that all permissions are set.
        /// </summary>
        All = ~0
    }
}

namespace Azure.Storage.Files.DataLake
{
    /// <summary>
    /// Data Lake enum extensions.
    /// </summary>
    internal static partial class DataLakeExtensions
    {
        /// <summary>
        /// Create a permissions string to provide
        /// <see cref="DataLakeSasBuilder.Permissions"/>.
        /// </summary>
        /// <returns>A permissions string.</returns>
        internal static string ToPermissionsString(this DataLakeFileSystemSasPermissions permissions)
        {
            var sb = new StringBuilder();
            if ((permissions & DataLakeFileSystemSasPermissions.Read) == DataLakeFileSystemSasPermissions.Read)
            {
                sb.Append(Internals.Constants.Sas.Permissions.Read);
            }
            if ((permissions & DataLakeFileSystemSasPermissions.Add) == DataLakeFileSystemSasPermissions.Add)
            {
                sb.Append(Internals.Constants.Sas.Permissions.Add);
            }
            if ((permissions & DataLakeFileSystemSasPermissions.Create) == DataLakeFileSystemSasPermissions.Create)
            {
                sb.Append(Internals.Constants.Sas.Permissions.Create);
            }
            if ((permissions & DataLakeFileSystemSasPermissions.Write) == DataLakeFileSystemSasPermissions.Write)
            {
                sb.Append(Internals.Constants.Sas.Permissions.Write);
            }
            if ((permissions & DataLakeFileSystemSasPermissions.Delete) == DataLakeFileSystemSasPermissions.Delete)
            {
                sb.Append(Internals.Constants.Sas.Permissions.Delete);
            }
            if ((permissions & DataLakeFileSystemSasPermissions.List) == DataLakeFileSystemSasPermissions.List)
            {
                sb.Append(Internals.Constants.Sas.Permissions.List);
            }
            return sb.ToString();
        }
    }
}
