// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The resource management error additional info. </summary>
    public partial class ErrorAdditionalInfo
    {
        /// <summary> Initializes a new instance of <see cref="ErrorAdditionalInfo"/>. </summary>
        internal ErrorAdditionalInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ErrorAdditionalInfo"/>. </summary>
        /// <param name="errorAdditionalInfoType"> The additional info type. </param>
        /// <param name="info"> The additional info. </param>
        internal ErrorAdditionalInfo(string errorAdditionalInfoType, BinaryData info)
        {
            ErrorAdditionalInfoType = errorAdditionalInfoType;
            Info = info;
        }

        /// <summary> The additional info type. </summary>
        public string ErrorAdditionalInfoType { get; }
        /// <summary> The additional info. </summary>
        public BinaryData Info { get; }
    }
}
