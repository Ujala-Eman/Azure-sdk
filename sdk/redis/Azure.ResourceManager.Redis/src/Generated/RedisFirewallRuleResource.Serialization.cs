// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Redis
{
    public partial class RedisFirewallRuleResource : IJsonModel<RedisFirewallRuleData>
    {
        void IJsonModel<RedisFirewallRuleData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        RedisFirewallRuleData IJsonModel<RedisFirewallRuleData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<RedisFirewallRuleData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<RedisFirewallRuleData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        RedisFirewallRuleData IPersistableModel<RedisFirewallRuleData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<RedisFirewallRuleData>(data, options);
        }

        string IPersistableModel<RedisFirewallRuleData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
