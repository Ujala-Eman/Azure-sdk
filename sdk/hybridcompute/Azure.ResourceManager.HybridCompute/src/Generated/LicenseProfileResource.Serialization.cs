// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.HybridCompute
{
    public partial class LicenseProfileResource : IJsonModel<LicenseProfileData>
    {
        void IJsonModel<LicenseProfileData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<LicenseProfileData>)Data).Write(writer, options);

        LicenseProfileData IJsonModel<LicenseProfileData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<LicenseProfileData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<LicenseProfileData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        LicenseProfileData IPersistableModel<LicenseProfileData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<LicenseProfileData>(data, options);

        string IPersistableModel<LicenseProfileData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<LicenseProfileData>)Data).GetFormatFromOptions(options);
    }
}
