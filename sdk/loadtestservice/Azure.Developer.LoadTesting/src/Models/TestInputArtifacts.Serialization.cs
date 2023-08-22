// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Json;
using Azure.Core.Serialization;

namespace Azure.Developer.LoadTesting.Models
{
    public partial class TestInputArtifacts : IUtf8JsonSerializable, IJsonModelSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            throw new NotImplementedException();
        }

        void IJsonModelSerializable.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            if (options.Format == "P")
            {
                _element.WriteTo(writer, 'P');
                return;
            }

            ((IUtf8JsonSerializable)this).Write(writer);
        }

        object IJsonModelSerializable.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            JsonDocument doc = JsonDocument.ParseValue(ref reader);
            MutableJsonDocument mdoc = new MutableJsonDocument(doc, new JsonSerializerOptions());
            return new TestInputArtifacts(mdoc.RootElement);
        }

        object IModelSerializable.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            MutableJsonDocument jsonDocument = MutableJsonDocument.Parse(data);
            return new TestInputArtifacts(jsonDocument.RootElement);
        }

        BinaryData IModelSerializable.Serialize(ModelSerializerOptions options) => ModelSerializerHelper.SerializeToBinaryData(writer => ((IJsonModelSerializable)this).Serialize(writer, options));
    }
}
