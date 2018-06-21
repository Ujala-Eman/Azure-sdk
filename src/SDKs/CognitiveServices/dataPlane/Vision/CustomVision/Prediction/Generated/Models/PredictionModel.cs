// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.CustomVision.Prediction.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PredictionModel
    {
        /// <summary>
        /// Initializes a new instance of the PredictionModel class.
        /// </summary>
        public PredictionModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PredictionModel class.
        /// </summary>
        public PredictionModel(double probability = default(double), System.Guid tagId = default(System.Guid), string tagName = default(string), BoundingBox boundingBox = default(BoundingBox))
        {
            Probability = probability;
            TagId = tagId;
            TagName = tagName;
            BoundingBox = boundingBox;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "probability")]
        public double Probability { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tagId")]
        public System.Guid TagId { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tagName")]
        public string TagName { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "boundingBox")]
        public BoundingBox BoundingBox { get; private set; }

    }
}
