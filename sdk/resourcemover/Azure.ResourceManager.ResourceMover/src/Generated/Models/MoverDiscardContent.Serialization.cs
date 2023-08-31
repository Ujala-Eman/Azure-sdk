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

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoverDiscardContent : IUtf8JsonSerializable, IModelJsonSerializable<MoverDiscardContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MoverDiscardContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MoverDiscardContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ValidateOnly))
            {
                writer.WritePropertyName("validateOnly"u8);
                writer.WriteBooleanValue(ValidateOnly.Value);
            }
            writer.WritePropertyName("moveResources"u8);
            writer.WriteStartArray();
            foreach (var item in MoverResources)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(MoverResourceInputType))
            {
                writer.WritePropertyName("moveResourceInputType"u8);
                writer.WriteStringValue(MoverResourceInputType.Value.ToString());
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

        internal static MoverDiscardContent DeserializeMoverDiscardContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> validateOnly = default;
            IList<ResourceIdentifier> moveResources = default;
            Optional<MoverResourceInputType> moveResourceInputType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validateOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validateOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("moveResources"u8))
                {
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    moveResources = array;
                    continue;
                }
                if (property.NameEquals("moveResourceInputType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    moveResourceInputType = new MoverResourceInputType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MoverDiscardContent(Optional.ToNullable(validateOnly), moveResources, Optional.ToNullable(moveResourceInputType), rawData);
        }

        MoverDiscardContent IModelJsonSerializable<MoverDiscardContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMoverDiscardContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MoverDiscardContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MoverDiscardContent IModelSerializable<MoverDiscardContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMoverDiscardContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MoverDiscardContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MoverDiscardContent"/> to convert. </param>
        public static implicit operator RequestContent(MoverDiscardContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MoverDiscardContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MoverDiscardContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMoverDiscardContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
