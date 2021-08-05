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
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Base type used in entity types.
    /// </summary>
    public partial class ModelInfo
    {
        /// <summary>
        /// Initializes a new instance of the ModelInfo class.
        /// </summary>
        public ModelInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ModelInfo class.
        /// </summary>
        /// <param name="id">The ID of the Entity Model.</param>
        /// <param name="readableType">Possible values include: 'Entity
        /// Extractor', 'Child Entity Extractor', 'Hierarchical Entity
        /// Extractor', 'Hierarchical Child Entity Extractor', 'Composite
        /// Entity Extractor', 'List Entity Extractor', 'Prebuilt Entity
        /// Extractor', 'Intent Classifier', 'Pattern.Any Entity Extractor',
        /// 'Closed List Entity Extractor', 'Regex Entity Extractor'</param>
        /// <param name="name">Name of the Entity Model.</param>
        /// <param name="typeId">The type ID of the Entity Model.</param>
        /// <param name="fuzzyMatchingEnabled">Enables the fuzzy matching for
        /// the list of entities</param>
        public ModelInfo(System.Guid id, string readableType, string name = default(string), int? typeId = default(int?), bool? fuzzyMatchingEnabled = default(bool?))
        {
            Id = id;
            Name = name;
            TypeId = typeId;
            ReadableType = readableType;
            FuzzyMatchingEnabled = fuzzyMatchingEnabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of the Entity Model.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public System.Guid Id { get; set; }

        /// <summary>
        /// Gets or sets name of the Entity Model.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type ID of the Entity Model.
        /// </summary>
        [JsonProperty(PropertyName = "typeId")]
        public int? TypeId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Entity Extractor', 'Child
        /// Entity Extractor', 'Hierarchical Entity Extractor', 'Hierarchical
        /// Child Entity Extractor', 'Composite Entity Extractor', 'List Entity
        /// Extractor', 'Prebuilt Entity Extractor', 'Intent Classifier',
        /// 'Pattern.Any Entity Extractor', 'Closed List Entity Extractor',
        /// 'Regex Entity Extractor'
        /// </summary>
        [JsonProperty(PropertyName = "readableType")]
        public string ReadableType { get; set; }

        /// <summary>
        /// Gets or sets enables the fuzzy matching for the list of entities
        /// </summary>
        [JsonProperty(PropertyName = "fuzzyMatchingEnabled")]
        public bool? FuzzyMatchingEnabled { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ReadableType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ReadableType");
            }
        }
    }
}
