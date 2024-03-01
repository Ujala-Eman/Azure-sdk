// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Models
{
    /// <summary> The result of Autocomplete requests. </summary>
    public partial class AutocompleteItem
    {
        /// <summary> Initializes a new instance of <see cref="AutocompleteItem"/>. </summary>
        /// <param name="text"> The completed term. </param>
        /// <param name="queryPlusText"> The query along with the completed term. </param>
        internal AutocompleteItem(string text, string queryPlusText)
        {
            Text = text;
            QueryPlusText = queryPlusText;
        }

        /// <summary> The completed term. </summary>
        public string Text { get; }
        /// <summary> The query along with the completed term. </summary>
        public string QueryPlusText { get; }
    }
}
