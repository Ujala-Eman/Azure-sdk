// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.CognitiveServices.ContentModerator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Metadata of the list.
    /// </summary>
    public partial class BodyMetadata
    {
        /// <summary>
        /// Initializes a new instance of the BodyMetadata class.
        /// </summary>
        public BodyMetadata()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BodyMetadata class.
        /// </summary>
        /// <param name="keyOne">Optional key value pair to describe your
        /// list.</param>
        /// <param name="keyTwo">Optional key value pair to describe your
        /// list.</param>
        public BodyMetadata(string keyOne = default(string), string keyTwo = default(string))
        {
            KeyOne = keyOne;
            KeyTwo = keyTwo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets optional key value pair to describe your list.
        /// </summary>
        [JsonProperty(PropertyName = "Key One")]
        public string KeyOne { get; set; }

        /// <summary>
        /// Gets or sets optional key value pair to describe your list.
        /// </summary>
        [JsonProperty(PropertyName = "Key Two")]
        public string KeyTwo { get; set; }

    }
}
