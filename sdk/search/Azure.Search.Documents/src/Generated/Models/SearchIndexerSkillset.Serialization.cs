// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchIndexerSkillset : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("skills"u8);
            writer.WriteStartArray();
            foreach (var item in Skills)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (CognitiveServicesAccount != null)
            {
                writer.WritePropertyName("cognitiveServices"u8);
                writer.WriteObjectValue(CognitiveServicesAccount);
            }
            if (KnowledgeStore != null)
            {
                writer.WritePropertyName("knowledgeStore"u8);
                writer.WriteObjectValue(KnowledgeStore);
            }
            if (IndexProjections != null)
            {
                writer.WritePropertyName("indexProjections"u8);
                writer.WriteObjectValue(IndexProjections);
            }
            if (_etag != null)
            {
                writer.WritePropertyName("@odata.etag"u8);
                writer.WriteStringValue(_etag);
            }
            if (EncryptionKey != null)
            {
                if (EncryptionKey != null)
                {
                    writer.WritePropertyName("encryptionKey"u8);
                    writer.WriteObjectValue(EncryptionKey);
                }
                else
                {
                    writer.WriteNull("encryptionKey");
                }
            }
            writer.WriteEndObject();
        }

        internal static SearchIndexerSkillset DeserializeSearchIndexerSkillset(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<string> description = default;
            IList<SearchIndexerSkill> skills = default;
            Optional<CognitiveServicesAccount> cognitiveServices = default;
            Optional<KnowledgeStore> knowledgeStore = default;
            Optional<SearchIndexerIndexProjections> indexProjections = default;
            Optional<string> odataEtag = default;
            Optional<SearchResourceEncryptionKey> encryptionKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skills"u8))
                {
                    List<SearchIndexerSkill> array = new List<SearchIndexerSkill>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SearchIndexerSkill.DeserializeSearchIndexerSkill(item));
                    }
                    skills = array;
                    continue;
                }
                if (property.NameEquals("cognitiveServices"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cognitiveServices = CognitiveServicesAccount.DeserializeCognitiveServicesAccount(property.Value);
                    continue;
                }
                if (property.NameEquals("knowledgeStore"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    knowledgeStore = KnowledgeStore.DeserializeKnowledgeStore(property.Value);
                    continue;
                }
                if (property.NameEquals("indexProjections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    indexProjections = SearchIndexerIndexProjections.DeserializeSearchIndexerIndexProjections(property.Value);
                    continue;
                }
                if (property.NameEquals("@odata.etag"u8))
                {
                    odataEtag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("encryptionKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        encryptionKey = null;
                        continue;
                    }
                    encryptionKey = SearchResourceEncryptionKey.DeserializeSearchResourceEncryptionKey(property.Value);
                    continue;
                }
            }
            return new SearchIndexerSkillset(name, description.Value, skills, cognitiveServices.Value, knowledgeStore.Value, indexProjections.Value, odataEtag.Value, encryptionKey.Value);
        }
    }
}
