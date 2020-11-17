// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class KeyPhraseExtractionTasksItemProperties
    {
        internal static KeyPhraseExtractionTasksItemProperties DeserializeKeyPhraseExtractionTasksItemProperties(JsonElement element)
        {
            KeyPhraseResult results = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"))
                {
                    results = KeyPhraseResult.DeserializeKeyPhraseResult(property.Value);
                    continue;
                }
            }
            return new KeyPhraseExtractionTasksItemProperties(results);
        }
    }
}
