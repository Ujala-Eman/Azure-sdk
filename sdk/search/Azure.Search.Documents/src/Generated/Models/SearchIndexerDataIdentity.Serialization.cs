// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchIndexerDataIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            writer.WriteEndObject();
        }

        internal static SearchIndexerDataIdentity DeserializeSearchIndexerDataIdentity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Azure.Search.DataNoneIdentity": return SearchIndexerDataNoneIdentity.DeserializeSearchIndexerDataNoneIdentity(element);
                    case "#Microsoft.Azure.Search.DataUserAssignedIdentity": return SearchIndexerDataUserAssignedIdentity.DeserializeSearchIndexerDataUserAssignedIdentity(element);
                }
            }
            return UnknownSearchIndexerDataIdentity.DeserializeUnknownSearchIndexerDataIdentity(element);
        }
    }
}
