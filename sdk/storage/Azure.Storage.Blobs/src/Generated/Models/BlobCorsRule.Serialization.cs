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
    public partial class BlobCorsRule : IXmlSerializable, IModel<BlobCorsRule>
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "CorsRule");
            writer.WriteStartElement("AllowedOrigins");
            writer.WriteValue(AllowedOrigins);
            writer.WriteEndElement();
            writer.WriteStartElement("AllowedMethods");
            writer.WriteValue(AllowedMethods);
            writer.WriteEndElement();
            writer.WriteStartElement("AllowedHeaders");
            writer.WriteValue(AllowedHeaders);
            writer.WriteEndElement();
            writer.WriteStartElement("ExposedHeaders");
            writer.WriteValue(ExposedHeaders);
            writer.WriteEndElement();
            writer.WriteStartElement("MaxAgeInSeconds");
            writer.WriteValue(MaxAgeInSeconds);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        internal static BlobCorsRule DeserializeBlobCorsRule(XElement element, ModelReaderWriterOptions options = null)
        {
            string allowedOrigins = default;
            string allowedMethods = default;
            string allowedHeaders = default;
            string exposedHeaders = default;
            int maxAgeInSeconds = default;
            if (element.Element("AllowedOrigins") is XElement allowedOriginsElement)
            {
                allowedOrigins = (string)allowedOriginsElement;
            }
            if (element.Element("AllowedMethods") is XElement allowedMethodsElement)
            {
                allowedMethods = (string)allowedMethodsElement;
            }
            if (element.Element("AllowedHeaders") is XElement allowedHeadersElement)
            {
                allowedHeaders = (string)allowedHeadersElement;
            }
            if (element.Element("ExposedHeaders") is XElement exposedHeadersElement)
            {
                exposedHeaders = (string)exposedHeadersElement;
            }
            if (element.Element("MaxAgeInSeconds") is XElement maxAgeInSecondsElement)
            {
                maxAgeInSeconds = (int)maxAgeInSecondsElement;
            }
            return new BlobCorsRule(allowedOrigins, allowedMethods, allowedHeaders, exposedHeaders, maxAgeInSeconds, default);
        }

        BinaryData IModel<BlobCorsRule>.Write(ModelReaderWriterOptions options)
        {
            bool implementsJson = this is IJsonModel<BlobCorsRule>;
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

        BlobCorsRule IModel<BlobCorsRule>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BlobCorsRule)} does not support '{options.Format}' format.");
            }

            return DeserializeBlobCorsRule(XElement.Load(data.ToStream()), options);
        }

        ModelReaderWriterFormat IModel<BlobCorsRule>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Xml;
    }
}
