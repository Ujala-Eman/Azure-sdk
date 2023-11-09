// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    internal partial class ContainerItemInternal : IXmlSerializable, IModel<ContainerItemInternal>
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "Container");
            writer.WriteStartElement("Name");
            writer.WriteValue(Name);
            writer.WriteEndElement();
            if (Optional.IsDefined(Deleted))
            {
                writer.WriteStartElement("Deleted");
                writer.WriteValue(Deleted.Value);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(Version))
            {
                writer.WriteStartElement("Version");
                writer.WriteValue(Version);
                writer.WriteEndElement();
            }
            writer.WriteObjectValue(Properties, "Properties");
            if (Optional.IsCollectionDefined(Metadata))
            {
                foreach (var pair in Metadata)
                {
                    writer.WriteStartElement("String");
                    writer.WriteValue(pair.Value);
                    writer.WriteEndElement();
                }
            }
            writer.WriteEndElement();
        }

        internal static ContainerItemInternal DeserializeContainerItemInternal(XElement element, ModelReaderWriterOptions options = null)
        {
            string name = default;
            bool? deleted = default;
            string version = default;
            ContainerPropertiesInternal properties = default;
            IReadOnlyDictionary<string, string> metadata = default;
            if (element.Element("Name") is XElement nameElement)
            {
                name = (string)nameElement;
            }
            if (element.Element("Deleted") is XElement deletedElement)
            {
                deleted = (bool?)deletedElement;
            }
            if (element.Element("Version") is XElement versionElement)
            {
                version = (string)versionElement;
            }
            if (element.Element("Properties") is XElement propertiesElement)
            {
                properties = ContainerPropertiesInternal.DeserializeContainerPropertiesInternal(propertiesElement);
            }
            if (element.Element("Metadata") is XElement metadataElement)
            {
                var dictionary = new Dictionary<string, string>();
                foreach (var e in metadataElement.Elements())
                {
                    dictionary.Add(e.Name.LocalName, (string)e);
                }
                metadata = dictionary;
            }
            return new ContainerItemInternal(name, deleted, version, properties, metadata, default);
        }

        BinaryData IModel<ContainerItemInternal>.Write(ModelReaderWriterOptions options)
        {
            bool implementsJson = this is IJsonModel<ContainerItemInternal>;
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

        ContainerItemInternal IModel<ContainerItemInternal>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ContainerItemInternal)} does not support '{options.Format}' format.");
            }

            return DeserializeContainerItemInternal(XElement.Load(data.ToStream()), options);
        }

        ModelReaderWriterFormat IModel<ContainerItemInternal>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Xml;
    }
}
