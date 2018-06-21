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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A prediction and label pair of an example.
    /// </summary>
    public partial class LabeledUtterance
    {
        /// <summary>
        /// Initializes a new instance of the LabeledUtterance class.
        /// </summary>
        public LabeledUtterance()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LabeledUtterance class.
        /// </summary>
        /// <param name="id">ID of Labeled Utterance.</param>
        /// <param name="text">The utterance. E.g.: what's the weather like in
        /// seattle?</param>
        /// <param name="tokenizedText">The utterance tokenized.</param>
        /// <param name="intentLabel">The intent matching the example.</param>
        /// <param name="entityLabels">The entities matching the
        /// example.</param>
        /// <param name="intentPredictions">List of suggested intents.</param>
        /// <param name="entityPredictions">List of suggested entities.</param>
        public LabeledUtterance(int? id = default(int?), string text = default(string), IList<string> tokenizedText = default(IList<string>), string intentLabel = default(string), IList<EntityLabel> entityLabels = default(IList<EntityLabel>), IList<IntentPrediction> intentPredictions = default(IList<IntentPrediction>), IList<EntityPrediction> entityPredictions = default(IList<EntityPrediction>))
        {
            Id = id;
            Text = text;
            TokenizedText = tokenizedText;
            IntentLabel = intentLabel;
            EntityLabels = entityLabels;
            IntentPredictions = intentPredictions;
            EntityPredictions = entityPredictions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ID of Labeled Utterance.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets the utterance. E.g.: what's the weather like in
        /// seattle?
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        /// Gets or sets the utterance tokenized.
        /// </summary>
        [JsonProperty(PropertyName = "tokenizedText")]
        public IList<string> TokenizedText { get; set; }

        /// <summary>
        /// Gets or sets the intent matching the example.
        /// </summary>
        [JsonProperty(PropertyName = "intentLabel")]
        public string IntentLabel { get; set; }

        /// <summary>
        /// Gets or sets the entities matching the example.
        /// </summary>
        [JsonProperty(PropertyName = "entityLabels")]
        public IList<EntityLabel> EntityLabels { get; set; }

        /// <summary>
        /// Gets or sets list of suggested intents.
        /// </summary>
        [JsonProperty(PropertyName = "intentPredictions")]
        public IList<IntentPrediction> IntentPredictions { get; set; }

        /// <summary>
        /// Gets or sets list of suggested entities.
        /// </summary>
        [JsonProperty(PropertyName = "entityPredictions")]
        public IList<EntityPrediction> EntityPredictions { get; set; }

    }
}
