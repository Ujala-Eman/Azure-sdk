// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    public partial class SiteRecoveryAlertResource : IJsonModel<SiteRecoveryAlertData>
    {
        void IJsonModel<SiteRecoveryAlertData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStringValue(ModelReaderWriter.Write(Data, options));
        }

        SiteRecoveryAlertData IJsonModel<SiteRecoveryAlertData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<SiteRecoveryAlertData>(new BinaryData(reader.ValueSequence), options);
        }

        BinaryData IPersistableModel<SiteRecoveryAlertData>.Write(ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Write(Data, options);
        }

        SiteRecoveryAlertData IPersistableModel<SiteRecoveryAlertData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            return ModelReaderWriter.Read<SiteRecoveryAlertData>(data, options);
        }

        string IPersistableModel<SiteRecoveryAlertData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
