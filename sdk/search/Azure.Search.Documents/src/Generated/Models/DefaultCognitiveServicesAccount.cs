// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Models
{
    /// <summary> An empty object that represents the default cognitive service resource for a skillset. </summary>
    public partial class DefaultCognitiveServicesAccount : CognitiveServicesAccount
    {
        /// <summary> Initializes a new instance of DefaultCognitiveServicesAccount. </summary>
        public DefaultCognitiveServicesAccount()
        {
            ODataType = "#Microsoft.Azure.Search.DefaultCognitiveServices";
        }

        /// <summary> Initializes a new instance of DefaultCognitiveServicesAccount. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the cognitive service resource attached to a skillset. </param>
        /// <param name="description"> Description of the cognitive service resource attached to a skillset. </param>
        internal DefaultCognitiveServicesAccount(string oDataType, string description) : base(oDataType, description)
        {
            ODataType = oDataType ?? "#Microsoft.Azure.Search.DefaultCognitiveServices";
        }
    }
}
