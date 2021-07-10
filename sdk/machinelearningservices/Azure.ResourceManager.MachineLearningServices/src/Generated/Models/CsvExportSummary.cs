// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> The CsvExportSummary. </summary>
    public partial class CsvExportSummary : ExportSummary
    {
        /// <summary> Initializes a new instance of CsvExportSummary. </summary>
        public CsvExportSummary()
        {
            Format = ExportFormatType.CSV;
        }

        /// <summary> Initializes a new instance of CsvExportSummary. </summary>
        /// <param name="endTimeUtc"> The time when the export was completed. </param>
        /// <param name="exportedRowCount"> The total number of labeled datapoints exported. </param>
        /// <param name="format"> The format of exported labels, also as the discriminator. </param>
        /// <param name="labelingJobId"> Name and identifier of the job containing exported labels. </param>
        /// <param name="startTimeUtc"> The time when the export was requested. </param>
        /// <param name="containerName"> The container name to which the labels will be exported. </param>
        /// <param name="snapshotPath"> The output path where the labels will be exported. </param>
        internal CsvExportSummary(DateTimeOffset? endTimeUtc, long? exportedRowCount, ExportFormatType format, string labelingJobId, DateTimeOffset? startTimeUtc, string containerName, string snapshotPath) : base(endTimeUtc, exportedRowCount, format, labelingJobId, startTimeUtc)
        {
            ContainerName = containerName;
            SnapshotPath = snapshotPath;
            Format = format;
        }

        /// <summary> The container name to which the labels will be exported. </summary>
        public string ContainerName { get; }
        /// <summary> The output path where the labels will be exported. </summary>
        public string SnapshotPath { get; }
    }
}
