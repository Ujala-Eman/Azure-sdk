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
    public partial class BlobStaticWebsite : IXmlSerializable, IModel<BlobStaticWebsite>
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "StaticWebsite");
            writer.WriteStartElement("Enabled");
            writer.WriteValue(Enabled);
            writer.WriteEndElement();
            if (Optional.IsDefined(IndexDocument))
            {
                writer.WriteStartElement("IndexDocument");
                writer.WriteValue(IndexDocument);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(ErrorDocument404Path))
            {
                writer.WriteStartElement("ErrorDocument404Path");
                writer.WriteValue(ErrorDocument404Path);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(DefaultIndexDocumentPath))
            {
                writer.WriteStartElement("DefaultIndexDocumentPath");
                writer.WriteValue(DefaultIndexDocumentPath);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        internal static BlobStaticWebsite DeserializeBlobStaticWebsite(XElement element, ModelReaderWriterOptions options = null)
        {
            bool enabled = default;
            string indexDocument = default;
            string errorDocument404Path = default;
            string defaultIndexDocumentPath = default;
            if (element.Element("Enabled") is XElement enabledElement)
            {
                enabled = (bool)enabledElement;
            }
            if (element.Element("IndexDocument") is XElement indexDocumentElement)
            {
                indexDocument = (string)indexDocumentElement;
            }
            if (element.Element("ErrorDocument404Path") is XElement errorDocument404PathElement)
            {
                errorDocument404Path = (string)errorDocument404PathElement;
            }
            if (element.Element("DefaultIndexDocumentPath") is XElement defaultIndexDocumentPathElement)
            {
                defaultIndexDocumentPath = (string)defaultIndexDocumentPathElement;
            }
            return new BlobStaticWebsite(enabled, indexDocument, errorDocument404Path, defaultIndexDocumentPath, default);
        }

        BinaryData IModel<BlobStaticWebsite>.Write(ModelReaderWriterOptions options)
        {
            bool implementsJson = this is IJsonModel<BlobStaticWebsite>;
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

        BlobStaticWebsite IModel<BlobStaticWebsite>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BlobStaticWebsite)} does not support '{options.Format}' format.");
            }

            return DeserializeBlobStaticWebsite(XElement.Load(data.ToStream()), options);
        }

        ModelReaderWriterFormat IModel<BlobStaticWebsite>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Xml;
    }
}
