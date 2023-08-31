// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Abstract class to share properties between concrete selectors. </summary>
    public abstract partial class KnowledgeStoreProjectionSelector
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="KnowledgeStoreProjectionSelector"/>. </summary>
        public KnowledgeStoreProjectionSelector()
        {
            Inputs = new ChangeTrackingList<InputFieldMappingEntry>();
        }

        /// <summary> Initializes a new instance of <see cref="KnowledgeStoreProjectionSelector"/>. </summary>
        /// <param name="referenceKeyName"> Name of reference key to different projection. </param>
        /// <param name="generatedKeyName"> Name of generated key to store projection under. </param>
        /// <param name="source"> Source data to project. </param>
        /// <param name="sourceContext"> Source context for complex projections. </param>
        /// <param name="inputs"> Nested inputs for complex projections. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal KnowledgeStoreProjectionSelector(string referenceKeyName, string generatedKeyName, string source, string sourceContext, IList<InputFieldMappingEntry> inputs, Dictionary<string, BinaryData> rawData)
        {
            ReferenceKeyName = referenceKeyName;
            GeneratedKeyName = generatedKeyName;
            Source = source;
            SourceContext = sourceContext;
            Inputs = inputs;
            _rawData = rawData;
        }

        /// <summary> Name of reference key to different projection. </summary>
        public string ReferenceKeyName { get; set; }
        /// <summary> Name of generated key to store projection under. </summary>
        public string GeneratedKeyName { get; set; }
        /// <summary> Source data to project. </summary>
        public string Source { get; set; }
        /// <summary> Source context for complex projections. </summary>
        public string SourceContext { get; set; }
        /// <summary> Nested inputs for complex projections. </summary>
        public IList<InputFieldMappingEntry> Inputs { get; }
    }
}
