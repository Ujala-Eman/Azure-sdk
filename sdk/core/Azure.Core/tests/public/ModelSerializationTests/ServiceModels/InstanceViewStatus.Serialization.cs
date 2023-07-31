// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Reflection.Emit;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Core.Tests.Public.ResourceManager.Compute.Models
{
    public partial class InstanceViewStatus : IUtf8JsonSerializable, IModelJsonSerializable<InstanceViewStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<InstanceViewStatus>)this).Serialize(writer, ModelSerializerOptions.DefaultServiceOptions);

        void IModelJsonSerializable<InstanceViewStatus>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options) => Serialize(writer, options);

        private void Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Code))
            {
                writer.WritePropertyName("code"u8);
                writer.WriteStringValue(Code);
            }
            if (Optional.IsDefined(Level))
            {
                writer.WritePropertyName("level"u8);
                writer.WriteStringValue(Level.Value.ToSerialString());
            }
            if (Optional.IsDefined(DisplayStatus))
            {
                writer.WritePropertyName("displayStatus"u8);
                writer.WriteStringValue(DisplayStatus);
            }
            if (Optional.IsDefined(Message))
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (Optional.IsDefined(Time))
            {
                writer.WritePropertyName("time"u8);
                writer.WriteStringValue(Time.Value, "O");
            }
            writer.WriteEndObject();
        }

        internal static InstanceViewStatus DeserializeInstanceViewStatus(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultServiceOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> code = default;
            Optional<ComputeStatusLevelType> level = default;
            Optional<string> displayStatus = default;
            Optional<string> message = default;
            Optional<DateTimeOffset> time = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("level"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    level = property.Value.GetString().ToComputeStatusLevelType();
                    continue;
                }
                if (property.NameEquals("displayStatus"u8))
                {
                    displayStatus = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("time"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    time = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new InstanceViewStatus(code.Value, Optional.ToNullable(level), displayStatus.Value, message.Value, Optional.ToNullable(time));
        }

        private struct InstanceViewStatusProperties
        {
            public Optional<string> Code { get; set; }
            public Optional<ComputeStatusLevelType> Level { get; set; }
            public Optional<string> DisplayStatus { get; set; }
            public Optional<string> Message { get; set; }
            public Optional<DateTimeOffset> Time { get; set; }
        }

        InstanceViewStatus IModelJsonSerializable<InstanceViewStatus>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            if (!reader.TryDeserialize<InstanceViewStatusProperties>(options, SetProperty, out var properties))
                return null;

            return new InstanceViewStatus(
                properties.Code.Value,
                Optional.ToNullable(properties.Level),
                properties.DisplayStatus.Value,
                properties.Message.Value,
                Optional.ToNullable(properties.Time));
        }

        private static void SetProperty(ReadOnlySpan<byte> propertyName, ref InstanceViewStatusProperties properties, ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            if (propertyName.SequenceEqual("code"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.Code = reader.GetString();
                return;
            }
            if (propertyName.SequenceEqual("level"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.Level = reader.GetString().ToComputeStatusLevelType();
                return;
            }
            if (propertyName.SequenceEqual("displayStatus"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.DisplayStatus = reader.GetString();
                return;
            }
            if (propertyName.SequenceEqual("message"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.Message = reader.GetString();
                return;
            }
            if (propertyName.SequenceEqual("time"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.Time = DateTimeOffset.Parse(reader.GetString(), CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal);
                return;
            }
            reader.Skip();
        }

        InstanceViewStatus IModelSerializable<InstanceViewStatus>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            using var doc = JsonDocument.Parse(data);
            return DeserializeInstanceViewStatus(doc.RootElement, options);
        }

        BinaryData IModelSerializable<InstanceViewStatus>.Serialize(ModelSerializerOptions options) => this.ToBinaryData(options);
    }
}
