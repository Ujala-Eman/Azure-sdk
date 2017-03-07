// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServiceFabric.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Settings section description
    /// </summary>
    public partial class SettingsSectionDescription
    {
        /// <summary>
        /// Initializes a new instance of the SettingsSectionDescription class.
        /// </summary>
        public SettingsSectionDescription() { }

        /// <summary>
        /// Initializes a new instance of the SettingsSectionDescription class.
        /// </summary>
        public SettingsSectionDescription(string name = default(string), IList<SettingsParameterDescription> parameters = default(IList<SettingsParameterDescription>))
        {
            Name = name;
            Parameters = parameters;
        }

        /// <summary>
        /// name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "parameters")]
        public IList<SettingsParameterDescription> Parameters { get; set; }

    }
}
