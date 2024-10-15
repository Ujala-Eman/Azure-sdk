// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public partial class MockableAppComplianceAutomationArmClient : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableAppComplianceAutomationArmClient"/> class for mocking. </summary>
        protected MockableAppComplianceAutomationArmClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAppComplianceAutomationArmClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAppComplianceAutomationArmClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal MockableAppComplianceAutomationArmClient(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppComplianceReportResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppComplianceReportResource.CreateResourceIdentifier" /> to create an <see cref="AppComplianceReportResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppComplianceReportResource"/> object. </returns>
        public virtual AppComplianceReportResource GetAppComplianceReportResource(ResourceIdentifier id)
        {
            AppComplianceReportResource.ValidateResourceId(id);
            return new AppComplianceReportResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppComplianceReportEvidenceResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppComplianceReportEvidenceResource.CreateResourceIdentifier" /> to create an <see cref="AppComplianceReportEvidenceResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppComplianceReportEvidenceResource"/> object. </returns>
        public virtual AppComplianceReportEvidenceResource GetAppComplianceReportEvidenceResource(ResourceIdentifier id)
        {
            AppComplianceReportEvidenceResource.ValidateResourceId(id);
            return new AppComplianceReportEvidenceResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppComplianceReportScopingConfigurationResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppComplianceReportScopingConfigurationResource.CreateResourceIdentifier" /> to create an <see cref="AppComplianceReportScopingConfigurationResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppComplianceReportScopingConfigurationResource"/> object. </returns>
        public virtual AppComplianceReportScopingConfigurationResource GetAppComplianceReportScopingConfigurationResource(ResourceIdentifier id)
        {
            AppComplianceReportScopingConfigurationResource.ValidateResourceId(id);
            return new AppComplianceReportScopingConfigurationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppComplianceReportSnapshotResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppComplianceReportSnapshotResource.CreateResourceIdentifier" /> to create an <see cref="AppComplianceReportSnapshotResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppComplianceReportSnapshotResource"/> object. </returns>
        public virtual AppComplianceReportSnapshotResource GetAppComplianceReportSnapshotResource(ResourceIdentifier id)
        {
            AppComplianceReportSnapshotResource.ValidateResourceId(id);
            return new AppComplianceReportSnapshotResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AppComplianceReportWebhookResource"/> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AppComplianceReportWebhookResource.CreateResourceIdentifier" /> to create an <see cref="AppComplianceReportWebhookResource"/> <see cref="ResourceIdentifier"/> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AppComplianceReportWebhookResource"/> object. </returns>
        public virtual AppComplianceReportWebhookResource GetAppComplianceReportWebhookResource(ResourceIdentifier id)
        {
            AppComplianceReportWebhookResource.ValidateResourceId(id);
            return new AppComplianceReportWebhookResource(Client, id);
        }
    }
}
