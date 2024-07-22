// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Quota
{
    public partial class SubscriptionQuotaAllocationResource : IJsonModel<SubscriptionQuotaAllocationData>
    {
        void IJsonModel<SubscriptionQuotaAllocationData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<SubscriptionQuotaAllocationData>)Data).Write(writer, options);

        SubscriptionQuotaAllocationData IJsonModel<SubscriptionQuotaAllocationData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<SubscriptionQuotaAllocationData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<SubscriptionQuotaAllocationData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        SubscriptionQuotaAllocationData IPersistableModel<SubscriptionQuotaAllocationData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<SubscriptionQuotaAllocationData>(data, options);

        string IPersistableModel<SubscriptionQuotaAllocationData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<SubscriptionQuotaAllocationData>)Data).GetFormatFromOptions(options);
    }
}
