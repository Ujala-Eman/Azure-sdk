// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class StorageAccountUpdateParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteObjectValue(Sku);
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind.Value.ToString());
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(CustomDomain))
            {
                writer.WritePropertyName("customDomain");
                writer.WriteObjectValue(CustomDomain);
            }
            if (Optional.IsDefined(Encryption))
            {
                writer.WritePropertyName("encryption");
                writer.WriteObjectValue(Encryption);
            }
            if (Optional.IsDefined(AccessTier))
            {
                writer.WritePropertyName("accessTier");
                writer.WriteStringValue(AccessTier.Value.ToSerialString());
            }
            if (Optional.IsDefined(AzureFilesIdentityBasedAuthentication))
            {
                writer.WritePropertyName("azureFilesIdentityBasedAuthentication");
                writer.WriteObjectValue(AzureFilesIdentityBasedAuthentication);
            }
            if (Optional.IsDefined(EnableHttpsTrafficOnly))
            {
                writer.WritePropertyName("supportsHttpsTrafficOnly");
                writer.WriteBooleanValue(EnableHttpsTrafficOnly.Value);
            }
            if (Optional.IsDefined(NetworkRuleSet))
            {
                writer.WritePropertyName("networkAcls");
                writer.WriteObjectValue(NetworkRuleSet);
            }
            if (Optional.IsDefined(LargeFileSharesState))
            {
                writer.WritePropertyName("largeFileSharesState");
                writer.WriteStringValue(LargeFileSharesState.Value.ToString());
            }
            if (Optional.IsDefined(RoutingPreference))
            {
                writer.WritePropertyName("routingPreference");
                writer.WriteObjectValue(RoutingPreference);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
