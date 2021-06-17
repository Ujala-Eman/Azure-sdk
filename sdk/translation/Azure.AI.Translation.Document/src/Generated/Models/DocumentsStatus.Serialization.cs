// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.Translation.Document;
using Azure.Core;

namespace Azure.AI.Translation.Document.Models
{
    internal partial class DocumentsStatus
    {
        internal static DocumentsStatus DeserializeDocumentsStatus(JsonElement element)
        {
            IReadOnlyList<DocumentStatusResult> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<DocumentStatusResult> array = new List<DocumentStatusResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentStatusResult.DeserializeDocumentStatusResult(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new DocumentsStatus(value, nextLink.Value);
        }
    }
}
