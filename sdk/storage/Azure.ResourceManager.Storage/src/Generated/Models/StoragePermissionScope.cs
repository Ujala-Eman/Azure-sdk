// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The StoragePermissionScope. </summary>
    public partial class StoragePermissionScope
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StoragePermissionScope"/>. </summary>
        /// <param name="permissions"> The permissions for the local user. Possible values include: Read (r), Write (w), Delete (d), List (l), and Create (c). </param>
        /// <param name="service"> The service used by the local user, e.g. blob, file. </param>
        /// <param name="resourceName"> The name of resource, normally the container name or the file share name, used by the local user. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="permissions"/>, <paramref name="service"/> or <paramref name="resourceName"/> is null. </exception>
        public StoragePermissionScope(string permissions, string service, string resourceName)
        {
            Argument.AssertNotNull(permissions, nameof(permissions));
            Argument.AssertNotNull(service, nameof(service));
            Argument.AssertNotNull(resourceName, nameof(resourceName));

            Permissions = permissions;
            Service = service;
            ResourceName = resourceName;
        }

        /// <summary> Initializes a new instance of <see cref="StoragePermissionScope"/>. </summary>
        /// <param name="permissions"> The permissions for the local user. Possible values include: Read (r), Write (w), Delete (d), List (l), and Create (c). </param>
        /// <param name="service"> The service used by the local user, e.g. blob, file. </param>
        /// <param name="resourceName"> The name of resource, normally the container name or the file share name, used by the local user. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StoragePermissionScope(string permissions, string service, string resourceName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Permissions = permissions;
            Service = service;
            ResourceName = resourceName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StoragePermissionScope"/> for deserialization. </summary>
        internal StoragePermissionScope()
        {
        }

        /// <summary> The permissions for the local user. Possible values include: Read (r), Write (w), Delete (d), List (l), and Create (c). </summary>
        public string Permissions { get; set; }
        /// <summary> The service used by the local user, e.g. blob, file. </summary>
        public string Service { get; set; }
        /// <summary> The name of resource, normally the container name or the file share name, used by the local user. </summary>
        public string ResourceName { get; set; }
    }
}
