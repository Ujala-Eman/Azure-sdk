// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    internal partial class CustomLabelClassificationResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("documents");
            writer.WriteStartArray();
            foreach (var item in Documents)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("errors");
            writer.WriteStartArray();
            foreach (var item in Errors)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Statistics))
            {
                writer.WritePropertyName("statistics");
                writer.WriteObjectValue(Statistics);
            }
            writer.WritePropertyName("projectName");
            writer.WriteStringValue(ProjectName);
            writer.WritePropertyName("deploymentName");
            writer.WriteStringValue(DeploymentName);
            writer.WriteEndObject();
        }

        internal static CustomLabelClassificationResult DeserializeCustomLabelClassificationResult(JsonElement element)
        {
            IList<CustomLabelClassificationResultDocumentsItem> documents = default;
            IList<DocumentError> errors = default;
            Optional<TextDocumentBatchStatistics> statistics = default;
            string projectName = default;
            string deploymentName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("documents"))
                {
                    List<CustomLabelClassificationResultDocumentsItem> array = new List<CustomLabelClassificationResultDocumentsItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomLabelClassificationResultDocumentsItem.DeserializeCustomLabelClassificationResultDocumentsItem(item));
                    }
                    documents = array;
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    List<DocumentError> array = new List<DocumentError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DocumentError.DeserializeDocumentError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("statistics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    statistics = TextDocumentBatchStatistics.DeserializeTextDocumentBatchStatistics(property.Value);
                    continue;
                }
                if (property.NameEquals("projectName"))
                {
                    projectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deploymentName"))
                {
                    deploymentName = property.Value.GetString();
                    continue;
                }
            }
            return new CustomLabelClassificationResult(errors, statistics.Value, projectName, deploymentName, documents);
        }
    }
}
