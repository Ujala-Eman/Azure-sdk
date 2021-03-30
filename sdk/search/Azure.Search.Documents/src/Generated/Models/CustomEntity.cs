// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> An object that contains information about the matches that were found, and related metadata. </summary>
    public partial class CustomEntity
    {
        /// <summary> Initializes a new instance of CustomEntity. </summary>
        /// <param name="name"> The top-level entity descriptor. Matches in the skill output will be grouped by this name, and it should represent the &quot;normalized&quot; form of the text being found. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public CustomEntity(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            Aliases = new ChangeTrackingList<CustomEntityAlias>();
        }

        /// <summary> Initializes a new instance of CustomEntity. </summary>
        /// <param name="name"> The top-level entity descriptor. Matches in the skill output will be grouped by this name, and it should represent the &quot;normalized&quot; form of the text being found. </param>
        /// <param name="description"> This field can be used as a passthrough for custom metadata about the matched text(s). The value of this field will appear with every match of its entity in the skill output. </param>
        /// <param name="type"> This field can be used as a passthrough for custom metadata about the matched text(s). The value of this field will appear with every match of its entity in the skill output. </param>
        /// <param name="subtype"> This field can be used as a passthrough for custom metadata about the matched text(s). The value of this field will appear with every match of its entity in the skill output. </param>
        /// <param name="id"> This field can be used as a passthrough for custom metadata about the matched text(s). The value of this field will appear with every match of its entity in the skill output. </param>
        /// <param name="caseSensitive"> Defaults to false. Boolean value denoting whether comparisons with the entity name should be sensitive to character casing. Sample case insensitive matches of &quot;Microsoft&quot; could be: microsoft, microSoft, MICROSOFT. </param>
        /// <param name="accentSensitive"> Defaults to false. Boolean value denoting whether comparisons with the entity name should be sensitive to accent. </param>
        /// <param name="fuzzyEditDistance"> Defaults to 0. Maximum value of 5. Denotes the acceptable number of divergent characters that would still constitute a match with the entity name. The smallest possible fuzziness for any given match is returned. For instance, if the edit distance is set to 3, &quot;Windows10&quot; would still match &quot;Windows&quot;, &quot;Windows10&quot; and &quot;Windows 7&quot;. When case sensitivity is set to false, case differences do NOT count towards fuzziness tolerance, but otherwise do. </param>
        /// <param name="defaultCaseSensitive"> Changes the default case sensitivity value for this entity. It be used to change the default value of all aliases caseSensitive values. </param>
        /// <param name="defaultAccentSensitive"> Changes the default accent sensitivity value for this entity. It be used to change the default value of all aliases accentSensitive values. </param>
        /// <param name="defaultFuzzyEditDistance"> Changes the default fuzzy edit distance value for this entity. It can be used to change the default value of all aliases fuzzyEditDistance values. </param>
        /// <param name="aliases"> An array of complex objects that can be used to specify alternative spellings or synonyms to the root entity name. </param>
        internal CustomEntity(string name, string description, string type, string subtype, string id, bool? caseSensitive, bool? accentSensitive, int? fuzzyEditDistance, bool? defaultCaseSensitive, bool? defaultAccentSensitive, int? defaultFuzzyEditDistance, IList<CustomEntityAlias> aliases)
        {
            Name = name;
            Description = description;
            Type = type;
            Subtype = subtype;
            Id = id;
            CaseSensitive = caseSensitive;
            AccentSensitive = accentSensitive;
            FuzzyEditDistance = fuzzyEditDistance;
            DefaultCaseSensitive = defaultCaseSensitive;
            DefaultAccentSensitive = defaultAccentSensitive;
            DefaultFuzzyEditDistance = defaultFuzzyEditDistance;
            Aliases = aliases;
        }

        /// <summary> The top-level entity descriptor. Matches in the skill output will be grouped by this name, and it should represent the &quot;normalized&quot; form of the text being found. </summary>
        public string Name { get; set; }
        /// <summary> This field can be used as a passthrough for custom metadata about the matched text(s). The value of this field will appear with every match of its entity in the skill output. </summary>
        public string Description { get; set; }
        /// <summary> This field can be used as a passthrough for custom metadata about the matched text(s). The value of this field will appear with every match of its entity in the skill output. </summary>
        public string Type { get; set; }
        /// <summary> This field can be used as a passthrough for custom metadata about the matched text(s). The value of this field will appear with every match of its entity in the skill output. </summary>
        public string Subtype { get; set; }
        /// <summary> This field can be used as a passthrough for custom metadata about the matched text(s). The value of this field will appear with every match of its entity in the skill output. </summary>
        public string Id { get; set; }
        /// <summary> Defaults to false. Boolean value denoting whether comparisons with the entity name should be sensitive to character casing. Sample case insensitive matches of &quot;Microsoft&quot; could be: microsoft, microSoft, MICROSOFT. </summary>
        public bool? CaseSensitive { get; set; }
        /// <summary> Defaults to false. Boolean value denoting whether comparisons with the entity name should be sensitive to accent. </summary>
        public bool? AccentSensitive { get; set; }
        /// <summary> Defaults to 0. Maximum value of 5. Denotes the acceptable number of divergent characters that would still constitute a match with the entity name. The smallest possible fuzziness for any given match is returned. For instance, if the edit distance is set to 3, &quot;Windows10&quot; would still match &quot;Windows&quot;, &quot;Windows10&quot; and &quot;Windows 7&quot;. When case sensitivity is set to false, case differences do NOT count towards fuzziness tolerance, but otherwise do. </summary>
        public int? FuzzyEditDistance { get; set; }
        /// <summary> Changes the default case sensitivity value for this entity. It be used to change the default value of all aliases caseSensitive values. </summary>
        public bool? DefaultCaseSensitive { get; set; }
        /// <summary> Changes the default accent sensitivity value for this entity. It be used to change the default value of all aliases accentSensitive values. </summary>
        public bool? DefaultAccentSensitive { get; set; }
        /// <summary> Changes the default fuzzy edit distance value for this entity. It can be used to change the default value of all aliases fuzzyEditDistance values. </summary>
        public int? DefaultFuzzyEditDistance { get; set; }
        /// <summary> An array of complex objects that can be used to specify alternative spellings or synonyms to the root entity name. </summary>
        public IList<CustomEntityAlias> Aliases { get; set; }
    }
}
