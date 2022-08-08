// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    internal partial class RejectCallRequestInternal : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("incomingCallContext");
            writer.WriteStringValue(IncomingCallContext);
            if (Optional.IsDefined(CallRejectReason))
            {
                writer.WritePropertyName("callRejectReason");
                writer.WriteStringValue(CallRejectReason.Value.ToString());
            }
            writer.WriteEndObject();
        }
    }
}
