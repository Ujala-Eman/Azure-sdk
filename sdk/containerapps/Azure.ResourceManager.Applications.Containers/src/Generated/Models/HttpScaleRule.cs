// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Applications.Containers.Models
{
    /// <summary> Container App container Custom scaling rule. </summary>
    public partial class HttpScaleRule
    {
        /// <summary> Initializes a new instance of <see cref="HttpScaleRule"/>. </summary>
        public HttpScaleRule()
        {
            Metadata = new ChangeTrackingDictionary<string, string>();
            Auth = new ChangeTrackingList<ContainerAppScaleRuleAuth>();
        }

        /// <summary> Initializes a new instance of <see cref="HttpScaleRule"/>. </summary>
        /// <param name="metadata"> Metadata properties to describe http scale rule. </param>
        /// <param name="auth"> Authentication secrets for the custom scale rule. </param>
        internal HttpScaleRule(IDictionary<string, string> metadata, IList<ContainerAppScaleRuleAuth> auth)
        {
            Metadata = metadata;
            Auth = auth;
        }

        /// <summary> Metadata properties to describe http scale rule. </summary>
        public IDictionary<string, string> Metadata { get; }
        /// <summary> Authentication secrets for the custom scale rule. </summary>
        public IList<ContainerAppScaleRuleAuth> Auth { get; }
    }
}
