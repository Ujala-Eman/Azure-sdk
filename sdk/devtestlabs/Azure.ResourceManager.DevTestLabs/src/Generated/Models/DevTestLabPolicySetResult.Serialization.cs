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

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabPolicySetResult : IUtf8JsonSerializable, IModelJsonSerializable<DevTestLabPolicySetResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DevTestLabPolicySetResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DevTestLabPolicySetResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(HasError))
            {
                writer.WritePropertyName("hasError"u8);
                writer.WriteBooleanValue(HasError.Value);
            }
            if (Optional.IsCollectionDefined(PolicyViolations))
            {
                writer.WritePropertyName("policyViolations"u8);
                writer.WriteStartArray();
                foreach (var item in PolicyViolations)
                {
                    writer.WriteObjectValue(item);
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

        internal static DevTestLabPolicySetResult DeserializeDevTestLabPolicySetResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> hasError = default;
            Optional<IReadOnlyList<DevTestLabPolicyViolation>> policyViolations = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hasError"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hasError = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("policyViolations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DevTestLabPolicyViolation> array = new List<DevTestLabPolicyViolation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DevTestLabPolicyViolation.DeserializeDevTestLabPolicyViolation(item));
                    }
                    policyViolations = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DevTestLabPolicySetResult(Optional.ToNullable(hasError), Optional.ToList(policyViolations), rawData);
        }

        DevTestLabPolicySetResult IModelJsonSerializable<DevTestLabPolicySetResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabPolicySetResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DevTestLabPolicySetResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DevTestLabPolicySetResult IModelSerializable<DevTestLabPolicySetResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDevTestLabPolicySetResult(doc.RootElement, options);
        }

        public static implicit operator RequestContent(DevTestLabPolicySetResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator DevTestLabPolicySetResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDevTestLabPolicySetResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
