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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class JitNetworkAccessPolicyData : IUtf8JsonSerializable, IModelJsonSerializable<JitNetworkAccessPolicyData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<JitNetworkAccessPolicyData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<JitNetworkAccessPolicyData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("virtualMachines"u8);
            writer.WriteStartArray();
            foreach (var item in VirtualMachines)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<JitNetworkAccessPolicyVirtualMachine>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Requests))
            {
                writer.WritePropertyName("requests"u8);
                writer.WriteStartArray();
                foreach (var item in Requests)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<JitNetworkAccessRequestInfo>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
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

        internal static JitNetworkAccessPolicyData DeserializeJitNetworkAccessPolicyData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            IList<JitNetworkAccessPolicyVirtualMachine> virtualMachines = default;
            Optional<IList<JitNetworkAccessRequestInfo>> requests = default;
            Optional<string> provisioningState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("virtualMachines"u8))
                        {
                            List<JitNetworkAccessPolicyVirtualMachine> array = new List<JitNetworkAccessPolicyVirtualMachine>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JitNetworkAccessPolicyVirtualMachine.DeserializeJitNetworkAccessPolicyVirtualMachine(item));
                            }
                            virtualMachines = array;
                            continue;
                        }
                        if (property0.NameEquals("requests"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<JitNetworkAccessRequestInfo> array = new List<JitNetworkAccessRequestInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(JitNetworkAccessRequestInfo.DeserializeJitNetworkAccessRequestInfo(item));
                            }
                            requests = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
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
            return new JitNetworkAccessPolicyData(id, name, type, systemData.Value, virtualMachines, Optional.ToList(requests), provisioningState.Value, kind.Value, Optional.ToNullable(location), rawData);
        }

        JitNetworkAccessPolicyData IModelJsonSerializable<JitNetworkAccessPolicyData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeJitNetworkAccessPolicyData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<JitNetworkAccessPolicyData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        JitNetworkAccessPolicyData IModelSerializable<JitNetworkAccessPolicyData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeJitNetworkAccessPolicyData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="JitNetworkAccessPolicyData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="JitNetworkAccessPolicyData"/> to convert. </param>
        public static implicit operator RequestContent(JitNetworkAccessPolicyData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="JitNetworkAccessPolicyData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator JitNetworkAccessPolicyData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeJitNetworkAccessPolicyData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
