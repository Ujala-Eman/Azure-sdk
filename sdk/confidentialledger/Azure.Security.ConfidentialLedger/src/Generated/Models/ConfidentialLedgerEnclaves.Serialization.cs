// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Security.ConfidentialLedger.Models
{
    public partial class ConfidentialLedgerEnclaves
    {
        internal static ConfidentialLedgerEnclaves DeserializeConfidentialLedgerEnclaves(JsonElement element)
        {
            string currentNodeId = default;
            IReadOnlyDictionary<string, EnclaveQuote> enclaveQuotes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("currentNodeId"))
                {
                    currentNodeId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enclaveQuotes"))
                {
                    Dictionary<string, EnclaveQuote> dictionary = new Dictionary<string, EnclaveQuote>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, EnclaveQuote.DeserializeEnclaveQuote(property0.Value));
                    }
                    enclaveQuotes = dictionary;
                    continue;
                }
            }
            return new ConfidentialLedgerEnclaves(currentNodeId, enclaveQuotes);
        }
    }
}
