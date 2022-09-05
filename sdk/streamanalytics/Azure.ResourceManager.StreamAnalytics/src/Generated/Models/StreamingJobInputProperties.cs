// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    /// <summary>
    /// The properties that are associated with an input.
    /// Please note <see cref="StreamingJobInputProperties"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ReferenceInputProperties"/> and <see cref="StreamInputProperties"/>.
    /// </summary>
    public abstract partial class StreamingJobInputProperties
    {
        /// <summary> Initializes a new instance of StreamingJobInputProperties. </summary>
        protected StreamingJobInputProperties()
        {
        }

        /// <summary> Initializes a new instance of StreamingJobInputProperties. </summary>
        /// <param name="inputPropertiesType"> Indicates whether the input is a source of reference data or stream data. Required on PUT (CreateOrReplace) requests. </param>
        /// <param name="serialization">
        /// Describes how data from an input is serialized or how data is serialized when written to an output. Required on PUT (CreateOrReplace) requests.
        /// Please note <see cref="StreamAnalyticsDataSerialization"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AvroFormatSerialization"/>, <see cref="CsvFormatSerialization"/>, <see cref="CustomClrFormatSerialization"/>, <see cref="JsonFormatSerialization"/> and <see cref="ParquetFormatSerialization"/>.
        /// </param>
        /// <param name="diagnostics"> Describes conditions applicable to the Input, Output, or the job overall, that warrant customer attention. </param>
        /// <param name="etag"> The current entity tag for the input. This is an opaque string. You can use it to detect whether the resource has changed between requests. You can also use it in the If-Match or If-None-Match headers for write operations for optimistic concurrency. </param>
        /// <param name="compression"> Describes how input data is compressed. </param>
        /// <param name="partitionKey"> partitionKey Describes a key in the input data which is used for partitioning the input data. </param>
        /// <param name="watermarkSettings"> Settings which determine whether to read watermark events. </param>
        internal StreamingJobInputProperties(string inputPropertiesType, StreamAnalyticsDataSerialization serialization, StreamingJobDiagnostics diagnostics, ETag? etag, StreamingCompression compression, string partitionKey, StreamingJobInputWatermarkProperties watermarkSettings)
        {
            InputPropertiesType = inputPropertiesType;
            Serialization = serialization;
            Diagnostics = diagnostics;
            ETag = etag;
            Compression = compression;
            PartitionKey = partitionKey;
            WatermarkSettings = watermarkSettings;
        }

        /// <summary> Indicates whether the input is a source of reference data or stream data. Required on PUT (CreateOrReplace) requests. </summary>
        internal string InputPropertiesType { get; set; }
        /// <summary>
        /// Describes how data from an input is serialized or how data is serialized when written to an output. Required on PUT (CreateOrReplace) requests.
        /// Please note <see cref="StreamAnalyticsDataSerialization"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AvroFormatSerialization"/>, <see cref="CsvFormatSerialization"/>, <see cref="CustomClrFormatSerialization"/>, <see cref="JsonFormatSerialization"/> and <see cref="ParquetFormatSerialization"/>.
        /// </summary>
        public StreamAnalyticsDataSerialization Serialization { get; set; }
        /// <summary> Describes conditions applicable to the Input, Output, or the job overall, that warrant customer attention. </summary>
        internal StreamingJobDiagnostics Diagnostics { get; }
        /// <summary> A collection of zero or more conditions applicable to the resource, or to the job overall, that warrant customer attention. </summary>
        public IReadOnlyList<StreamingJobDiagnosticCondition> DiagnosticsConditions
        {
            get => Diagnostics?.Conditions;
        }

        /// <summary> The current entity tag for the input. This is an opaque string. You can use it to detect whether the resource has changed between requests. You can also use it in the If-Match or If-None-Match headers for write operations for optimistic concurrency. </summary>
        public ETag? ETag { get; }
        /// <summary> Describes how input data is compressed. </summary>
        internal StreamingCompression Compression { get; set; }
        /// <summary> Indicates the type of compression that the input uses. Required on PUT (CreateOrReplace) requests. </summary>
        public StreamingCompressionType? CompressionType
        {
            get => Compression is null ? default(StreamingCompressionType?) : Compression.CompressionType;
            set
            {
                Compression = value.HasValue ? new StreamingCompression(value.Value) : null;
            }
        }

        /// <summary> partitionKey Describes a key in the input data which is used for partitioning the input data. </summary>
        public string PartitionKey { get; set; }
        /// <summary> Settings which determine whether to read watermark events. </summary>
        internal StreamingJobInputWatermarkProperties WatermarkSettings { get; set; }
        /// <summary> The input watermark mode. </summary>
        public StreamingJobInputWatermarkMode? WatermarkMode
        {
            get => WatermarkSettings is null ? default : WatermarkSettings.WatermarkMode;
            set
            {
                if (WatermarkSettings is null)
                    WatermarkSettings = new StreamingJobInputWatermarkProperties();
                WatermarkSettings.WatermarkMode = value;
            }
        }
    }
}
