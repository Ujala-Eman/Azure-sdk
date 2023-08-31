// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Communication.CallAutomation
{
    internal partial class StartDialogRequestInternal : IUtf8JsonSerializable, IModelJsonSerializable<StartDialogRequestInternal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<StartDialogRequestInternal>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<StartDialogRequestInternal>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("dialogOptions"u8);
            writer.WriteObjectValue(DialogOptions);
            writer.WritePropertyName("dialogInputType"u8);
            writer.WriteStringValue(DialogInputType.ToString());
            if (Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext"u8);
                writer.WriteStringValue(OperationContext);
            }
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static StartDialogRequestInternal DeserializeStartDialogRequestInternal(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DialogOptionsInternal dialogOptions = default;
            DialogInputType dialogInputType = default;
            Optional<string> operationContext = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dialogOptions"u8))
                {
                    dialogOptions = DialogOptionsInternal.DeserializeDialogOptionsInternal(property.Value);
                    continue;
                }
                if (property.NameEquals("dialogInputType"u8))
                {
                    dialogInputType = new DialogInputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operationContext"u8))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new StartDialogRequestInternal(dialogOptions, dialogInputType, operationContext.Value, rawData);
        }

        StartDialogRequestInternal IModelJsonSerializable<StartDialogRequestInternal>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeStartDialogRequestInternal(doc.RootElement, options);
        }

        BinaryData IModelSerializable<StartDialogRequestInternal>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        StartDialogRequestInternal IModelSerializable<StartDialogRequestInternal>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeStartDialogRequestInternal(doc.RootElement, options);
        }

        public static implicit operator RequestContent(StartDialogRequestInternal model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator StartDialogRequestInternal(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeStartDialogRequestInternal(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
