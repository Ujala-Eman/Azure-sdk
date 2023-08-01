// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.BillingBenefits;

namespace Azure.ResourceManager.BillingBenefits.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    internal partial class BillingBenefitsArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="BillingBenefitsArmClientMockingExtension"/> class for mocking. </summary>
        protected BillingBenefitsArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="BillingBenefitsArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal BillingBenefitsArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal BillingBenefitsArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="BillingBenefitsSavingsPlanOrderAliasResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BillingBenefitsSavingsPlanOrderAliasResource.CreateResourceIdentifier" /> to create a <see cref="BillingBenefitsSavingsPlanOrderAliasResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BillingBenefitsSavingsPlanOrderAliasResource" /> object. </returns>
        public virtual BillingBenefitsSavingsPlanOrderAliasResource GetBillingBenefitsSavingsPlanOrderAliasResource(ResourceIdentifier id)
        {
            BillingBenefitsSavingsPlanOrderAliasResource.ValidateResourceId(id);
            return new BillingBenefitsSavingsPlanOrderAliasResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BillingBenefitsSavingsPlanOrderResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BillingBenefitsSavingsPlanOrderResource.CreateResourceIdentifier" /> to create a <see cref="BillingBenefitsSavingsPlanOrderResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BillingBenefitsSavingsPlanOrderResource" /> object. </returns>
        public virtual BillingBenefitsSavingsPlanOrderResource GetBillingBenefitsSavingsPlanOrderResource(ResourceIdentifier id)
        {
            BillingBenefitsSavingsPlanOrderResource.ValidateResourceId(id);
            return new BillingBenefitsSavingsPlanOrderResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BillingBenefitsSavingsPlanResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BillingBenefitsSavingsPlanResource.CreateResourceIdentifier" /> to create a <see cref="BillingBenefitsSavingsPlanResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BillingBenefitsSavingsPlanResource" /> object. </returns>
        public virtual BillingBenefitsSavingsPlanResource GetBillingBenefitsSavingsPlanResource(ResourceIdentifier id)
        {
            BillingBenefitsSavingsPlanResource.ValidateResourceId(id);
            return new BillingBenefitsSavingsPlanResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="BillingBenefitsReservationOrderAliasResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BillingBenefitsReservationOrderAliasResource.CreateResourceIdentifier" /> to create a <see cref="BillingBenefitsReservationOrderAliasResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BillingBenefitsReservationOrderAliasResource" /> object. </returns>
        public virtual BillingBenefitsReservationOrderAliasResource GetBillingBenefitsReservationOrderAliasResource(ResourceIdentifier id)
        {
            BillingBenefitsReservationOrderAliasResource.ValidateResourceId(id);
            return new BillingBenefitsReservationOrderAliasResource(Client, id);
        }
    }
}
