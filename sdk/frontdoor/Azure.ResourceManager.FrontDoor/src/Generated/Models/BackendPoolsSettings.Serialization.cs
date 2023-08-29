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

namespace Azure.ResourceManager.FrontDoor.Models
{
    public partial class BackendPoolsSettings : IUtf8JsonSerializable, IModelJsonSerializable<BackendPoolsSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BackendPoolsSettings>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BackendPoolsSettings>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(EnforceCertificateNameCheck))
            {
                writer.WritePropertyName("enforceCertificateNameCheck"u8);
                writer.WriteStringValue(EnforceCertificateNameCheck.Value.ToString());
            }
            if (Optional.IsDefined(SendRecvTimeoutInSeconds))
            {
                writer.WritePropertyName("sendRecvTimeoutSeconds"u8);
                writer.WriteNumberValue(SendRecvTimeoutInSeconds.Value);
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

        internal static BackendPoolsSettings DeserializeBackendPoolsSettings(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<EnforceCertificateNameCheckEnabledState> enforceCertificateNameCheck = default;
            Optional<int> sendRecvTimeoutSeconds = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enforceCertificateNameCheck"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enforceCertificateNameCheck = new EnforceCertificateNameCheckEnabledState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sendRecvTimeoutSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sendRecvTimeoutSeconds = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new BackendPoolsSettings(Optional.ToNullable(enforceCertificateNameCheck), Optional.ToNullable(sendRecvTimeoutSeconds), rawData);
        }

        BackendPoolsSettings IModelJsonSerializable<BackendPoolsSettings>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBackendPoolsSettings(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BackendPoolsSettings>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BackendPoolsSettings IModelSerializable<BackendPoolsSettings>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBackendPoolsSettings(doc.RootElement, options);
        }

        public static implicit operator RequestContent(BackendPoolsSettings model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator BackendPoolsSettings(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBackendPoolsSettings(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
