// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    public partial class PartialOnlineDeployment : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AppInsightsEnabled))
            {
                writer.WritePropertyName("appInsightsEnabled");
                writer.WriteBooleanValue(AppInsightsEnabled.Value);
            }
            writer.WritePropertyName("endpointComputeType");
            writer.WriteStringValue(EndpointComputeType.ToString());
            if (Optional.IsDefined(LivenessProbe))
            {
                writer.WritePropertyName("livenessProbe");
                writer.WriteObjectValue(LivenessProbe);
            }
            if (Optional.IsDefined(RequestSettings))
            {
                writer.WritePropertyName("requestSettings");
                writer.WriteObjectValue(RequestSettings);
            }
            if (Optional.IsDefined(ScaleSettings))
            {
                writer.WritePropertyName("scaleSettings");
                writer.WriteObjectValue(ScaleSettings);
            }
            writer.WriteEndObject();
        }
    }
}
