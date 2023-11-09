// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The UnknownTrigger. </summary>
    internal partial class UnknownTrigger : Trigger
    {
        /// <summary> Initializes a new instance of <see cref="UnknownTrigger"/>. </summary>
        /// <param name="type"> Trigger type. </param>
        /// <param name="description"> Trigger description. </param>
        /// <param name="runtimeState"> Indicates if trigger is running or not. Updated when Start/Stop APIs are called on the Trigger. </param>
        /// <param name="annotations"> List of tags that can be used for describing the trigger. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal UnknownTrigger(string type, string description, TriggerRuntimeState? runtimeState, IList<object> annotations, IDictionary<string, object> additionalProperties) : base(type, description, runtimeState, annotations, additionalProperties)
        {
            Type = type ?? "Unknown";
        }
    }
}
