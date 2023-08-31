// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    internal partial class SiteRecoveryCreateProtectionContainerProperties : IUtf8JsonSerializable, IModelJsonSerializable<SiteRecoveryCreateProtectionContainerProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SiteRecoveryCreateProtectionContainerProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SiteRecoveryCreateProtectionContainerProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ProviderSpecificContent))
            {
                writer.WritePropertyName("providerSpecificInput"u8);
                writer.WriteStartArray();
                foreach (var item in ProviderSpecificContent)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<ReplicationProviderSpecificContainerCreationContent>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static SiteRecoveryCreateProtectionContainerProperties DeserializeSiteRecoveryCreateProtectionContainerProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<ReplicationProviderSpecificContainerCreationContent>> providerSpecificContent = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("providerSpecificInput"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReplicationProviderSpecificContainerCreationContent> array = new List<ReplicationProviderSpecificContainerCreationContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReplicationProviderSpecificContainerCreationContent.DeserializeReplicationProviderSpecificContainerCreationContent(item));
                    }
                    providerSpecificContent = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SiteRecoveryCreateProtectionContainerProperties(Optional.ToList(providerSpecificContent), rawData);
        }

        SiteRecoveryCreateProtectionContainerProperties IModelJsonSerializable<SiteRecoveryCreateProtectionContainerProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryCreateProtectionContainerProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SiteRecoveryCreateProtectionContainerProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SiteRecoveryCreateProtectionContainerProperties IModelSerializable<SiteRecoveryCreateProtectionContainerProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSiteRecoveryCreateProtectionContainerProperties(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SiteRecoveryCreateProtectionContainerProperties"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SiteRecoveryCreateProtectionContainerProperties"/> to convert. </param>
        public static implicit operator RequestContent(SiteRecoveryCreateProtectionContainerProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SiteRecoveryCreateProtectionContainerProperties"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SiteRecoveryCreateProtectionContainerProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSiteRecoveryCreateProtectionContainerProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
