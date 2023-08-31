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

namespace Azure.ResourceManager.DigitalTwins.Models
{
    public partial class DigitalTwinsEndpointResourceProperties : IUtf8JsonSerializable, IModelJsonSerializable<DigitalTwinsEndpointResourceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DigitalTwinsEndpointResourceProperties>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DigitalTwinsEndpointResourceProperties>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
            if (Optional.IsDefined(AuthenticationType))
            {
                writer.WritePropertyName("authenticationType"u8);
                writer.WriteStringValue(AuthenticationType.Value.ToString());
            }
            if (Optional.IsDefined(DeadLetterSecret))
            {
                if (DeadLetterSecret != null)
                {
                    writer.WritePropertyName("deadLetterSecret"u8);
                    writer.WriteStringValue(DeadLetterSecret);
                }
                else
                {
                    writer.WriteNull("deadLetterSecret");
                }
            }
            if (Optional.IsDefined(DeadLetterUri))
            {
                if (DeadLetterUri != null)
                {
                    writer.WritePropertyName("deadLetterUri"u8);
                    writer.WriteStringValue(DeadLetterUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("deadLetterUri");
                }
            }
            if (Optional.IsDefined(Identity))
            {
                if (Identity != null)
                {
                    writer.WritePropertyName("identity"u8);
                    writer.WriteObjectValue(Identity);
                }
                else
                {
                    writer.WriteNull("identity");
                }
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

        internal static DigitalTwinsEndpointResourceProperties DeserializeDigitalTwinsEndpointResourceProperties(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("endpointType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "EventGrid": return DigitalTwinsEventGridProperties.DeserializeDigitalTwinsEventGridProperties(element);
                    case "EventHub": return DigitalTwinsEventHubProperties.DeserializeDigitalTwinsEventHubProperties(element);
                    case "ServiceBus": return DigitalTwinsServiceBusProperties.DeserializeDigitalTwinsServiceBusProperties(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            EndpointType endpointType = default;
            Optional<DigitalTwinsEndpointProvisioningState?> provisioningState = default;
            Optional<DateTimeOffset?> createdTime = default;
            Optional<DigitalTwinsAuthenticationType> authenticationType = default;
            Optional<string> deadLetterSecret = default;
            Optional<Uri> deadLetterUri = default;
            Optional<DigitalTwinsManagedIdentityReference> identity = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("endpointType"u8))
                {
                    endpointType = new EndpointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        provisioningState = null;
                        continue;
                    }
                    provisioningState = new DigitalTwinsEndpointProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("createdTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        createdTime = null;
                        continue;
                    }
                    createdTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationType = new DigitalTwinsAuthenticationType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deadLetterSecret"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        deadLetterSecret = null;
                        continue;
                    }
                    deadLetterSecret = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deadLetterUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        deadLetterUri = null;
                        continue;
                    }
                    deadLetterUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        identity = null;
                        continue;
                    }
                    identity = DigitalTwinsManagedIdentityReference.DeserializeDigitalTwinsManagedIdentityReference(property.Value);
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownDigitalTwinsEndpointResourceProperties(endpointType, Optional.ToNullable(provisioningState), Optional.ToNullable(createdTime), Optional.ToNullable(authenticationType), deadLetterSecret.Value, deadLetterUri.Value, identity.Value, rawData);
        }

        DigitalTwinsEndpointResourceProperties IModelJsonSerializable<DigitalTwinsEndpointResourceProperties>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDigitalTwinsEndpointResourceProperties(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DigitalTwinsEndpointResourceProperties>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DigitalTwinsEndpointResourceProperties IModelSerializable<DigitalTwinsEndpointResourceProperties>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDigitalTwinsEndpointResourceProperties(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DigitalTwinsEndpointResourceProperties model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DigitalTwinsEndpointResourceProperties(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDigitalTwinsEndpointResourceProperties(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
