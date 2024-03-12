// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Trailing input data definition. </summary>
    public partial class TrailingInputData : MonitoringInputDataBase
    {
        /// <summary> Initializes a new instance of <see cref="TrailingInputData"/>. </summary>
        /// <param name="jobInputType"> [Required] Specifies the type of job. </param>
        /// <param name="uri"> [Required] Input Asset URI. </param>
        /// <param name="windowOffset"> [Required] The time offset between the end of the data window and the monitor's current run time. </param>
        /// <param name="windowSize"> [Required] The size of the trailing data window. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public TrailingInputData(JobInputType jobInputType, Uri uri, TimeSpan windowOffset, TimeSpan windowSize) : base(jobInputType, uri)
        {
            Argument.AssertNotNull(uri, nameof(uri));

            WindowOffset = windowOffset;
            WindowSize = windowSize;
            InputDataType = MonitoringInputDataType.Trailing;
        }

        /// <summary> Initializes a new instance of <see cref="TrailingInputData"/>. </summary>
        /// <param name="columns"> Mapping of column names to special uses. </param>
        /// <param name="dataContext"> The context metadata of the data source. </param>
        /// <param name="inputDataType"> [Required] Specifies the type of signal to monitor. </param>
        /// <param name="jobInputType"> [Required] Specifies the type of job. </param>
        /// <param name="uri"> [Required] Input Asset URI. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="preprocessingComponentId"> The ARM resource ID of the component resource used to preprocess the data. </param>
        /// <param name="windowOffset"> [Required] The time offset between the end of the data window and the monitor's current run time. </param>
        /// <param name="windowSize"> [Required] The size of the trailing data window. </param>
        internal TrailingInputData(IDictionary<string, string> columns, string dataContext, MonitoringInputDataType inputDataType, JobInputType jobInputType, Uri uri, IDictionary<string, BinaryData> serializedAdditionalRawData, string preprocessingComponentId, TimeSpan windowOffset, TimeSpan windowSize) : base(columns, dataContext, inputDataType, jobInputType, uri, serializedAdditionalRawData)
        {
            PreprocessingComponentId = preprocessingComponentId;
            WindowOffset = windowOffset;
            WindowSize = windowSize;
            InputDataType = inputDataType;
        }

        /// <summary> Initializes a new instance of <see cref="TrailingInputData"/> for deserialization. </summary>
        internal TrailingInputData()
        {
        }

        /// <summary> The ARM resource ID of the component resource used to preprocess the data. </summary>
        public string PreprocessingComponentId { get; set; }
        /// <summary> [Required] The time offset between the end of the data window and the monitor's current run time. </summary>
        public TimeSpan WindowOffset { get; set; }
        /// <summary> [Required] The size of the trailing data window. </summary>
        public TimeSpan WindowSize { get; set; }
    }
}
