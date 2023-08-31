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
    public partial class IaasVmIlrRegistrationContent : IUtf8JsonSerializable, IModelJsonSerializable<IaasVmIlrRegistrationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IaasVmIlrRegistrationContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IaasVmIlrRegistrationContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<IaasVmIlrRegistrationContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(RecoveryPointId))
            {
                writer.WritePropertyName("recoveryPointId"u8);
                writer.WriteStringValue(RecoveryPointId);
            }
            if (Optional.IsDefined(VirtualMachineId))
            {
                writer.WritePropertyName("virtualMachineId"u8);
                writer.WriteStringValue(VirtualMachineId);
            }
            if (Optional.IsDefined(InitiatorName))
            {
                writer.WritePropertyName("initiatorName"u8);
                writer.WriteStringValue(InitiatorName);
            }
            if (Optional.IsDefined(RenewExistingRegistration))
            {
                writer.WritePropertyName("renewExistingRegistration"u8);
                writer.WriteBooleanValue(RenewExistingRegistration.Value);
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        internal static IaasVmIlrRegistrationContent DeserializeIaasVmIlrRegistrationContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> recoveryPointId = default;
            Optional<ResourceIdentifier> virtualMachineId = default;
            Optional<string> initiatorName = default;
            Optional<bool> renewExistingRegistration = default;
            string objectType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointId"u8))
                {
                    recoveryPointId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("virtualMachineId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("initiatorName"u8))
                {
                    initiatorName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("renewExistingRegistration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    renewExistingRegistration = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IaasVmIlrRegistrationContent(objectType, recoveryPointId.Value, virtualMachineId.Value, initiatorName.Value, Optional.ToNullable(renewExistingRegistration), rawData);
        }

        IaasVmIlrRegistrationContent IModelJsonSerializable<IaasVmIlrRegistrationContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<IaasVmIlrRegistrationContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIaasVmIlrRegistrationContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IaasVmIlrRegistrationContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<IaasVmIlrRegistrationContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IaasVmIlrRegistrationContent IModelSerializable<IaasVmIlrRegistrationContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<IaasVmIlrRegistrationContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIaasVmIlrRegistrationContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IaasVmIlrRegistrationContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IaasVmIlrRegistrationContent"/> to convert. </param>
        public static implicit operator RequestContent(IaasVmIlrRegistrationContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IaasVmIlrRegistrationContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IaasVmIlrRegistrationContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIaasVmIlrRegistrationContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
