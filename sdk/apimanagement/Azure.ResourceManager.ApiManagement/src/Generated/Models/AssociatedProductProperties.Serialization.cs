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

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class AssociatedProductProperties : IUtf8JsonSerializable, IModelJsonSerializable<AssociatedProductProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AssociatedProductProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AssociatedProductProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AssociatedProductProperties>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Terms))
            {
                writer.WritePropertyName("terms"u8);
                writer.WriteStringValue(Terms);
            }
            if (Optional.IsDefined(IsSubscriptionRequired))
            {
                writer.WritePropertyName("subscriptionRequired"u8);
                writer.WriteBooleanValue(IsSubscriptionRequired.Value);
            }
            if (Optional.IsDefined(IsApprovalRequired))
            {
                writer.WritePropertyName("approvalRequired"u8);
                writer.WriteBooleanValue(IsApprovalRequired.Value);
            }
            if (Optional.IsDefined(SubscriptionsLimit))
            {
                writer.WritePropertyName("subscriptionsLimit"u8);
                writer.WriteNumberValue(SubscriptionsLimit.Value);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToSerialString());
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

        internal static AssociatedProductProperties DeserializeAssociatedProductProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            string name = default;
            Optional<string> description = default;
            Optional<string> terms = default;
            Optional<bool> subscriptionRequired = default;
            Optional<bool> approvalRequired = default;
            Optional<int> subscriptionsLimit = default;
            Optional<ApiManagementProductState> state = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
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
                if (property.NameEquals("terms"u8))
                {
                    terms = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("approvalRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    approvalRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("subscriptionsLimit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionsLimit = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = property.Value.GetString().ToApiManagementProductState();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AssociatedProductProperties(description.Value, terms.Value, Optional.ToNullable(subscriptionRequired), Optional.ToNullable(approvalRequired), Optional.ToNullable(subscriptionsLimit), Optional.ToNullable(state), id.Value, name, rawData);
        }

        AssociatedProductProperties IModelJsonSerializable<AssociatedProductProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AssociatedProductProperties>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAssociatedProductProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AssociatedProductProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AssociatedProductProperties>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AssociatedProductProperties IModelSerializable<AssociatedProductProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<AssociatedProductProperties>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAssociatedProductProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(AssociatedProductProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator AssociatedProductProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAssociatedProductProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
