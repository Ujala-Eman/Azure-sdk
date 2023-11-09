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
    public partial class BlobRetentionPolicy : IXmlSerializable, IModel<BlobRetentionPolicy>
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "RetentionPolicy");
            writer.WriteStartElement("Enabled");
            writer.WriteValue(Enabled);
            writer.WriteEndElement();
            if (Optional.IsDefined(Days))
            {
                writer.WriteStartElement("Days");
                writer.WriteValue(Days.Value);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(AllowPermanentDelete))
            {
                writer.WriteStartElement("AllowPermanentDelete");
                writer.WriteValue(AllowPermanentDelete.Value);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
        }

        internal static BlobRetentionPolicy DeserializeBlobRetentionPolicy(XElement element, ModelReaderWriterOptions options = null)
        {
            bool enabled = default;
            int? days = default;
            bool? allowPermanentDelete = default;
            if (element.Element("Enabled") is XElement enabledElement)
            {
                enabled = (bool)enabledElement;
            }
            if (element.Element("Days") is XElement daysElement)
            {
                days = (int?)daysElement;
            }
            if (element.Element("AllowPermanentDelete") is XElement allowPermanentDeleteElement)
            {
                allowPermanentDelete = (bool?)allowPermanentDeleteElement;
            }
            return new BlobRetentionPolicy(enabled, days, allowPermanentDelete, default);
        }

        BinaryData IModel<BlobRetentionPolicy>.Write(ModelReaderWriterOptions options)
        {
            bool implementsJson = this is IJsonModel<BlobRetentionPolicy>;
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

        BlobRetentionPolicy IModel<BlobRetentionPolicy>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BlobRetentionPolicy)} does not support '{options.Format}' format.");
            }

            return DeserializeBlobRetentionPolicy(XElement.Load(data.ToStream()), options);
        }

        ModelReaderWriterFormat IModel<BlobRetentionPolicy>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Xml;
    }
}
