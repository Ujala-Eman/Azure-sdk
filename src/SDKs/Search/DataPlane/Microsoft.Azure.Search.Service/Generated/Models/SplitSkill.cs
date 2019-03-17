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
    /// A skill to split a string into chunks of text.
    /// <see
    /// href="https://docs.microsoft.com/azure/search/cognitive-search-skill-textsplit"
    /// />
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Skills.Text.SplitSkill")]
    public partial class SplitSkill : Skill
    {
        /// <summary>
        /// Initializes a new instance of the SplitSkill class.
        /// </summary>
        public SplitSkill()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SplitSkill class.
        /// </summary>
        /// <param name="description">The description of the skill which
        /// describes the inputs, outputs, and usage of the skill.</param>
        /// <param name="context">Represents the level at which operations take
        /// place, such as the document root or document content (for example,
        /// /document or /document/content). The default is /document.</param>
        /// <param name="inputs">Inputs of the skills could be a column in the
        /// source data set, or the output of an upstream skill.</param>
        /// <param name="outputs">The output of a skill is either a field in an
        /// Azure Search index, or a value that can be consumed as an input by
        /// another skill.</param>
        /// <param name="defaultLanguageCode">A value indicating which language
        /// code to use. Default is en. Possible values include: 'da', 'de',
        /// 'en', 'es', 'fi', 'fr', 'it', 'ko', 'pt'</param>
        /// <param name="textSplitMode">A value indicating which split mode to
        /// perform. Possible values include: 'pages', 'sentences'</param>
        /// <param name="maximumPageLength">The desired maximum page length.
        /// Default is 10000.</param>
        public SplitSkill(string description = default(string), string context = default(string), IList<InputFieldMappingEntry> inputs = default(IList<InputFieldMappingEntry>), IList<OutputFieldMappingEntry> outputs = default(IList<OutputFieldMappingEntry>), SplitSkillLanguage? defaultLanguageCode = default(SplitSkillLanguage?), TextSplitMode? textSplitMode = default(TextSplitMode?), int? maximumPageLength = default(int?))
            : base(description, context, inputs, outputs)
        {
            DefaultLanguageCode = defaultLanguageCode;
            TextSplitMode = textSplitMode;
            MaximumPageLength = maximumPageLength;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a value indicating which language code to use. Default
        /// is en. Possible values include: 'da', 'de', 'en', 'es', 'fi', 'fr',
        /// 'it', 'ko', 'pt'
        /// </summary>
        [JsonProperty(PropertyName = "defaultLanguageCode")]
        public SplitSkillLanguage? DefaultLanguageCode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating which split mode to perform.
        /// Possible values include: 'pages', 'sentences'
        /// </summary>
        [JsonProperty(PropertyName = "textSplitMode")]
        public TextSplitMode? TextSplitMode { get; set; }

        /// <summary>
        /// Gets or sets the desired maximum page length. Default is 10000.
        /// </summary>
        [JsonProperty(PropertyName = "maximumPageLength")]
        public int? MaximumPageLength { get; set; }

    }
}
