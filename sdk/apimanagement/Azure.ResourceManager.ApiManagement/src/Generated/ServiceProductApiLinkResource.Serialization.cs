// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class ServiceProductApiLinkResource : IJsonModel<ProductApiLinkContractData>
    {
        void IJsonModel<ProductApiLinkContractData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ProductApiLinkContractData>)Data).Write(writer, options);

        ProductApiLinkContractData IJsonModel<ProductApiLinkContractData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ProductApiLinkContractData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ProductApiLinkContractData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        ProductApiLinkContractData IPersistableModel<ProductApiLinkContractData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ProductApiLinkContractData>(data, options);

        string IPersistableModel<ProductApiLinkContractData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ProductApiLinkContractData>)Data).GetFormatFromOptions(options);
    }
}
