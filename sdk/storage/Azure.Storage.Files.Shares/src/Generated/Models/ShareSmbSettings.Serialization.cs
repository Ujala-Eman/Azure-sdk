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
    public partial class ShareSmbSettings : IXmlSerializable, IModel<ShareSmbSettings>
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "SMB");
            if (Optional.IsDefined(Multichannel))
            {
                writer.WriteObjectValue(Multichannel, "Multichannel");
            }
            writer.WriteEndElement();
        }

        internal static ShareSmbSettings DeserializeShareSmbSettings(XElement element, ModelReaderWriterOptions options = null)
        {
            SmbMultichannel multichannel = default;
            if (element.Element("Multichannel") is XElement multichannelElement)
            {
                multichannel = SmbMultichannel.DeserializeSmbMultichannel(multichannelElement);
            }
            return new ShareSmbSettings(multichannel, default);
        }

        BinaryData IModel<ShareSmbSettings>.Write(ModelReaderWriterOptions options)
        {
            bool implementsJson = this is IJsonModel<ShareSmbSettings>;
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

        ShareSmbSettings IModel<ShareSmbSettings>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ShareSmbSettings)} does not support '{options.Format}' format.");
            }

            return DeserializeShareSmbSettings(XElement.Load(data.ToStream()), options);
        }

        ModelReaderWriterFormat IModel<ShareSmbSettings>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Xml;
    }
}
