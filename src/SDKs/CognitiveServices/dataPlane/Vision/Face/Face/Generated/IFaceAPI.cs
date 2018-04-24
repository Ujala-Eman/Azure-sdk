// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// An API for face detection, verification, and identification.
    /// </summary>
    public partial interface IFaceAPI : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Supported Azure regions for Cognitive Services endpoints. Possible
        /// values include: 'westus', 'westeurope', 'southeastasia', 'eastus2',
        /// 'westcentralus', 'westus2', 'eastus', 'southcentralus',
        /// 'northeurope', 'eastasia', 'australiaeast', 'brazilsouth'
        /// </summary>
        AzureRegions AzureRegion { get; set; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IFaceOperations.
        /// </summary>
        IFaceOperations Face { get; }

        /// <summary>
        /// Gets the IPersonGroupPerson.
        /// </summary>
        IPersonGroupPerson PersonGroupPerson { get; }

        /// <summary>
        /// Gets the IPersonGroupOperations.
        /// </summary>
        IPersonGroupOperations PersonGroup { get; }

        /// <summary>
        /// Gets the IFaceListOperations.
        /// </summary>
        IFaceListOperations FaceList { get; }

    }
}
