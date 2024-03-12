// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The LanguageBatchInput. </summary>
    internal partial class LanguageBatchInput
    {
        /// <summary> Initializes a new instance of <see cref="LanguageBatchInput"/>. </summary>
        /// <param name="documents"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="documents"/> is null. </exception>
        public LanguageBatchInput(IEnumerable<LanguageInput> documents)
        {
            Argument.AssertNotNull(documents, nameof(documents));

            Documents = documents.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="LanguageBatchInput"/>. </summary>
        /// <param name="documents"></param>
        internal LanguageBatchInput(IList<LanguageInput> documents)
        {
            Documents = documents;
        }

        /// <summary> Gets the documents. </summary>
        public IList<LanguageInput> Documents { get; }
    }
}
