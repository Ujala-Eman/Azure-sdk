﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.ClientModel.Internal;
using System.Text.Json;

namespace Azure.Core.Tests.ModelReaderWriterTests.Models
{
    internal class UnknownBaseModel : BaseModel, IUtf8JsonSerializable, IJsonModel<BaseModel>
    {
        public UnknownBaseModel()
            : base(null)
        {
            Kind = "Unknown";
        }

        internal UnknownBaseModel(string kind, string name, Dictionary<string, BinaryData> rawData)
            : base(rawData)
        {
            Kind = kind;
            Name = name;
        }

        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => Serialize(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<BaseModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            Serialize(writer, options);
        }

        private void Serialize(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == "J")
            {
                SerializeRawData(writer);
            }
            writer.WriteEndObject();
        }

        internal static BaseModel DeserializeUnknownBaseModel(JsonElement element, ModelReaderWriterOptions options = default) => DeserializeBaseModel(element, options);

        BaseModel IModel<BaseModel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            return DeserializeUnknownBaseModel(JsonDocument.Parse(data.ToString()).RootElement, options);
        }

        BaseModel IJsonModel<BaseModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownBaseModel(doc.RootElement, options);
        }

        BinaryData IModel<BaseModel>.Write(ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            return ModelReaderWriter.Write(this, options);
        }
    }
}
