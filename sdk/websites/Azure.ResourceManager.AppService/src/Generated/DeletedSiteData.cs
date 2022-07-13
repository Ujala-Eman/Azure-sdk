// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing the DeletedSite data model. </summary>
    public partial class DeletedSiteData : ResourceData
    {
        /// <summary> Initializes a new instance of DeletedSiteData. </summary>
        public DeletedSiteData()
        {
        }

        /// <summary> Initializes a new instance of DeletedSiteData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="deletedSiteId"> Numeric id for the deleted site. </param>
        /// <param name="deletedTimestamp"> Time in UTC when the app was deleted. </param>
        /// <param name="subscription"> Subscription containing the deleted site. </param>
        /// <param name="resourceGroup"> ResourceGroup that contained the deleted site. </param>
        /// <param name="deletedSiteName"> Name of the deleted site. </param>
        /// <param name="slot"> Slot of the deleted site. </param>
        /// <param name="kindPropertiesKind"> Kind of site that was deleted. </param>
        /// <param name="geoRegionName"> Geo Region of the deleted site. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal DeletedSiteData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, int? deletedSiteId, string deletedTimestamp, string subscription, string resourceGroup, string deletedSiteName, string slot, string kindPropertiesKind, string geoRegionName, string kind) : base(id, name, resourceType, systemData)
        {
            DeletedSiteId = deletedSiteId;
            DeletedTimestamp = deletedTimestamp;
            Subscription = subscription;
            ResourceGroup = resourceGroup;
            DeletedSiteName = deletedSiteName;
            Slot = slot;
            KindPropertiesKind = kindPropertiesKind;
            GeoRegionName = geoRegionName;
            Kind = kind;
        }

        /// <summary> Numeric id for the deleted site. </summary>
        public int? DeletedSiteId { get; }
        /// <summary> Time in UTC when the app was deleted. </summary>
        public string DeletedTimestamp { get; }
        /// <summary> Subscription containing the deleted site. </summary>
        public string Subscription { get; }
        /// <summary> ResourceGroup that contained the deleted site. </summary>
        public string ResourceGroup { get; }
        /// <summary> Name of the deleted site. </summary>
        public string DeletedSiteName { get; }
        /// <summary> Slot of the deleted site. </summary>
        public string Slot { get; }
        /// <summary> Kind of site that was deleted. </summary>
        public string KindPropertiesKind { get; }
        /// <summary> Geo Region of the deleted site. </summary>
        public string GeoRegionName { get; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
