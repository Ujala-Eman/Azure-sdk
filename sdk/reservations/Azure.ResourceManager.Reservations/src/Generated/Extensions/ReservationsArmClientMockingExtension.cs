// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Reservations;

namespace Azure.ResourceManager.Reservations.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    internal partial class ReservationsArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="ReservationsArmClientMockingExtension"/> class for mocking. </summary>
        protected ReservationsArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ReservationsArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ReservationsArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal ReservationsArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing a <see cref="ReservationDetailResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ReservationDetailResource.CreateResourceIdentifier" /> to create a <see cref="ReservationDetailResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ReservationDetailResource" /> object. </returns>
        public virtual ReservationDetailResource GetReservationDetailResource(ResourceIdentifier id)
        {
            ReservationDetailResource.ValidateResourceId(id);
            return new ReservationDetailResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ReservationOrderResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ReservationOrderResource.CreateResourceIdentifier" /> to create a <see cref="ReservationOrderResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ReservationOrderResource" /> object. </returns>
        public virtual ReservationOrderResource GetReservationOrderResource(ResourceIdentifier id)
        {
            ReservationOrderResource.ValidateResourceId(id);
            return new ReservationOrderResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="ReservationQuotaResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="ReservationQuotaResource.CreateResourceIdentifier" /> to create a <see cref="ReservationQuotaResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ReservationQuotaResource" /> object. </returns>
        public virtual ReservationQuotaResource GetReservationQuotaResource(ResourceIdentifier id)
        {
            ReservationQuotaResource.ValidateResourceId(id);
            return new ReservationQuotaResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="QuotaRequestDetailResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="QuotaRequestDetailResource.CreateResourceIdentifier" /> to create a <see cref="QuotaRequestDetailResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="QuotaRequestDetailResource" /> object. </returns>
        public virtual QuotaRequestDetailResource GetQuotaRequestDetailResource(ResourceIdentifier id)
        {
            QuotaRequestDetailResource.ValidateResourceId(id);
            return new QuotaRequestDetailResource(Client, id);
        }
    }
}
