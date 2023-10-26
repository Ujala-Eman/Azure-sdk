// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Communication.CallAutomation
{
    public partial class ContinuousDtmfRecognitionStopped
    {
        internal static ContinuousDtmfRecognitionStopped DeserializeContinuousDtmfRecognitionStopped(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            foreach (var property in element.EnumerateObject())
            {
            }
            return new ContinuousDtmfRecognitionStopped();
        }
    }
}
