// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Text analytics key phrase extraction.
    /// <see
    /// href="https://docs.microsoft.com/azure/search/cognitive-search-skill-keyphrases"
    /// />
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Skills.Text.KeyPhraseExtractionSkill")]
    public partial class KeyPhraseExtractionSkill : Skill
    {
        /// <summary>
        /// Initializes a new instance of the KeyPhraseExtractionSkill class.
        /// </summary>
        public KeyPhraseExtractionSkill()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyPhraseExtractionSkill class.
        /// </summary>
        /// <param name="description">The description of the skill which
        /// describes the inputs, outputs, and usage of the skill.</param>
        /// <param name="context">The context of the skill.</param>
        /// <param name="inputs">The inputs of the skill.</param>
        /// <param name="outputs">The outputs of the skill.</param>
        /// <param name="defaultLanguageCode">A value indicating which language
        /// code to use. Default is en.</param>
        public KeyPhraseExtractionSkill(string description, string context, IList<InputFieldMappingEntry> inputs, IList<OutputFieldMappingEntry> outputs, KeyPhraseExtractionSkillLanguage defaultLanguageCode = default(KeyPhraseExtractionSkillLanguage), int? maxKeyPhraseCount = default(int?))
            : base(description, context, inputs, outputs)
        {
            DefaultLanguageCode = defaultLanguageCode;
            MaxKeyPhraseCount = maxKeyPhraseCount;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a value indicating which language code to use. Default
        /// is en.
        /// </summary>
        [JsonProperty(PropertyName = "defaultLanguageCode")]
        public KeyPhraseExtractionSkillLanguage DefaultLanguageCode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maxKeyPhraseCount")]
        public int? MaxKeyPhraseCount { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
