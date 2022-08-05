// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightClusterHostInfo
    {
        internal static HDInsightClusterHostInfo DeserializeHDInsightClusterHostInfo(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> fqdn = default;
            Optional<Uri> effectiveDiskEncryptionKeyUrl = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fqdn"))
                {
                    fqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("effectiveDiskEncryptionKeyUrl"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        effectiveDiskEncryptionKeyUrl = null;
                        continue;
                    }
                    effectiveDiskEncryptionKeyUrl = new Uri(property.Value.GetString());
                    continue;
                }
            }
            return new HDInsightClusterHostInfo(name.Value, fqdn.Value, effectiveDiskEncryptionKeyUrl.Value);
        }
    }
}
