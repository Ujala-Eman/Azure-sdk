// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// API route config of the Spring Cloud Gateway
    /// </summary>
    public partial class GatewayApiRoute
    {
        /// <summary>
        /// Initializes a new instance of the GatewayApiRoute class.
        /// </summary>
        public GatewayApiRoute()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GatewayApiRoute class.
        /// </summary>
        /// <param name="title">A title, will be applied to methods in the
        /// generated OpenAPI documentation.</param>
        /// <param name="description">A description, will be applied to methods
        /// in the generated OpenAPI documentation.</param>
        /// <param name="uri">Full uri, will override `appName`.</param>
        /// <param name="ssoEnabled">Enable sso validation.</param>
        /// <param name="tokenRelay">Pass currently-authenticated user's
        /// identity token to application service, default is 'false'</param>
        /// <param name="predicates">A number of conditions to evaluate a route
        /// for each request. Each predicate may be evaluated against request
        /// headers and parameter values. All of the predicates associated with
        /// a route must evaluate to true for the route to be matched to the
        /// request.</param>
        /// <param name="filters">To modify the request before sending it to
        /// the target endpoint, or the received response.</param>
        /// <param name="order">Route processing order.</param>
        /// <param name="tags">Classification tags, will be applied to methods
        /// in the generated OpenAPI documentation.</param>
        public GatewayApiRoute(string title = default(string), string description = default(string), string uri = default(string), bool? ssoEnabled = default(bool?), bool? tokenRelay = default(bool?), IList<string> predicates = default(IList<string>), IList<string> filters = default(IList<string>), int? order = default(int?), IList<string> tags = default(IList<string>))
        {
            Title = title;
            Description = description;
            Uri = uri;
            SsoEnabled = ssoEnabled;
            TokenRelay = tokenRelay;
            Predicates = predicates;
            Filters = filters;
            Order = order;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a title, will be applied to methods in the generated
        /// OpenAPI documentation.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets a description, will be applied to methods in the
        /// generated OpenAPI documentation.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets full uri, will override `appName`.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets enable sso validation.
        /// </summary>
        [JsonProperty(PropertyName = "ssoEnabled")]
        public bool? SsoEnabled { get; set; }

        /// <summary>
        /// Gets or sets pass currently-authenticated user's identity token to
        /// application service, default is 'false'
        /// </summary>
        [JsonProperty(PropertyName = "tokenRelay")]
        public bool? TokenRelay { get; set; }

        /// <summary>
        /// Gets or sets a number of conditions to evaluate a route for each
        /// request. Each predicate may be evaluated against request headers
        /// and parameter values. All of the predicates associated with a route
        /// must evaluate to true for the route to be matched to the request.
        /// </summary>
        [JsonProperty(PropertyName = "predicates")]
        public IList<string> Predicates { get; set; }

        /// <summary>
        /// Gets or sets to modify the request before sending it to the target
        /// endpoint, or the received response.
        /// </summary>
        [JsonProperty(PropertyName = "filters")]
        public IList<string> Filters { get; set; }

        /// <summary>
        /// Gets or sets route processing order.
        /// </summary>
        [JsonProperty(PropertyName = "order")]
        public int? Order { get; set; }

        /// <summary>
        /// Gets or sets classification tags, will be applied to methods in the
        /// generated OpenAPI documentation.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IList<string> Tags { get; set; }

    }
}
