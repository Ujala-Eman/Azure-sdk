// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Fixed input data definition. </summary>
    public partial class FixedInputData : MonitoringInputDataBase
    {
        /// <summary> Initializes a new instance of <see cref="FixedInputData"/>. </summary>
        /// <param name="jobInputType"> [Required] Specifies the type of job. </param>
        /// <param name="uri"> [Required] Input Asset URI. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public FixedInputData(JobInputType jobInputType, Uri uri) : base(jobInputType, uri)
        {
            Argument.AssertNotNull(uri, nameof(uri));

            InputDataType = MonitoringInputDataType.Fixed;
        }

        /// <summary> Initializes a new instance of <see cref="FixedInputData"/>. </summary>
        /// <param name="inputDataType"> [Required] Specifies the type of signal to monitor. </param>
        /// <param name="dataContext"> The context metadata of the data source. </param>
        /// <param name="jobInputType"> [Required] Specifies the type of job. </param>
        /// <param name="uri"> [Required] Input Asset URI. </param>
        /// <param name="columns"> Mapping of column names to special uses. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FixedInputData(MonitoringInputDataType inputDataType, string dataContext, JobInputType jobInputType, Uri uri, IDictionary<string, string> columns, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(inputDataType, dataContext, jobInputType, uri, columns, serializedAdditionalRawData)
        {
            InputDataType = inputDataType;
        }

        /// <summary> Initializes a new instance of <see cref="FixedInputData"/> for deserialization. </summary>
        internal FixedInputData()
        {
        }
    }
}
