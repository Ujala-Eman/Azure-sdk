// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ServiceLinker.Models
{
    /// <summary> The azure resource info when target service type is AzureResource. </summary>
    internal partial class AzureResource : TargetServiceBase
    {
        /// <summary> Initializes a new instance of AzureResource. </summary>
        public AzureResource()
        {
            ServiceType = TargetServiceType.AzureResource;
        }

        /// <summary> Initializes a new instance of AzureResource. </summary>
        /// <param name="serviceType"> The target service type. </param>
        /// <param name="id"> The Id of azure resource. </param>
        /// <param name="resourceProperties"> The azure resource connection related properties. </param>
        internal AzureResource(TargetServiceType serviceType, string id, AzureResourcePropertiesBase resourceProperties) : base(serviceType)
        {
            Id = id;
            ResourceProperties = resourceProperties;
            ServiceType = serviceType;
        }

        /// <summary> The Id of azure resource. </summary>
        public string Id { get; set; }
        /// <summary> The azure resource connection related properties. </summary>
        internal AzureResourcePropertiesBase ResourceProperties { get; set; }
        /// <summary> The azure resource type. </summary>
        internal AzureResourceType? AzureResourceType
        {
            get => ResourceProperties is null ? default(AzureResourceType?) : ResourceProperties.AzureResourceType;
            set
            {
                if (value.HasValue)
                {
                    if (ResourceProperties is null)
                        ResourceProperties = new AzureResourcePropertiesBase();
                    ResourceProperties.AzureResourceType = value.Value;
                }
                else
                {
                    ResourceProperties = null;
                }
            }
        }
    }
}
