// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class MachineLearningUriFileJobOutput : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AssetName))
            {
                if (AssetName != null)
                {
                    writer.WritePropertyName("assetName"u8);
                    writer.WriteStringValue(AssetName);
                }
                else
                {
                    writer.WriteNull("assetName");
                }
            }
            if (Optional.IsDefined(AssetVersion))
            {
                if (AssetVersion != null)
                {
                    writer.WritePropertyName("assetVersion"u8);
                    writer.WriteStringValue(AssetVersion);
                }
                else
                {
                    writer.WriteNull("assetVersion");
                }
            }
            if (Optional.IsDefined(AutoDeleteSetting))
            {
                if (AutoDeleteSetting != null)
                {
                    writer.WritePropertyName("autoDeleteSetting"u8);
                    writer.WriteObjectValue(AutoDeleteSetting);
                }
                else
                {
                    writer.WriteNull("autoDeleteSetting");
                }
            }
            if (Optional.IsDefined(Mode))
            {
                writer.WritePropertyName("mode"u8);
                writer.WriteStringValue(Mode.Value.ToString());
            }
            if (Optional.IsDefined(Uri))
            {
                if (Uri != null)
                {
                    writer.WritePropertyName("uri"u8);
                    writer.WriteStringValue(Uri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("uri");
                }
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            writer.WritePropertyName("jobOutputType"u8);
            writer.WriteStringValue(JobOutputType.ToString());
            writer.WriteEndObject();
        }

        internal static MachineLearningUriFileJobOutput DeserializeMachineLearningUriFileJobOutput(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> assetName = default;
            Optional<string> assetVersion = default;
            Optional<AutoDeleteSetting> autoDeleteSetting = default;
            Optional<MachineLearningOutputDeliveryMode> mode = default;
            Optional<Uri> uri = default;
            Optional<string> description = default;
            JobOutputType jobOutputType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assetName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        assetName = null;
                        continue;
                    }
                    assetName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assetVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        assetVersion = null;
                        continue;
                    }
                    assetVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("autoDeleteSetting"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        autoDeleteSetting = null;
                        continue;
                    }
                    autoDeleteSetting = AutoDeleteSetting.DeserializeAutoDeleteSetting(property.Value);
                    continue;
                }
                if (property.NameEquals("mode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mode = new MachineLearningOutputDeliveryMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("uri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        uri = null;
                        continue;
                    }
                    uri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobOutputType"u8))
                {
                    jobOutputType = new JobOutputType(property.Value.GetString());
                    continue;
                }
            }
            return new MachineLearningUriFileJobOutput(description.Value, jobOutputType, assetName.Value, assetVersion.Value, autoDeleteSetting.Value, Optional.ToNullable(mode), uri.Value);
        }
    }
}
