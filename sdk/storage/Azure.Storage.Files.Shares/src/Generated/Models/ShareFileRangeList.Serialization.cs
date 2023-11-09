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

namespace Azure.Storage.Files.Shares.Models
{
    internal partial class ShareFileRangeList : IXmlSerializable, IModel<ShareFileRangeList>
    {
        void IXmlSerializable.Write(XmlWriter writer, string nameHint)
        {
            writer.WriteStartElement(nameHint ?? "Ranges");
            if (Optional.IsCollectionDefined(Ranges))
            {
                foreach (var item in Ranges)
                {
                    writer.WriteObjectValue(item, "Range");
                }
            }
            if (Optional.IsCollectionDefined(ClearRanges))
            {
                foreach (var item in ClearRanges)
                {
                    writer.WriteObjectValue(item, "ClearRange");
                }
            }
            writer.WriteEndElement();
        }

        internal static ShareFileRangeList DeserializeShareFileRangeList(XElement element, ModelReaderWriterOptions options = null)
        {
            IReadOnlyList<FileRange> ranges = default;
            IReadOnlyList<ClearRange> clearRanges = default;
            var array = new List<FileRange>();
            foreach (var e in element.Elements("Range"))
            {
                array.Add(FileRange.DeserializeFileRange(e));
            }
            ranges = array;
            var array0 = new List<ClearRange>();
            foreach (var e in element.Elements("ClearRange"))
            {
                array0.Add(ClearRange.DeserializeClearRange(e));
            }
            clearRanges = array0;
            return new ShareFileRangeList(ranges, clearRanges, default);
        }

        BinaryData IModel<ShareFileRangeList>.Write(ModelReaderWriterOptions options)
        {
            bool implementsJson = this is IJsonModel<ShareFileRangeList>;
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

        ShareFileRangeList IModel<ShareFileRangeList>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ShareFileRangeList)} does not support '{options.Format}' format.");
            }

            return DeserializeShareFileRangeList(XElement.Load(data.ToStream()), options);
        }

        ModelReaderWriterFormat IModel<ShareFileRangeList>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Xml;
    }
}
