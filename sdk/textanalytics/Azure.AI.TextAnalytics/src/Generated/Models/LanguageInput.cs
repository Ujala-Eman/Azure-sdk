// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The LanguageInput. </summary>
    internal partial class LanguageInput
    {
        /// <summary> Initializes a new instance of LanguageInput. </summary>
        /// <param name="id"> Unique, non-empty document identifier. </param>
        /// <param name="text"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="text"/> is null. </exception>
        public LanguageInput(string id, string text)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }

            Id = id;
            Text = text;
        }

        /// <summary> Unique, non-empty document identifier. </summary>
        public string Id { get; }
        public string Text { get; }
        public string CountryHint { get; set; }
    }
}
