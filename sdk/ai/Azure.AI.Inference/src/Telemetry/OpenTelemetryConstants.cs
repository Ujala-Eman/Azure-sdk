﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.AI.Inference.Telemetry
{
    internal class OpenTelemetryConstants
    {
        public const string ClientName = "Azure.AI.Inference.ChatCompletionsClient";
        public const string AppContextSwitch = "Azure.Experimental.EnableActivitySource";
        public const string TraceContentsSwitch = "Azure.Experimental.TraceContents";
        public const string EnvironmentVariableTraceContents = "AZURE_TRACING_GEN_AI_CONTENT_RECORDING_ENABLED";
        public const string EnvironmentVariableSwitchName = "AZURE_EXPERIMENTAL_ENABLE_ACTIVITY_SOURCE";
    }
}
