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
    public partial class SiteRecoveryPlanGroup : IUtf8JsonSerializable, IModelJsonSerializable<SiteRecoveryPlanGroup>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SiteRecoveryPlanGroup>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SiteRecoveryPlanGroup>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("groupType"u8);
            writer.WriteStringValue(GroupType.ToString());
            if (Optional.IsCollectionDefined(ReplicationProtectedItems))
            {
                writer.WritePropertyName("replicationProtectedItems"u8);
                writer.WriteStartArray();
                foreach (var item in ReplicationProtectedItems)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<RecoveryPlanProtectedItem>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(StartGroupActions))
            {
                writer.WritePropertyName("startGroupActions"u8);
                writer.WriteStartArray();
                foreach (var item in StartGroupActions)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<RecoveryPlanAction>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(EndGroupActions))
            {
                writer.WritePropertyName("endGroupActions"u8);
                writer.WriteStartArray();
                foreach (var item in EndGroupActions)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<RecoveryPlanAction>)item).Serialize(writer, options);
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

        internal static SiteRecoveryPlanGroup DeserializeSiteRecoveryPlanGroup(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RecoveryPlanGroupType groupType = default;
            Optional<IList<RecoveryPlanProtectedItem>> replicationProtectedItems = default;
            Optional<IList<RecoveryPlanAction>> startGroupActions = default;
            Optional<IList<RecoveryPlanAction>> endGroupActions = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupType"u8))
                {
                    groupType = new RecoveryPlanGroupType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("replicationProtectedItems"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecoveryPlanProtectedItem> array = new List<RecoveryPlanProtectedItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryPlanProtectedItem.DeserializeRecoveryPlanProtectedItem(item));
                    }
                    replicationProtectedItems = array;
                    continue;
                }
                if (property.NameEquals("startGroupActions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecoveryPlanAction> array = new List<RecoveryPlanAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryPlanAction.DeserializeRecoveryPlanAction(item));
                    }
                    startGroupActions = array;
                    continue;
                }
                if (property.NameEquals("endGroupActions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecoveryPlanAction> array = new List<RecoveryPlanAction>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryPlanAction.DeserializeRecoveryPlanAction(item));
                    }
                    endGroupActions = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SiteRecoveryPlanGroup(groupType, Optional.ToList(replicationProtectedItems), Optional.ToList(startGroupActions), Optional.ToList(endGroupActions), rawData);
        }

        SiteRecoveryPlanGroup IModelJsonSerializable<SiteRecoveryPlanGroup>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryPlanGroup(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SiteRecoveryPlanGroup>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SiteRecoveryPlanGroup IModelSerializable<SiteRecoveryPlanGroup>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSiteRecoveryPlanGroup(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SiteRecoveryPlanGroup"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SiteRecoveryPlanGroup"/> to convert. </param>
        public static implicit operator RequestContent(SiteRecoveryPlanGroup model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SiteRecoveryPlanGroup"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SiteRecoveryPlanGroup(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSiteRecoveryPlanGroup(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
