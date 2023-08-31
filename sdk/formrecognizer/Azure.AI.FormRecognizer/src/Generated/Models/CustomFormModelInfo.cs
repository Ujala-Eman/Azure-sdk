// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Training
{
    /// <summary> Basic custom model information. </summary>
    public partial class CustomFormModelInfo
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CustomFormModelInfo"/>. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="status"> Status of the model. </param>
        /// <param name="trainingStartedOn"> Date and time (UTC) when the model was created. </param>
        /// <param name="trainingCompletedOn"> Date and time (UTC) when the status was last updated. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="modelId"/> is null. </exception>
        internal CustomFormModelInfo(string modelId, CustomFormModelStatus status, DateTimeOffset trainingStartedOn, DateTimeOffset trainingCompletedOn)
        {
            Argument.AssertNotNull(modelId, nameof(modelId));

            ModelId = modelId;
            Status = status;
            TrainingStartedOn = trainingStartedOn;
            TrainingCompletedOn = trainingCompletedOn;
        }

        /// <summary> Initializes a new instance of <see cref="CustomFormModelInfo"/>. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="status"> Status of the model. </param>
        /// <param name="trainingStartedOn"> Date and time (UTC) when the model was created. </param>
        /// <param name="trainingCompletedOn"> Date and time (UTC) when the status was last updated. </param>
        /// <param name="modelName"> Optional user defined model name (max length: 1024). </param>
        /// <param name="properties"> Optional model attributes. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CustomFormModelInfo(string modelId, CustomFormModelStatus status, DateTimeOffset trainingStartedOn, DateTimeOffset trainingCompletedOn, string modelName, CustomFormModelProperties properties, Dictionary<string, BinaryData> rawData)
        {
            ModelId = modelId;
            Status = status;
            TrainingStartedOn = trainingStartedOn;
            TrainingCompletedOn = trainingCompletedOn;
            ModelName = modelName;
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="CustomFormModelInfo"/> for deserialization. </summary>
        internal CustomFormModelInfo()
        {
        }
    }
}
