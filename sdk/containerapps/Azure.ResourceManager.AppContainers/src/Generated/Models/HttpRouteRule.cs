// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Http Route rule. </summary>
    public partial class HttpRouteRule
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HttpRouteRule"/>. </summary>
        public HttpRouteRule()
        {
            Targets = new ChangeTrackingList<HttpRouteTarget>();
            Routes = new ChangeTrackingList<HttpRoute>();
        }

        /// <summary> Initializes a new instance of <see cref="HttpRouteRule"/>. </summary>
        /// <param name="targets"> Targets- container apps, revisions, labels. </param>
        /// <param name="routes"> Routing configuration that will allow matches on specific paths/headers. </param>
        /// <param name="description"> Description of rule. Optional. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HttpRouteRule(IList<HttpRouteTarget> targets, IList<HttpRoute> routes, string description, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Targets = targets;
            Routes = routes;
            Description = description;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Targets- container apps, revisions, labels. </summary>
        [WirePath("targets")]
        public IList<HttpRouteTarget> Targets { get; }
        /// <summary> Routing configuration that will allow matches on specific paths/headers. </summary>
        [WirePath("routes")]
        public IList<HttpRoute> Routes { get; }
        /// <summary> Description of rule. Optional. </summary>
        [WirePath("description")]
        public string Description { get; set; }
    }
}
