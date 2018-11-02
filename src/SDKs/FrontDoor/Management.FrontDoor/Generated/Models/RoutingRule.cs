// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A routing rule represents a specification for traffic to treat and
    /// where to send it, along with health probe information.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RoutingRule : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the RoutingRule class.
        /// </summary>
        public RoutingRule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoutingRule class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="frontendEndpoints">Frontend endpoints associated with
        /// this rule</param>
        /// <param name="acceptedProtocols">Protocol schemes to match for this
        /// rule</param>
        /// <param name="patternsToMatch">The route patterns of the
        /// rule.</param>
        /// <param name="customForwardingPath">A custom path used to rewrite
        /// resource paths matched by this rule. Leave empty to use incoming
        /// path.</param>
        /// <param name="forwardingProtocol">Protocol this rule will use when
        /// forwarding traffic to backends. Possible values include:
        /// 'HttpOnly', 'HttpsOnly', 'MatchRequest'</param>
        /// <param name="cacheConfiguration">The caching configuration
        /// associated with this rule.</param>
        /// <param name="backendPool">A reference to the BackendPool which this
        /// rule routes to.</param>
        /// <param name="enabledState">Whether to enable use of this rule.
        /// Permitted values are 'Enabled' or 'Disabled'. Possible values
        /// include: 'Enabled', 'Disabled'</param>
        /// <param name="resourceState">Resource status. Possible values
        /// include: 'Creating', 'Enabling', 'Enabled', 'Disabling',
        /// 'Disabled', 'Deleting'</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        public RoutingRule(string id = default(string), IList<SubResource> frontendEndpoints = default(IList<SubResource>), IList<string> acceptedProtocols = default(IList<string>), IList<string> patternsToMatch = default(IList<string>), string customForwardingPath = default(string), string forwardingProtocol = default(string), CacheConfiguration cacheConfiguration = default(CacheConfiguration), SubResource backendPool = default(SubResource), string enabledState = default(string), string resourceState = default(string), string name = default(string), string type = default(string))
            : base(id)
        {
            FrontendEndpoints = frontendEndpoints;
            AcceptedProtocols = acceptedProtocols;
            PatternsToMatch = patternsToMatch;
            CustomForwardingPath = customForwardingPath;
            ForwardingProtocol = forwardingProtocol;
            CacheConfiguration = cacheConfiguration;
            BackendPool = backendPool;
            EnabledState = enabledState;
            ResourceState = resourceState;
            Name = name;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets frontend endpoints associated with this rule
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendEndpoints")]
        public IList<SubResource> FrontendEndpoints { get; set; }

        /// <summary>
        /// Gets or sets protocol schemes to match for this rule
        /// </summary>
        [JsonProperty(PropertyName = "properties.acceptedProtocols")]
        public IList<string> AcceptedProtocols { get; set; }

        /// <summary>
        /// Gets or sets the route patterns of the rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.patternsToMatch")]
        public IList<string> PatternsToMatch { get; set; }

        /// <summary>
        /// Gets or sets a custom path used to rewrite resource paths matched
        /// by this rule. Leave empty to use incoming path.
        /// </summary>
        [JsonProperty(PropertyName = "properties.customForwardingPath")]
        public string CustomForwardingPath { get; set; }

        /// <summary>
        /// Gets or sets protocol this rule will use when forwarding traffic to
        /// backends. Possible values include: 'HttpOnly', 'HttpsOnly',
        /// 'MatchRequest'
        /// </summary>
        [JsonProperty(PropertyName = "properties.forwardingProtocol")]
        public string ForwardingProtocol { get; set; }

        /// <summary>
        /// Gets or sets the caching configuration associated with this rule.
        /// </summary>
        [JsonProperty(PropertyName = "properties.cacheConfiguration")]
        public CacheConfiguration CacheConfiguration { get; set; }

        /// <summary>
        /// Gets or sets a reference to the BackendPool which this rule routes
        /// to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendPool")]
        public SubResource BackendPool { get; set; }

        /// <summary>
        /// Gets or sets whether to enable use of this rule. Permitted values
        /// are 'Enabled' or 'Disabled'. Possible values include: 'Enabled',
        /// 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.enabledState")]
        public string EnabledState { get; set; }

        /// <summary>
        /// Gets or sets resource status. Possible values include: 'Creating',
        /// 'Enabling', 'Enabled', 'Disabling', 'Disabled', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceState")]
        public string ResourceState { get; set; }

        /// <summary>
        /// Gets or sets resource name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

    }
}
