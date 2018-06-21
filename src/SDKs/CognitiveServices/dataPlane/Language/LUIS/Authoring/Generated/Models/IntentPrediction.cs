// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A suggested intent.
    /// </summary>
    public partial class IntentPrediction
    {
        /// <summary>
        /// Initializes a new instance of the IntentPrediction class.
        /// </summary>
        public IntentPrediction()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IntentPrediction class.
        /// </summary>
        /// <param name="name">The intent's name</param>
        /// <param name="score">The intent's score, based on the prediction
        /// model.</param>
        public IntentPrediction(string name = default(string), double? score = default(double?))
        {
            Name = name;
            Score = score;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the intent's name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the intent's score, based on the prediction model.
        /// </summary>
        [JsonProperty(PropertyName = "score")]
        public double? Score { get; set; }

    }
}
