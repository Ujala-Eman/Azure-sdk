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

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class WindowsServerFailoverClusterDomainCredentials : IUtf8JsonSerializable, IModelJsonSerializable<WindowsServerFailoverClusterDomainCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<WindowsServerFailoverClusterDomainCredentials>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<WindowsServerFailoverClusterDomainCredentials>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ClusterBootstrapAccountPassword))
            {
                writer.WritePropertyName("clusterBootstrapAccountPassword"u8);
                writer.WriteStringValue(ClusterBootstrapAccountPassword);
            }
            if (Optional.IsDefined(ClusterOperatorAccountPassword))
            {
                writer.WritePropertyName("clusterOperatorAccountPassword"u8);
                writer.WriteStringValue(ClusterOperatorAccountPassword);
            }
            if (Optional.IsDefined(SqlServiceAccountPassword))
            {
                writer.WritePropertyName("sqlServiceAccountPassword"u8);
                writer.WriteStringValue(SqlServiceAccountPassword);
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

        internal static WindowsServerFailoverClusterDomainCredentials DeserializeWindowsServerFailoverClusterDomainCredentials(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> clusterBootstrapAccountPassword = default;
            Optional<string> clusterOperatorAccountPassword = default;
            Optional<string> sqlServiceAccountPassword = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("clusterBootstrapAccountPassword"u8))
                {
                    clusterBootstrapAccountPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clusterOperatorAccountPassword"u8))
                {
                    clusterOperatorAccountPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sqlServiceAccountPassword"u8))
                {
                    sqlServiceAccountPassword = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new WindowsServerFailoverClusterDomainCredentials(clusterBootstrapAccountPassword.Value, clusterOperatorAccountPassword.Value, sqlServiceAccountPassword.Value, rawData);
        }

        WindowsServerFailoverClusterDomainCredentials IModelJsonSerializable<WindowsServerFailoverClusterDomainCredentials>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeWindowsServerFailoverClusterDomainCredentials(doc.RootElement, options);
        }

        BinaryData IModelSerializable<WindowsServerFailoverClusterDomainCredentials>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        WindowsServerFailoverClusterDomainCredentials IModelSerializable<WindowsServerFailoverClusterDomainCredentials>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeWindowsServerFailoverClusterDomainCredentials(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="WindowsServerFailoverClusterDomainCredentials"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="WindowsServerFailoverClusterDomainCredentials"/> to convert. </param>
        public static implicit operator RequestContent(WindowsServerFailoverClusterDomainCredentials model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="WindowsServerFailoverClusterDomainCredentials"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator WindowsServerFailoverClusterDomainCredentials(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeWindowsServerFailoverClusterDomainCredentials(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
