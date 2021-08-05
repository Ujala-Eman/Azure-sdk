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
    /// A Composite Entity Extractor.
    /// </summary>
    public partial class CompositeEntityExtractor : ModelInfo
    {
        /// <summary>
        /// Initializes a new instance of the CompositeEntityExtractor class.
        /// </summary>
        public CompositeEntityExtractor()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CompositeEntityExtractor class.
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
        /// <param name="children">List of child entities.</param>
        public CompositeEntityExtractor(System.Guid id, string readableType, string name = default(string), int? typeId = default(int?), bool? fuzzyMatchingEnabled = default(bool?), IList<ChildEntity> children = default(IList<ChildEntity>))
            : base(id, readableType, name, typeId, fuzzyMatchingEnabled)
        {
            Children = children;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of child entities.
        /// </summary>
        [JsonProperty(PropertyName = "children")]
        public IList<ChildEntity> Children { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Children != null)
            {
                foreach (var element in Children)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
