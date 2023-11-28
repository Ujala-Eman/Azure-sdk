// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel;
using System.Xml;
using System.Xml.Linq;
using Azure.Core;

namespace Azure.Storage.Files.Shares.Models
{
    public partial class ShareMetrics : IXmlSerializable
    {
        private void WriteInternal(XmlWriter writer, string nameHint, ModelReaderWriterOptions options)
        {
            writer.WriteStartElement(nameHint ?? "Metrics");
            writer.WriteStartElement("Version");
            writer.WriteValue(Version);
            writer.WriteEndElement();
            writer.WriteStartElement("Enabled");
            writer.WriteValue(Enabled);
            writer.WriteEndElement();
            if (Optional.IsDefined(IncludeApis))
            {
                writer.WriteStartElement("IncludeAPIs");
                writer.WriteValue(IncludeApis.Value);
                writer.WriteEndElement();
            }
            if (Optional.IsDefined(RetentionPolicy))
            {
                writer.WriteObjectValue(RetentionPolicy, "RetentionPolicy");
            }
            writer.WriteEndElement();
        }

        void IXmlSerializable.Write(XmlWriter writer, string nameHint) => WriteInternal(writer, nameHint, new ModelReaderWriterOptions("W"));

        internal static ShareMetrics DeserializeShareMetrics(XElement element, ModelReaderWriterOptions options = null)
        {
            string version = default;
            bool enabled = default;
            bool? includeApis = default;
            ShareRetentionPolicy retentionPolicy = default;
            if (element.Element("Version") is XElement versionElement)
            {
                version = (string)versionElement;
            }
            if (element.Element("Enabled") is XElement enabledElement)
            {
                enabled = (bool)enabledElement;
            }
            if (element.Element("IncludeAPIs") is XElement includeAPIsElement)
            {
                includeApis = (bool?)includeAPIsElement;
            }
            if (element.Element("RetentionPolicy") is XElement retentionPolicyElement)
            {
                retentionPolicy = ShareRetentionPolicy.DeserializeShareRetentionPolicy(retentionPolicyElement);
            }
            return new ShareMetrics(version, enabled, includeApis, retentionPolicy);
        }
    }
}
