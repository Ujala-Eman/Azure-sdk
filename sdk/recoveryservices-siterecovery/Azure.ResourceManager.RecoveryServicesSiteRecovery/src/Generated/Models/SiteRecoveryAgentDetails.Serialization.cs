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
    public partial class SiteRecoveryAgentDetails : IUtf8JsonSerializable, IModelJsonSerializable<SiteRecoveryAgentDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SiteRecoveryAgentDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SiteRecoveryAgentDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static SiteRecoveryAgentDetails DeserializeSiteRecoveryAgentDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> agentId = default;
            Optional<string> machineId = default;
            Optional<string> biosId = default;
            Optional<string> fqdn = default;
            Optional<IReadOnlyList<SiteRecoveryAgentDiskDetails>> disks = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("agentId"u8))
                {
                    agentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineId"u8))
                {
                    machineId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("biosId"u8))
                {
                    biosId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fqdn"u8))
                {
                    fqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disks"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SiteRecoveryAgentDiskDetails> array = new List<SiteRecoveryAgentDiskDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SiteRecoveryAgentDiskDetails.DeserializeSiteRecoveryAgentDiskDetails(item));
                    }
                    disks = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SiteRecoveryAgentDetails(agentId.Value, machineId.Value, biosId.Value, fqdn.Value, Optional.ToList(disks), rawData);
        }

        SiteRecoveryAgentDetails IModelJsonSerializable<SiteRecoveryAgentDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryAgentDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SiteRecoveryAgentDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SiteRecoveryAgentDetails IModelSerializable<SiteRecoveryAgentDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSiteRecoveryAgentDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SiteRecoveryAgentDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SiteRecoveryAgentDetails"/> to convert. </param>
        public static implicit operator RequestContent(SiteRecoveryAgentDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SiteRecoveryAgentDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SiteRecoveryAgentDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSiteRecoveryAgentDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
