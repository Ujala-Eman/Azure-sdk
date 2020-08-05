// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SplitSkill : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultLanguageCode))
            {
                writer.WritePropertyName("defaultLanguageCode");
                writer.WriteStringValue(DefaultLanguageCode.Value.ToString());
            }
            if (Optional.IsDefined(TextSplitMode))
            {
                writer.WritePropertyName("textSplitMode");
                writer.WriteStringValue(TextSplitMode.Value.ToString());
            }
            if (Optional.IsDefined(MaximumPageLength))
            {
                if (MaximumPageLength != null)
                {
                    writer.WritePropertyName("maximumPageLength");
                    writer.WriteNumberValue(MaximumPageLength.Value);
                }
                else
                {
                    writer.WriteNull("maximumPageLength");
                }
            }
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(ODataType);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Context))
            {
                writer.WritePropertyName("context");
                writer.WriteStringValue(Context);
            }
            writer.WritePropertyName("inputs");
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("outputs");
            writer.WriteStartArray();
            foreach (var item in Outputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static SplitSkill DeserializeSplitSkill(JsonElement element)
        {
            Optional<SplitSkillLanguage> defaultLanguageCode = default;
            Optional<TextSplitMode> textSplitMode = default;
            Optional<int?> maximumPageLength = default;
            string odataType = default;
            Optional<string> name = default;
            Optional<string> description = default;
            Optional<string> context = default;
            IList<InputFieldMappingEntry> inputs = default;
            IList<OutputFieldMappingEntry> outputs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultLanguageCode"))
                {
                    defaultLanguageCode = new SplitSkillLanguage(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("textSplitMode"))
                {
                    textSplitMode = new TextSplitMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maximumPageLength"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        maximumPageLength = null;
                        continue;
                    }
                    maximumPageLength = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("context"))
                {
                    context = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"))
                {
                    List<InputFieldMappingEntry> array = new List<InputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InputFieldMappingEntry.DeserializeInputFieldMappingEntry(item));
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("outputs"))
                {
                    List<OutputFieldMappingEntry> array = new List<OutputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OutputFieldMappingEntry.DeserializeOutputFieldMappingEntry(item));
                    }
                    outputs = array;
                    continue;
                }
            }
            return new SplitSkill(odataType, name.Value, description.Value, context.Value, inputs, outputs, Optional.ToNullable(defaultLanguageCode), Optional.ToNullable(textSplitMode), Optional.ToNullable(maximumPageLength));
        }
    }
}
