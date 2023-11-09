// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A single Amazon Simple Storage Service (S3) object or a set of S3 objects. </summary>
    public partial class AmazonS3Dataset : Dataset
    {
        /// <summary> Initializes a new instance of <see cref="AmazonS3Dataset"/>. </summary>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="bucketName"> The name of the Amazon S3 bucket. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="linkedServiceName"/> or <paramref name="bucketName"/> is null. </exception>
        public AmazonS3Dataset(LinkedServiceReference linkedServiceName, object bucketName) : base(linkedServiceName)
        {
            Argument.AssertNotNull(linkedServiceName, nameof(linkedServiceName));
            Argument.AssertNotNull(bucketName, nameof(bucketName));

            BucketName = bucketName;
            Type = "AmazonS3Object";
        }

        /// <summary> Initializes a new instance of <see cref="AmazonS3Dataset"/>. </summary>
        /// <param name="type"> Type of dataset. </param>
        /// <param name="description"> Dataset description. </param>
        /// <param name="structure"> Columns that define the structure of the dataset. Type: array (or Expression with resultType array), itemType: DatasetDataElement. </param>
        /// <param name="schema"> Columns that define the physical type schema of the dataset. Type: array (or Expression with resultType array), itemType: DatasetSchemaDataElement. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="parameters"> Parameters for dataset. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Dataset. </param>
        /// <param name="folder"> The folder that this Dataset is in. If not specified, Dataset will appear at the root level. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="bucketName"> The name of the Amazon S3 bucket. Type: string (or Expression with resultType string). </param>
        /// <param name="key"> The key of the Amazon S3 object. Type: string (or Expression with resultType string). </param>
        /// <param name="prefix"> The prefix filter for the S3 object name. Type: string (or Expression with resultType string). </param>
        /// <param name="version"> The version for the S3 object. Type: string (or Expression with resultType string). </param>
        /// <param name="modifiedDatetimeStart"> The start of S3 object's modified datetime. Type: string (or Expression with resultType string). </param>
        /// <param name="modifiedDatetimeEnd"> The end of S3 object's modified datetime. Type: string (or Expression with resultType string). </param>
        /// <param name="format">
        /// The format of files.
        /// Please note <see cref="DatasetStorageFormat"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AvroFormat"/>, <see cref="JsonFormat"/>, <see cref="OrcFormat"/>, <see cref="ParquetFormat"/> and <see cref="TextFormat"/>.
        /// </param>
        /// <param name="compression"> The data compression method used for the Amazon S3 object. </param>
        internal AmazonS3Dataset(string type, string description, object structure, object schema, LinkedServiceReference linkedServiceName, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, DatasetFolder folder, IDictionary<string, object> additionalProperties, object bucketName, object key, object prefix, object version, object modifiedDatetimeStart, object modifiedDatetimeEnd, DatasetStorageFormat format, DatasetCompression compression) : base(type, description, structure, schema, linkedServiceName, parameters, annotations, folder, additionalProperties)
        {
            BucketName = bucketName;
            Key = key;
            Prefix = prefix;
            Version = version;
            ModifiedDatetimeStart = modifiedDatetimeStart;
            ModifiedDatetimeEnd = modifiedDatetimeEnd;
            Format = format;
            Compression = compression;
            Type = type ?? "AmazonS3Object";
        }

        /// <summary> Initializes a new instance of <see cref="AmazonS3Dataset"/> for deserialization. </summary>
        internal AmazonS3Dataset()
        {
        }

        /// <summary> The name of the Amazon S3 bucket. Type: string (or Expression with resultType string). </summary>
        public object BucketName { get; set; }
        /// <summary> The key of the Amazon S3 object. Type: string (or Expression with resultType string). </summary>
        public object Key { get; set; }
        /// <summary> The prefix filter for the S3 object name. Type: string (or Expression with resultType string). </summary>
        public object Prefix { get; set; }
        /// <summary> The version for the S3 object. Type: string (or Expression with resultType string). </summary>
        public object Version { get; set; }
        /// <summary> The start of S3 object's modified datetime. Type: string (or Expression with resultType string). </summary>
        public object ModifiedDatetimeStart { get; set; }
        /// <summary> The end of S3 object's modified datetime. Type: string (or Expression with resultType string). </summary>
        public object ModifiedDatetimeEnd { get; set; }
        /// <summary>
        /// The format of files.
        /// Please note <see cref="DatasetStorageFormat"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AvroFormat"/>, <see cref="JsonFormat"/>, <see cref="OrcFormat"/>, <see cref="ParquetFormat"/> and <see cref="TextFormat"/>.
        /// </summary>
        public DatasetStorageFormat Format { get; set; }
        /// <summary> The data compression method used for the Amazon S3 object. </summary>
        public DatasetCompression Compression { get; set; }
    }
}
