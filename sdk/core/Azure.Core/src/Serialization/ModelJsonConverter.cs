﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Azure.Core.Serialization
{
    /// <summary>
    /// A generic converter which allows <see cref="JsonSerializer"/> to be able to serialize and deserialize any models that implement <see cref="IModelJsonSerializable{T}"/>.
    /// </summary>
#pragma warning disable AZC0014 // Avoid using banned types in public API
    public class ModelJsonConverter : JsonConverter<IModelJsonSerializable<object>>
#pragma warning restore AZC0014 // Avoid using banned types in public API
    {
        /// <summary>
        /// Gets the <see cref="ModelSerializerOptions"/> used to serialize and deserialize models.
        /// </summary>
        public ModelSerializerOptions ModelSerializerOptions { get; }

        /// <summary>
        /// Initializes a new instance of <see cref="ModelJsonConverter"/> with a default format of <see cref="ModelSerializerFormat.Json"/>.
        /// </summary>
        [RequiresUnreferencedCode("The constructors of the type being deserialized are dynamically accessed and may be trimmed.")]
        public ModelJsonConverter()
            : this(ModelSerializerFormat.Json) { }

        /// <summary>
        /// Initializes a new instance of <see cref="ModelJsonConverter"/>.
        /// </summary>
        /// <param name="format"> The format to serialize to and deserialize from. </param>
        [RequiresUnreferencedCode("The constructors of the type being deserialized are dynamically accessed and may be trimmed.")]
        public ModelJsonConverter(ModelSerializerFormat format)
            : this(ModelSerializerOptions.GetOptions(format)) { }

        /// <summary>
        /// Initializes a new instance of <see cref="ModelJsonConverter"/>.
        /// </summary>
        /// <param name="options">The <see cref="ModelSerializerOptions"/> to use.</param>
        [RequiresUnreferencedCode("The constructors of the type being deserialized are dynamically accessed and may be trimmed.")]
        public ModelJsonConverter(ModelSerializerOptions options)
        {
            ModelSerializerOptions = options;
        }

        /// <inheritdoc/>
        public override bool CanConvert(Type typeToConvert)
        {
            return !Attribute.IsDefined(typeToConvert, typeof(JsonConverterAttribute));
        }

        /// <inheritdoc/>
#pragma warning disable AZC0014 // Avoid using banned types in public API
        public override IModelJsonSerializable<object> Read(ref Utf8JsonReader reader, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors | DynamicallyAccessedMemberTypes.NonPublicConstructors)] Type typeToConvert, JsonSerializerOptions options)
#pragma warning restore AZC0014 // Avoid using banned types in public API
        {
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return (IModelJsonSerializable<object>)ModelSerializer.Deserialize(BinaryData.FromString(document.RootElement.GetRawText()), typeToConvert, ModelSerializerOptions);
        }

        /// <inheritdoc/>
#pragma warning disable AZC0014 // Avoid using banned types in public API
        public override void Write(Utf8JsonWriter writer, IModelJsonSerializable<object> value, JsonSerializerOptions options)
#pragma warning restore AZC0014 // Avoid using banned types in public API
        {
            value.Serialize(writer, ModelSerializerOptions);
        }
    }
}
