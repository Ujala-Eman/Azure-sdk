// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.CognitiveServices.ContentModerator.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class JobId
    {
        /// <summary>
        /// Initializes a new instance of the JobId class.
        /// </summary>
        public JobId()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobId class.
        /// </summary>
        /// <param name="jobIdProperty">Id of the created job.</param>
        public JobId(string jobIdProperty = default(string))
        {
            JobIdProperty = jobIdProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of the created job.
        /// </summary>
        [JsonProperty(PropertyName = "JobId")]
        public string JobIdProperty { get; set; }

    }
}
