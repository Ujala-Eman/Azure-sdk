// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.IotFirmwareDefense;

namespace Azure.ResourceManager.IotFirmwareDefense.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableIotFirmwareDefenseArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableIotFirmwareDefenseArmClient"/> class for mocking. </summary>
        protected MockableIotFirmwareDefenseArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableIotFirmwareDefenseArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableIotFirmwareDefenseArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableIotFirmwareDefenseArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing an <see cref="IotFirmwareResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="IotFirmwareResource.CreateResourceIdentifier" /> to create an <see cref="IotFirmwareResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="IotFirmwareResource"/> object. </returns>
        public virtual IotFirmwareResource GetIotFirmwareResource(ResourceIdentifier id)
        {
            IotFirmwareResource.ValidateResourceId(id);
            return new IotFirmwareResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FirmwareAnalysisSummaryResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FirmwareAnalysisSummaryResource.CreateResourceIdentifier" /> to create a <see cref="FirmwareAnalysisSummaryResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FirmwareAnalysisSummaryResource"/> object. </returns>
        public virtual FirmwareAnalysisSummaryResource GetFirmwareAnalysisSummaryResource(ResourceIdentifier id)
        {
            FirmwareAnalysisSummaryResource.ValidateResourceId(id);
            return new FirmwareAnalysisSummaryResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="FirmwareAnalysisWorkspaceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="FirmwareAnalysisWorkspaceResource.CreateResourceIdentifier" /> to create a <see cref="FirmwareAnalysisWorkspaceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="FirmwareAnalysisWorkspaceResource"/> object. </returns>
        public virtual FirmwareAnalysisWorkspaceResource GetFirmwareAnalysisWorkspaceResource(ResourceIdentifier id)
        {
            FirmwareAnalysisWorkspaceResource.ValidateResourceId(id);
            return new FirmwareAnalysisWorkspaceResource(Client, id);
        }
    }
}
