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
    public partial class ManualActionTaskDetails : IUtf8JsonSerializable, IModelJsonSerializable<ManualActionTaskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManualActionTaskDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManualActionTaskDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ManualActionTaskDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Instructions))
            {
                writer.WritePropertyName("instructions"u8);
                writer.WriteStringValue(Instructions);
            }
            if (Optional.IsDefined(Observation))
            {
                writer.WritePropertyName("observation"u8);
                writer.WriteStringValue(Observation);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        internal static ManualActionTaskDetails DeserializeManualActionTaskDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> instructions = default;
            Optional<string> observation = default;
            string instanceType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instructions"u8))
                {
                    instructions = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("observation"u8))
                {
                    observation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManualActionTaskDetails(instanceType, name.Value, instructions.Value, observation.Value, rawData);
        }

        ManualActionTaskDetails IModelJsonSerializable<ManualActionTaskDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ManualActionTaskDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManualActionTaskDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManualActionTaskDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ManualActionTaskDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManualActionTaskDetails IModelSerializable<ManualActionTaskDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<ManualActionTaskDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManualActionTaskDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManualActionTaskDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManualActionTaskDetails"/> to convert. </param>
        public static implicit operator RequestContent(ManualActionTaskDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManualActionTaskDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManualActionTaskDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManualActionTaskDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
