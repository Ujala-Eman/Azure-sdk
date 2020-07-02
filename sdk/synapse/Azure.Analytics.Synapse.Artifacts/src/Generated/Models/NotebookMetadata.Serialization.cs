// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class NotebookMetadata : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kernelspec))
            {
                writer.WritePropertyName("kernelspec");
                writer.WriteObjectValue(Kernelspec);
            }
            if (Optional.IsDefined(LanguageInfo))
            {
                writer.WritePropertyName("language_info");
                writer.WriteObjectValue(LanguageInfo);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static NotebookMetadata DeserializeNotebookMetadata(JsonElement element)
        {
            Optional<NotebookKernelSpec> kernelspec = default;
            Optional<NotebookLanguageInfo> languageInfo = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kernelspec"))
                {
                    kernelspec = NotebookKernelSpec.DeserializeNotebookKernelSpec(property.Value);
                    continue;
                }
                if (property.NameEquals("language_info"))
                {
                    languageInfo = NotebookLanguageInfo.DeserializeNotebookLanguageInfo(property.Value);
                    continue;
                }
                additionalPropertiesDictionary ??= new Dictionary<string, object>();
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    additionalPropertiesDictionary.Add(property.Name, null);
                }
                else
                {
                    additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
                }
            }
            additionalProperties = additionalPropertiesDictionary;
            return new NotebookMetadata(kernelspec.HasValue ? kernelspec.Value : null, languageInfo.HasValue ? languageInfo.Value : null, additionalProperties);
        }
    }
}
