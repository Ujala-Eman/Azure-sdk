// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Messaging.EventGrid.Models
{
    /// <summary> Schema of the Data property of an EventGridEvent for an Microsoft.MachineLearningServices.ModelRegistered event. </summary>
    internal partial class MachineLearningServicesModelRegisteredEventData
    {
        /// <summary> Initializes a new instance of MachineLearningServicesModelRegisteredEventData. </summary>
        internal MachineLearningServicesModelRegisteredEventData()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningServicesModelRegisteredEventData. </summary>
        /// <param name="modelName"> The name of the model that was registered. </param>
        /// <param name="modelVersion"> The version of the model that was registered. </param>
        /// <param name="modelTags"> The tags of the model that was registered. </param>
        /// <param name="modelProperties"> The properties of the model that was registered. </param>
        internal MachineLearningServicesModelRegisteredEventData(string modelName, string modelVersion, object modelTags, object modelProperties)
        {
            ModelName = modelName;
            ModelVersion = modelVersion;
            ModelTags = modelTags;
            ModelProperties = modelProperties;
        }

        /// <summary> The name of the model that was registered. </summary>
        public string ModelName { get; }
        /// <summary> The version of the model that was registered. </summary>
        public string ModelVersion { get; }
        /// <summary> The tags of the model that was registered. </summary>
        public object ModelTags { get; }
        /// <summary> The properties of the model that was registered. </summary>
        public object ModelProperties { get; }
    }
}
