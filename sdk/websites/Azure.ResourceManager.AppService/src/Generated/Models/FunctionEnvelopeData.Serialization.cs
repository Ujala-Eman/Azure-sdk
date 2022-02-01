// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class FunctionEnvelopeData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(FunctionAppId))
            {
                writer.WritePropertyName("function_app_id");
                writer.WriteStringValue(FunctionAppId);
            }
            if (Optional.IsDefined(ScriptRootPathHref))
            {
                writer.WritePropertyName("script_root_path_href");
                writer.WriteStringValue(ScriptRootPathHref);
            }
            if (Optional.IsDefined(ScriptHref))
            {
                writer.WritePropertyName("script_href");
                writer.WriteStringValue(ScriptHref);
            }
            if (Optional.IsDefined(ConfigHref))
            {
                writer.WritePropertyName("config_href");
                writer.WriteStringValue(ConfigHref);
            }
            if (Optional.IsDefined(TestDataHref))
            {
                writer.WritePropertyName("test_data_href");
                writer.WriteStringValue(TestDataHref);
            }
            if (Optional.IsDefined(SecretsFileHref))
            {
                writer.WritePropertyName("secrets_file_href");
                writer.WriteStringValue(SecretsFileHref);
            }
            if (Optional.IsDefined(Href))
            {
                writer.WritePropertyName("href");
                writer.WriteStringValue(Href);
            }
            if (Optional.IsDefined(Config))
            {
                writer.WritePropertyName("config");
                writer.WriteObjectValue(Config);
            }
            if (Optional.IsCollectionDefined(Files))
            {
                writer.WritePropertyName("files");
                writer.WriteStartObject();
                foreach (var item in Files)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(TestData))
            {
                writer.WritePropertyName("test_data");
                writer.WriteStringValue(TestData);
            }
            if (Optional.IsDefined(InvokeUrlTemplate))
            {
                writer.WritePropertyName("invoke_url_template");
                writer.WriteStringValue(InvokeUrlTemplate);
            }
            if (Optional.IsDefined(Language))
            {
                writer.WritePropertyName("language");
                writer.WriteStringValue(Language);
            }
            if (Optional.IsDefined(IsDisabled))
            {
                writer.WritePropertyName("isDisabled");
                writer.WriteBooleanValue(IsDisabled.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static FunctionEnvelopeData DeserializeFunctionEnvelopeData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Optional<string> functionAppId = default;
            Optional<string> scriptRootPathHref = default;
            Optional<string> scriptHref = default;
            Optional<string> configHref = default;
            Optional<string> testDataHref = default;
            Optional<string> secretsFileHref = default;
            Optional<string> href = default;
            Optional<object> config = default;
            Optional<IDictionary<string, string>> files = default;
            Optional<string> testData = default;
            Optional<string> invokeUrlTemplate = default;
            Optional<string> language = default;
            Optional<bool> isDisabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("function_app_id"))
                        {
                            functionAppId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("script_root_path_href"))
                        {
                            scriptRootPathHref = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("script_href"))
                        {
                            scriptHref = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("config_href"))
                        {
                            configHref = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("test_data_href"))
                        {
                            testDataHref = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secrets_file_href"))
                        {
                            secretsFileHref = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("href"))
                        {
                            href = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("config"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            config = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("files"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            files = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("test_data"))
                        {
                            testData = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("invoke_url_template"))
                        {
                            invokeUrlTemplate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("language"))
                        {
                            language = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isDisabled"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            isDisabled = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new FunctionEnvelopeData(id, name, type, systemData, kind.Value, functionAppId.Value, scriptRootPathHref.Value, scriptHref.Value, configHref.Value, testDataHref.Value, secretsFileHref.Value, href.Value, config.Value, Optional.ToDictionary(files), testData.Value, invokeUrlTemplate.Value, language.Value, Optional.ToNullable(isDisabled));
        }
    }
}
