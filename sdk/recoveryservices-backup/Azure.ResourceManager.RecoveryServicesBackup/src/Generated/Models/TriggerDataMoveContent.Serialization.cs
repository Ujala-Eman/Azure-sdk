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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class TriggerDataMoveContent : IUtf8JsonSerializable, IModelJsonSerializable<TriggerDataMoveContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<TriggerDataMoveContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<TriggerDataMoveContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("sourceResourceId"u8);
            writer.WriteStringValue(SourceResourceId);
            writer.WritePropertyName("sourceRegion"u8);
            writer.WriteStringValue(SourceRegion);
            writer.WritePropertyName("dataMoveLevel"u8);
            writer.WriteStringValue(DataMoveLevel.ToString());
            writer.WritePropertyName("correlationId"u8);
            writer.WriteStringValue(CorrelationId);
            if (Optional.IsCollectionDefined(SourceContainerArmIds))
            {
                writer.WritePropertyName("sourceContainerArmIds"u8);
                writer.WriteStartArray();
                foreach (var item in SourceContainerArmIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DoesPauseGC))
            {
                writer.WritePropertyName("pauseGC"u8);
                writer.WriteBooleanValue(DoesPauseGC.Value);
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

        internal static TriggerDataMoveContent DeserializeTriggerDataMoveContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier sourceResourceId = default;
            AzureLocation sourceRegion = default;
            DataMoveLevel dataMoveLevel = default;
            string correlationId = default;
            Optional<IList<ResourceIdentifier>> sourceContainerArmIds = default;
            Optional<bool> pauseGC = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceResourceId"u8))
                {
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceRegion"u8))
                {
                    sourceRegion = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dataMoveLevel"u8))
                {
                    dataMoveLevel = new DataMoveLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceContainerArmIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
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
                    sourceContainerArmIds = array;
                    continue;
                }
                if (property.NameEquals("pauseGC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pauseGC = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new TriggerDataMoveContent(sourceResourceId, sourceRegion, dataMoveLevel, correlationId, Optional.ToList(sourceContainerArmIds), Optional.ToNullable(pauseGC), rawData);
        }

        TriggerDataMoveContent IModelJsonSerializable<TriggerDataMoveContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeTriggerDataMoveContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<TriggerDataMoveContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        TriggerDataMoveContent IModelSerializable<TriggerDataMoveContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeTriggerDataMoveContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="TriggerDataMoveContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="TriggerDataMoveContent"/> to convert. </param>
        public static implicit operator RequestContent(TriggerDataMoveContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="TriggerDataMoveContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator TriggerDataMoveContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeTriggerDataMoveContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
