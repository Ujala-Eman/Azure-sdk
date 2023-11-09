// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    internal partial class BlobName : IXmlSerializable, IModel<BlobName>
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "BlobName");
            if (Optional.IsDefined(Encoded))
            {
                writer.WriteStartAttribute("Encoded");
                writer.WriteValue(Encoded.Value);
                writer.WriteEndAttribute();
            }
            writer.WriteValue(Content);
            writer.WriteEndElement();
        }

        internal static BlobName DeserializeBlobName(XElement element, ModelReaderWriterOptions options = null)
        {
            bool? encoded = default;
            string content = default;
            if (element.Attribute("Encoded") is XAttribute encodedAttribute)
            {
                encoded = (bool?)encodedAttribute;
            }
            content = (string)element;
            return new BlobName(encoded, content, default);
        }

        BinaryData IModel<BlobName>.Write(ModelReaderWriterOptions options)
        {
            bool implementsJson = this is IJsonModel<BlobName>;
            bool isValid = options.Format == ModelReaderWriterFormat.Json && implementsJson || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {GetType().Name} does not support '{options.Format}' format.");
            }

            using MemoryStream stream = new MemoryStream();
            using XmlWriter writer = XmlWriter.Create(stream);
            ((IXmlSerializable)this).Write(writer, null);
            writer.Flush();
            if (stream.Position > int.MaxValue)
            {
                return BinaryData.FromStream(stream);
            }
            else
            {
                return new BinaryData(stream.GetBuffer().AsMemory(0, (int)stream.Position));
            }
        }

        BlobName IModel<BlobName>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BlobName)} does not support '{options.Format}' format.");
            }

            return DeserializeBlobName(XElement.Load(data.ToStream()), options);
        }

        ModelReaderWriterFormat IModel<BlobName>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Xml;
    }
}
