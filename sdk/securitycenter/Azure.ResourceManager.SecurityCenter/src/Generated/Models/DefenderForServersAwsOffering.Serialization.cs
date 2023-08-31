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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class DefenderForServersAwsOffering : IUtf8JsonSerializable, IModelJsonSerializable<DefenderForServersAwsOffering>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DefenderForServersAwsOffering>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DefenderForServersAwsOffering>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DefenderForServersAwsOffering>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DefenderForServers))
            {
                writer.WritePropertyName("defenderForServers"u8);
                if (DefenderForServers is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<AwsDefenderForServersInfo>)DefenderForServers).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ArcAutoProvisioning))
            {
                writer.WritePropertyName("arcAutoProvisioning"u8);
                if (ArcAutoProvisioning is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DefenderForServersAwsOfferingArcAutoProvisioning>)ArcAutoProvisioning).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(VaAutoProvisioning))
            {
                writer.WritePropertyName("vaAutoProvisioning"u8);
                if (VaAutoProvisioning is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DefenderForServersAwsOfferingVulnerabilityAssessmentAutoProvisioning>)VaAutoProvisioning).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(MdeAutoProvisioning))
            {
                writer.WritePropertyName("mdeAutoProvisioning"u8);
                if (MdeAutoProvisioning is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DefenderForServersAwsOfferingMdeAutoProvisioning>)MdeAutoProvisioning).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(SubPlan))
            {
                writer.WritePropertyName("subPlan"u8);
                if (SubPlan is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DefenderForServersAwsOfferingSubPlan>)SubPlan).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(VmScanners))
            {
                writer.WritePropertyName("vmScanners"u8);
                if (VmScanners is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<DefenderForServersAwsOfferingVmScanners>)VmScanners).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("offeringType"u8);
            writer.WriteStringValue(OfferingType.ToString());
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

        internal static DefenderForServersAwsOffering DeserializeDefenderForServersAwsOffering(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AwsDefenderForServersInfo> defenderForServers = default;
            Optional<DefenderForServersAwsOfferingArcAutoProvisioning> arcAutoProvisioning = default;
            Optional<DefenderForServersAwsOfferingVulnerabilityAssessmentAutoProvisioning> vaAutoProvisioning = default;
            Optional<DefenderForServersAwsOfferingMdeAutoProvisioning> mdeAutoProvisioning = default;
            Optional<DefenderForServersAwsOfferingSubPlan> subPlan = default;
            Optional<DefenderForServersAwsOfferingVmScanners> vmScanners = default;
            OfferingType offeringType = default;
            Optional<string> description = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defenderForServers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    defenderForServers = AwsDefenderForServersInfo.DeserializeAwsDefenderForServersInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("arcAutoProvisioning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    arcAutoProvisioning = DefenderForServersAwsOfferingArcAutoProvisioning.DeserializeDefenderForServersAwsOfferingArcAutoProvisioning(property.Value);
                    continue;
                }
                if (property.NameEquals("vaAutoProvisioning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vaAutoProvisioning = DefenderForServersAwsOfferingVulnerabilityAssessmentAutoProvisioning.DeserializeDefenderForServersAwsOfferingVulnerabilityAssessmentAutoProvisioning(property.Value);
                    continue;
                }
                if (property.NameEquals("mdeAutoProvisioning"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mdeAutoProvisioning = DefenderForServersAwsOfferingMdeAutoProvisioning.DeserializeDefenderForServersAwsOfferingMdeAutoProvisioning(property.Value);
                    continue;
                }
                if (property.NameEquals("subPlan"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subPlan = DefenderForServersAwsOfferingSubPlan.DeserializeDefenderForServersAwsOfferingSubPlan(property.Value);
                    continue;
                }
                if (property.NameEquals("vmScanners"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    vmScanners = DefenderForServersAwsOfferingVmScanners.DeserializeDefenderForServersAwsOfferingVmScanners(property.Value);
                    continue;
                }
                if (property.NameEquals("offeringType"u8))
                {
                    offeringType = new OfferingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DefenderForServersAwsOffering(offeringType, description.Value, defenderForServers.Value, arcAutoProvisioning.Value, vaAutoProvisioning.Value, mdeAutoProvisioning.Value, subPlan.Value, vmScanners.Value, rawData);
        }

        DefenderForServersAwsOffering IModelJsonSerializable<DefenderForServersAwsOffering>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DefenderForServersAwsOffering>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderForServersAwsOffering(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DefenderForServersAwsOffering>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DefenderForServersAwsOffering>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DefenderForServersAwsOffering IModelSerializable<DefenderForServersAwsOffering>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<DefenderForServersAwsOffering>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDefenderForServersAwsOffering(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DefenderForServersAwsOffering"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DefenderForServersAwsOffering"/> to convert. </param>
        public static implicit operator RequestContent(DefenderForServersAwsOffering model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DefenderForServersAwsOffering"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DefenderForServersAwsOffering(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDefenderForServersAwsOffering(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
