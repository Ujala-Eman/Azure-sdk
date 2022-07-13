// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.PostgreSql.Models
{
    /// <summary> Represents a log file. </summary>
    public partial class LogFile : ResourceData
    {
        /// <summary> Initializes a new instance of LogFile. </summary>
        public LogFile()
        {
        }

        /// <summary> Initializes a new instance of LogFile. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sizeInKB"> Size of the log file. </param>
        /// <param name="createdOn"> Creation timestamp of the log file. </param>
        /// <param name="lastModifiedOn"> Last modified timestamp of the log file. </param>
        /// <param name="typePropertiesType"> Type of the log file. </param>
        /// <param name="uri"> The url to download the log file from. </param>
        internal LogFile(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, long? sizeInKB, DateTimeOffset? createdOn, DateTimeOffset? lastModifiedOn, string typePropertiesType, Uri uri) : base(id, name, resourceType, systemData)
        {
            SizeInKB = sizeInKB;
            CreatedOn = createdOn;
            LastModifiedOn = lastModifiedOn;
            TypePropertiesType = typePropertiesType;
            Uri = uri;
        }

        /// <summary> Size of the log file. </summary>
        public long? SizeInKB { get; set; }
        /// <summary> Creation timestamp of the log file. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Last modified timestamp of the log file. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> Type of the log file. </summary>
        public string TypePropertiesType { get; set; }
        /// <summary> The url to download the log file from. </summary>
        public Uri Uri { get; set; }
    }
}
