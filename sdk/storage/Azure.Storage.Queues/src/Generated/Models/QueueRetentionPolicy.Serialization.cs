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

namespace Azure.Storage.Queues.Models
{
    public partial class QueueRetentionPolicy : IXmlSerializable, IModel<QueueRetentionPolicy>
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
            writer.WriteEndElement();
        }

        internal static QueueRetentionPolicy DeserializeQueueRetentionPolicy(XElement element, ModelReaderWriterOptions options = null)
        {
            bool enabled = default;
            int? days = default;
            if (element.Element("Enabled") is XElement enabledElement)
            {
                enabled = (bool)enabledElement;
            }
            if (element.Element("Days") is XElement daysElement)
            {
                days = (int?)daysElement;
            }
            return new QueueRetentionPolicy(enabled, days, default);
        }

        BinaryData IModel<QueueRetentionPolicy>.Write(ModelReaderWriterOptions options)
        {
            bool implementsJson = this is IJsonModel<QueueRetentionPolicy>;
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

        QueueRetentionPolicy IModel<QueueRetentionPolicy>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(QueueRetentionPolicy)} does not support '{options.Format}' format.");
            }

            return DeserializeQueueRetentionPolicy(XElement.Load(data.ToStream()), options);
        }

        ModelReaderWriterFormat IModel<QueueRetentionPolicy>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Xml;
    }
}
