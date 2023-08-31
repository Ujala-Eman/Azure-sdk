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

namespace Azure.ResourceManager.Reservations.Models
{
    public partial class ReservationDetailPatch : IUtf8JsonSerializable, IModelJsonSerializable<ReservationDetailPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ReservationDetailPatch>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ReservationDetailPatch>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AppliedScopeType))
            {
                writer.WritePropertyName("appliedScopeType"u8);
                writer.WriteStringValue(AppliedScopeType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(AppliedScopes))
            {
                writer.WritePropertyName("appliedScopes"u8);
                writer.WriteStartArray();
                foreach (var item in AppliedScopes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AppliedScopeProperties))
            {
                writer.WritePropertyName("appliedScopeProperties"u8);
                if (AppliedScopeProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AppliedScopeProperties>)AppliedScopeProperties).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(InstanceFlexibility))
            {
                writer.WritePropertyName("instanceFlexibility"u8);
                writer.WriteStringValue(InstanceFlexibility.Value.ToString());
            }
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(IsRenewEnabled))
            {
                writer.WritePropertyName("renew"u8);
                writer.WriteBooleanValue(IsRenewEnabled.Value);
            }
            if (Optional.IsDefined(RenewProperties))
            {
                writer.WritePropertyName("renewProperties"u8);
                if (RenewProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<PatchPropertiesRenewProperties>)RenewProperties).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ReviewOn))
            {
                writer.WritePropertyName("reviewDateTime"u8);
                writer.WriteStringValue(ReviewOn.Value, "O");
            }
            writer.WriteEndObject();
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

        internal static ReservationDetailPatch DeserializeReservationDetailPatch(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppliedScopeType> appliedScopeType = default;
            Optional<IList<string>> appliedScopes = default;
            Optional<AppliedScopeProperties> appliedScopeProperties = default;
            Optional<InstanceFlexibility> instanceFlexibility = default;
            Optional<string> name = default;
            Optional<bool> renew = default;
            Optional<PatchPropertiesRenewProperties> renewProperties = default;
            Optional<DateTimeOffset> reviewDateTime = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("appliedScopeType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appliedScopeType = new AppliedScopeType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("appliedScopes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            appliedScopes = array;
                            continue;
                        }
                        if (property0.NameEquals("appliedScopeProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appliedScopeProperties = AppliedScopeProperties.DeserializeAppliedScopeProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("instanceFlexibility"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            instanceFlexibility = new InstanceFlexibility(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("name"u8))
                        {
                            name = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("renew"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            renew = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("renewProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            renewProperties = PatchPropertiesRenewProperties.DeserializePatchPropertiesRenewProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("reviewDateTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            reviewDateTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ReservationDetailPatch(Optional.ToNullable(appliedScopeType), Optional.ToList(appliedScopes), appliedScopeProperties.Value, Optional.ToNullable(instanceFlexibility), name.Value, Optional.ToNullable(renew), renewProperties.Value, Optional.ToNullable(reviewDateTime), rawData);
        }

        ReservationDetailPatch IModelJsonSerializable<ReservationDetailPatch>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeReservationDetailPatch(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ReservationDetailPatch>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ReservationDetailPatch IModelSerializable<ReservationDetailPatch>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeReservationDetailPatch(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ReservationDetailPatch"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ReservationDetailPatch"/> to convert. </param>
        public static implicit operator RequestContent(ReservationDetailPatch model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ReservationDetailPatch"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ReservationDetailPatch(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeReservationDetailPatch(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
