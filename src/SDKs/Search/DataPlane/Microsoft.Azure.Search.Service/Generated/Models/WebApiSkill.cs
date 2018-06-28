// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The customized Web Api skill.
    /// <see
    /// href="https://docs.microsoft.com/azure/search/cognitive-search-custom-skill-interface"
    /// />
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Skills.Custom.WebApiSkill")]
    public partial class WebApiSkill : Skill
    {
        /// <summary>
        /// Initializes a new instance of the WebApiSkill class.
        /// </summary>
        public WebApiSkill()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebApiSkill class.
        /// </summary>
        /// <param name="description">The description of the skill which
        /// describes the inputs, outputs, and usage of the skill.</param>
        /// <param name="context">The context of the skill.</param>
        /// <param name="inputs">The inputs of the skill.</param>
        /// <param name="outputs">The outputs of the skill.</param>
        /// <param name="uri">The url for the Web Api.</param>
        /// <param name="httpHeaders">The headers required to make the http
        /// request.</param>
        /// <param name="httpMethod">The method for the http request.</param>
        /// <param name="timeout">The desired timeout for the request.</param>
        /// <param name="batchSize">The desired batch size.</param>
        public WebApiSkill(string description, string context, IList<InputFieldMappingEntry> inputs, IList<OutputFieldMappingEntry> outputs, string uri, WebApiHttpHeaders httpHeaders, string httpMethod, System.TimeSpan? timeout = default(System.TimeSpan?), int? batchSize = default(int?))
            : base(description, context, inputs, outputs)
        {
            Uri = uri;
            HttpHeaders = httpHeaders;
            HttpMethod = httpMethod;
            Timeout = timeout;
            BatchSize = batchSize;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the url for the Web Api.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the headers required to make the http request.
        /// </summary>
        [JsonProperty(PropertyName = "httpHeaders")]
        public WebApiHttpHeaders HttpHeaders { get; set; }

        /// <summary>
        /// Gets or sets the method for the http request.
        /// </summary>
        [JsonProperty(PropertyName = "httpMethod")]
        public string HttpMethod { get; set; }

        /// <summary>
        /// Gets or sets the desired timeout for the request.
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public System.TimeSpan? Timeout { get; set; }

        /// <summary>
        /// Gets or sets the desired batch size.
        /// </summary>
        [JsonProperty(PropertyName = "batchSize")]
        public int? BatchSize { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Uri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Uri");
            }
            if (HttpHeaders == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HttpHeaders");
            }
            if (HttpMethod == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HttpMethod");
            }
        }
    }
}
