// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the StaticSiteUserProvidedFunctionAppARM data model. </summary>
    public partial class StaticSiteUserProvidedFunctionAppARMData : ResourceData
    {
        /// <summary> Initializes a new instance of StaticSiteUserProvidedFunctionAppARMData. </summary>
        public StaticSiteUserProvidedFunctionAppARMData()
        {
        }

        /// <summary> Initializes a new instance of StaticSiteUserProvidedFunctionAppARMData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="functionAppResourceId"> The resource id of the function app registered with the static site. </param>
        /// <param name="functionAppRegion"> The region of the function app registered with the static site. </param>
        /// <param name="createdOn"> The date and time on which the function app was registered with the static site. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal StaticSiteUserProvidedFunctionAppARMData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string functionAppResourceId, string functionAppRegion, DateTimeOffset? createdOn, string kind) : base(id, name, resourceType, systemData)
        {
            FunctionAppResourceId = functionAppResourceId;
            FunctionAppRegion = functionAppRegion;
            CreatedOn = createdOn;
            Kind = kind;
        }

        /// <summary> The resource id of the function app registered with the static site. </summary>
        public string FunctionAppResourceId { get; set; }
        /// <summary> The region of the function app registered with the static site. </summary>
        public string FunctionAppRegion { get; set; }
        /// <summary> The date and time on which the function app was registered with the static site. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
