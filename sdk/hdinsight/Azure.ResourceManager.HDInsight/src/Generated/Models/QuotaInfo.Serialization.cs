// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    internal partial class QuotaInfo
    {
        internal static QuotaInfo DeserializeQuotaInfo(JsonElement element)
        {
            Optional<int> coresUsed = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("coresUsed"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    coresUsed = property.Value.GetInt32();
                    continue;
                }
            }
            return new QuotaInfo(Optional.ToNullable(coresUsed));
        }
    }
}
