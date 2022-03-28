// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ArmDeploymentWhatIfProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(WhatIfSettings))
            {
                writer.WritePropertyName("whatIfSettings");
                writer.WriteObjectValue(WhatIfSettings);
            }
            if (Optional.IsDefined(Template))
            {
                writer.WritePropertyName("template");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Template);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Template.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(TemplateLink))
            {
                writer.WritePropertyName("templateLink");
                writer.WriteObjectValue(TemplateLink);
            }
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Parameters);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Parameters.ToString()).RootElement);
#endif
            }
            if (Optional.IsDefined(ParametersLink))
            {
                writer.WritePropertyName("parametersLink");
                writer.WriteObjectValue(ParametersLink);
            }
            writer.WritePropertyName("mode");
            writer.WriteStringValue(Mode.ToSerialString());
            if (Optional.IsDefined(DebugSetting))
            {
                writer.WritePropertyName("debugSetting");
                writer.WriteObjectValue(DebugSetting);
            }
            if (Optional.IsDefined(OnErrorDeployment))
            {
                writer.WritePropertyName("onErrorDeployment");
                writer.WriteObjectValue(OnErrorDeployment);
            }
            if (Optional.IsDefined(ExpressionEvaluation))
            {
                writer.WritePropertyName("expressionEvaluationOptions");
                writer.WriteObjectValue(ExpressionEvaluation);
            }
            writer.WriteEndObject();
        }
    }
}
