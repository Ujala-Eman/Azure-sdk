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

namespace Azure.Storage.Files.Shares.Models
{
    internal partial class ClearRange : IXmlSerializable, IModel<ClearRange>
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "ClearRange");
            writer.WriteStartElement("Start");
            writer.WriteValue(Start);
            writer.WriteEndElement();
            writer.WriteStartElement("End");
            writer.WriteValue(End);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        internal static ClearRange DeserializeClearRange(XElement element, ModelReaderWriterOptions options = null)
        {
            long start = default;
            long end = default;
            if (element.Element("Start") is XElement startElement)
            {
                start = (long)startElement;
            }
            if (element.Element("End") is XElement endElement)
            {
                end = (long)endElement;
            }
            return new ClearRange(start, end, default);
        }

        BinaryData IModel<ClearRange>.Write(ModelReaderWriterOptions options)
        {
            bool implementsJson = this is IJsonModel<ClearRange>;
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

        ClearRange IModel<ClearRange>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ClearRange)} does not support '{options.Format}' format.");
            }

            return DeserializeClearRange(XElement.Load(data.ToStream()), options);
        }

        ModelReaderWriterFormat IModel<ClearRange>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Xml;
    }
}
