// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningDatastoreSecrets : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("secretsType"u8);
            writer.WriteStringValue(SecretsType.ToString());
            writer.WriteEndObject();
        }

        internal static MachineLearningDatastoreSecrets DeserializeMachineLearningDatastoreSecrets(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("secretsType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Certificate": return MachineLearningCertificateDatastoreSecrets.DeserializeMachineLearningCertificateDatastoreSecrets(element);
                    case "KerberosKeytab": return KerberosKeytabSecrets.DeserializeKerberosKeytabSecrets(element);
                    case "KerberosPassword": return KerberosPasswordSecrets.DeserializeKerberosPasswordSecrets(element);
                    case "Sas": return MachineLearningSasDatastoreSecrets.DeserializeMachineLearningSasDatastoreSecrets(element);
                    case "ServicePrincipal": return MachineLearningServicePrincipalDatastoreSecrets.DeserializeMachineLearningServicePrincipalDatastoreSecrets(element);
                    case "AccountKey": return MachineLearningAccountKeyDatastoreSecrets.DeserializeMachineLearningAccountKeyDatastoreSecrets(element);
                }
            }
            return UnknownDatastoreSecrets.DeserializeUnknownDatastoreSecrets(element);
        }
    }
}
