// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.HybridData.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The DataManagerUpdateParameter.
    /// </summary>
    public partial class DataManagerUpdateParameter
    {
        /// <summary>
        /// Initializes a new instance of the DataManagerUpdateParameter class.
        /// </summary>
        public DataManagerUpdateParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataManagerUpdateParameter class.
        /// </summary>
        /// <param name="sku">The sku type.</param>
        /// <param name="tags">The list of key value pairs that describe the
        /// resource. These tags can be used in viewing and grouping this
        /// resource
        /// (across resource groups).</param>
        public DataManagerUpdateParameter(Sku sku = default(Sku), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Sku = sku;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the sku type.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets the list of key value pairs that describe the
        /// resource. These tags can be used in viewing and grouping this
        /// resource
        /// (across resource groups).
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}
