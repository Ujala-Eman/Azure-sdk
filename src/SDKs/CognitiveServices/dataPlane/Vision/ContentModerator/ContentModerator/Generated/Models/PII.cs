// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.CognitiveServices.ContentModerator.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Personal Identifier Information details.
    /// </summary>
    public partial class PII
    {
        /// <summary>
        /// Initializes a new instance of the PII class.
        /// </summary>
        public PII()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PII class.
        /// </summary>
        public PII(IList<Email> email = default(IList<Email>), IList<SSN> sSN = default(IList<SSN>), IList<IPA> iPA = default(IList<IPA>), IList<Phone> phone = default(IList<Phone>), IList<Address> address = default(IList<Address>))
        {
            Email = email;
            SSN = sSN;
            IPA = iPA;
            Phone = phone;
            Address = address;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Email")]
        public IList<Email> Email { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "SSN")]
        public IList<SSN> SSN { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "IPA")]
        public IList<IPA> IPA { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Phone")]
        public IList<Phone> Phone { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Address")]
        public IList<Address> Address { get; set; }

    }
}
