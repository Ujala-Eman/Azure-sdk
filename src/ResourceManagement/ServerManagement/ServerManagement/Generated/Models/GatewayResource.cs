// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServerManagement.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    [JsonTransformation]
    public partial class GatewayResource : Resource
    {
        /// <summary>
        /// Initializes a new instance of the GatewayResource class.
        /// </summary>
        public GatewayResource() { }

        /// <summary>
        /// Initializes a new instance of the GatewayResource class.
        /// </summary>
        public GatewayResource(string id = default(string), string type = default(string), string name = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), string created = default(string), string updated = default(string), AutoUpgrade? autoUpgrade = default(AutoUpgrade?), string desiredVersion = default(string), IList<string> instances = default(IList<string>), int? activeMessageCount = default(int?), string latestPublishedMsiVersion = default(string), string publishedTimeUtc = default(string), GatewayStatus status = default(GatewayStatus))
            : base(id, type, name, location, tags, etag)
        {
            Created = created;
            Updated = updated;
            AutoUpgrade = autoUpgrade;
            DesiredVersion = desiredVersion;
            Instances = instances;
            ActiveMessageCount = activeMessageCount;
            LatestPublishedMsiVersion = latestPublishedMsiVersion;
            PublishedTimeUtc = publishedTimeUtc;
            Status = status;
        }

        /// <summary>
        /// UTC date and time when gateway was first added to management
        /// service
        /// </summary>
        [JsonProperty(PropertyName = "properties.created")]
        public string Created { get; set; }

        /// <summary>
        /// UTC date and time when node was last updated
        /// </summary>
        [JsonProperty(PropertyName = "properties.updated")]
        public string Updated { get; set; }

        /// <summary>
        /// setting of the autoupgrade. Possible values include: 'On', 'Off'
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoUpgrade")]
        public AutoUpgrade? AutoUpgrade { get; set; }

        /// <summary>
        /// latest available msi version
        /// </summary>
        [JsonProperty(PropertyName = "properties.desiredVersion")]
        public string DesiredVersion { get; set; }

        /// <summary>
        /// [todo]nodes in the gateway?
        /// </summary>
        [JsonProperty(PropertyName = "properties.instances")]
        public IList<string> Instances { get; set; }

        /// <summary>
        /// [todo]number of active messages?
        /// </summary>
        [JsonProperty(PropertyName = "properties.activeMessageCount")]
        public int? ActiveMessageCount { get; set; }

        /// <summary>
        /// [todo]last published msi version?
        /// </summary>
        [JsonProperty(PropertyName = "properties.latestPublishedMsiVersion")]
        public string LatestPublishedMsiVersion { get; set; }

        /// <summary>
        /// [todo] ?
        /// </summary>
        [JsonProperty(PropertyName = "properties.publishedTimeUtc")]
        public string PublishedTimeUtc { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public GatewayStatus Status { get; set; }

    }
}
