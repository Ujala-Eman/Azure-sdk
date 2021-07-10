// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    public partial class SslConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(Cert))
            {
                writer.WritePropertyName("cert");
                writer.WriteStringValue(Cert);
            }
            if (Optional.IsDefined(Key))
            {
                writer.WritePropertyName("key");
                writer.WriteStringValue(Key);
            }
            if (Optional.IsDefined(Cname))
            {
                writer.WritePropertyName("cname");
                writer.WriteStringValue(Cname);
            }
            if (Optional.IsDefined(LeafDomainLabel))
            {
                writer.WritePropertyName("leafDomainLabel");
                writer.WriteStringValue(LeafDomainLabel);
            }
            if (Optional.IsDefined(OverwriteExistingDomain))
            {
                writer.WritePropertyName("overwriteExistingDomain");
                writer.WriteBooleanValue(OverwriteExistingDomain.Value);
            }
            writer.WriteEndObject();
        }

        internal static SslConfiguration DeserializeSslConfiguration(JsonElement element)
        {
            Optional<SslConfigurationStatus> status = default;
            Optional<string> cert = default;
            Optional<string> key = default;
            Optional<string> cname = default;
            Optional<string> leafDomainLabel = default;
            Optional<bool> overwriteExistingDomain = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new SslConfigurationStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cert"))
                {
                    cert = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key"))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("cname"))
                {
                    cname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("leafDomainLabel"))
                {
                    leafDomainLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("overwriteExistingDomain"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    overwriteExistingDomain = property.Value.GetBoolean();
                    continue;
                }
            }
            return new SslConfiguration(Optional.ToNullable(status), cert.Value, key.Value, cname.Value, leafDomainLabel.Value, Optional.ToNullable(overwriteExistingDomain));
        }
    }
}
