// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Search.LocalSearch.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class StructuredValue : Intangible
    {
        /// <summary>
        /// Initializes a new instance of the StructuredValue class.
        /// </summary>
        public StructuredValue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StructuredValue class.
        /// </summary>
        /// <param name="id">A String identifier.</param>
        /// <param name="readLink">The URL that returns this resource.</param>
        /// <param name="webSearchUrl">The URL to Bing's search result for this
        /// item.</param>
        /// <param name="name">The name of the thing represented by this
        /// object.</param>
        /// <param name="url">The URL to get more information about the thing
        /// represented by this object.</param>
        /// <param name="entityPresentationInfo">Additional information about
        /// the entity such as hints that you can use to determine the entity's
        /// type. To determine the entity's type, use the entityScenario and
        /// entityTypeHint fields.</param>
        public StructuredValue(string id = default(string), string readLink = default(string), string webSearchUrl = default(string), IList<Action> potentialAction = default(IList<Action>), IList<Action> immediateAction = default(IList<Action>), string preferredClickthroughUrl = default(string), string adaptiveCard = default(string), string name = default(string), string url = default(string), EntitiesEntityPresentationInfo entityPresentationInfo = default(EntitiesEntityPresentationInfo))
            : base(id, readLink, webSearchUrl, potentialAction, immediateAction, preferredClickthroughUrl, adaptiveCard, name, url, entityPresentationInfo)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
