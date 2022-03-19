// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.AI.TextAnalytics;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The PiiDocumentEntities. </summary>
    internal partial class PiiDocumentEntities
    {
        /// <summary> Initializes a new instance of PiiDocumentEntities. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="redactedText"> Returns redacted text. </param>
        /// <param name="entities"> Recognized entities in the document. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="redactedText"/>, <paramref name="entities"/> or <paramref name="warnings"/> is null. </exception>
        internal PiiDocumentEntities(string id, string redactedText, IEnumerable<Entity> entities, IEnumerable<TextAnalyticsWarningInternal> warnings)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (redactedText == null)
            {
                throw new ArgumentNullException(nameof(redactedText));
            }
            if (entities == null)
            {
                throw new ArgumentNullException(nameof(entities));
            }
            if (warnings == null)
            {
                throw new ArgumentNullException(nameof(warnings));
            }

            Id = id;
            RedactedText = redactedText;
            Entities = entities.ToList();
            Warnings = warnings.ToList();
        }

        /// <summary> Initializes a new instance of PiiDocumentEntities. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="redactedText"> Returns redacted text. </param>
        /// <param name="entities"> Recognized entities in the document. </param>
        /// <param name="warnings"> Warnings encountered while processing document. </param>
        /// <param name="statistics"> if showStats=true was specified in the request this field will contain information about the document payload. </param>
        internal PiiDocumentEntities(string id, string redactedText, IReadOnlyList<Entity> entities, IReadOnlyList<TextAnalyticsWarningInternal> warnings, TextDocumentStatistics? statistics)
        {
            Id = id;
            RedactedText = redactedText;
            Entities = entities;
            Warnings = warnings;
            Statistics = statistics;
        }

        /// <summary> Unique, non-empty document identifier. </summary>
        public string Id { get; }
        /// <summary> Returns redacted text. </summary>
        public string RedactedText { get; }
        /// <summary> Recognized entities in the document. </summary>
        public IReadOnlyList<Entity> Entities { get; }
        /// <summary> Warnings encountered while processing document. </summary>
        public IReadOnlyList<TextAnalyticsWarningInternal> Warnings { get; }
        /// <summary> if showStats=true was specified in the request this field will contain information about the document payload. </summary>
        public TextDocumentStatistics? Statistics { get; }
    }
}
