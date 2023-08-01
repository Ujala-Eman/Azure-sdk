// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Automation;

namespace Azure.ResourceManager.Automation.Mocking
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    internal partial class AutomationArmClientMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="AutomationArmClientMockingExtension"/> class for mocking. </summary>
        protected AutomationArmClientMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="AutomationArmClientMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal AutomationArmClientMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        internal AutomationArmClientMockingExtension(ArmClient client) : this(client, ResourceIdentifier.Root)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Gets an object representing an <see cref="AutomationPrivateEndpointConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutomationPrivateEndpointConnectionResource.CreateResourceIdentifier" /> to create an <see cref="AutomationPrivateEndpointConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutomationPrivateEndpointConnectionResource" /> object. </returns>
        public virtual AutomationPrivateEndpointConnectionResource GetAutomationPrivateEndpointConnectionResource(ResourceIdentifier id)
        {
            AutomationPrivateEndpointConnectionResource.ValidateResourceId(id);
            return new AutomationPrivateEndpointConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AutomationAccountPython2PackageResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutomationAccountPython2PackageResource.CreateResourceIdentifier" /> to create an <see cref="AutomationAccountPython2PackageResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutomationAccountPython2PackageResource" /> object. </returns>
        public virtual AutomationAccountPython2PackageResource GetAutomationAccountPython2PackageResource(ResourceIdentifier id)
        {
            AutomationAccountPython2PackageResource.ValidateResourceId(id);
            return new AutomationAccountPython2PackageResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AutomationAccountModuleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutomationAccountModuleResource.CreateResourceIdentifier" /> to create an <see cref="AutomationAccountModuleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutomationAccountModuleResource" /> object. </returns>
        public virtual AutomationAccountModuleResource GetAutomationAccountModuleResource(ResourceIdentifier id)
        {
            AutomationAccountModuleResource.ValidateResourceId(id);
            return new AutomationAccountModuleResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DscNodeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DscNodeResource.CreateResourceIdentifier" /> to create a <see cref="DscNodeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DscNodeResource" /> object. </returns>
        public virtual DscNodeResource GetDscNodeResource(ResourceIdentifier id)
        {
            DscNodeResource.ValidateResourceId(id);
            return new DscNodeResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DscNodeConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DscNodeConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="DscNodeConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DscNodeConfigurationResource" /> object. </returns>
        public virtual DscNodeConfigurationResource GetDscNodeConfigurationResource(ResourceIdentifier id)
        {
            DscNodeConfigurationResource.ValidateResourceId(id);
            return new DscNodeConfigurationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DscCompilationJobResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DscCompilationJobResource.CreateResourceIdentifier" /> to create a <see cref="DscCompilationJobResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DscCompilationJobResource" /> object. </returns>
        public virtual DscCompilationJobResource GetDscCompilationJobResource(ResourceIdentifier id)
        {
            DscCompilationJobResource.ValidateResourceId(id);
            return new DscCompilationJobResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AutomationSourceControlResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutomationSourceControlResource.CreateResourceIdentifier" /> to create an <see cref="AutomationSourceControlResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutomationSourceControlResource" /> object. </returns>
        public virtual AutomationSourceControlResource GetAutomationSourceControlResource(ResourceIdentifier id)
        {
            AutomationSourceControlResource.ValidateResourceId(id);
            return new AutomationSourceControlResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AutomationAccountResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutomationAccountResource.CreateResourceIdentifier" /> to create an <see cref="AutomationAccountResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutomationAccountResource" /> object. </returns>
        public virtual AutomationAccountResource GetAutomationAccountResource(ResourceIdentifier id)
        {
            AutomationAccountResource.ValidateResourceId(id);
            return new AutomationAccountResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AutomationCertificateResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutomationCertificateResource.CreateResourceIdentifier" /> to create an <see cref="AutomationCertificateResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutomationCertificateResource" /> object. </returns>
        public virtual AutomationCertificateResource GetAutomationCertificateResource(ResourceIdentifier id)
        {
            AutomationCertificateResource.ValidateResourceId(id);
            return new AutomationCertificateResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AutomationConnectionResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutomationConnectionResource.CreateResourceIdentifier" /> to create an <see cref="AutomationConnectionResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutomationConnectionResource" /> object. </returns>
        public virtual AutomationConnectionResource GetAutomationConnectionResource(ResourceIdentifier id)
        {
            AutomationConnectionResource.ValidateResourceId(id);
            return new AutomationConnectionResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AutomationConnectionTypeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutomationConnectionTypeResource.CreateResourceIdentifier" /> to create an <see cref="AutomationConnectionTypeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutomationConnectionTypeResource" /> object. </returns>
        public virtual AutomationConnectionTypeResource GetAutomationConnectionTypeResource(ResourceIdentifier id)
        {
            AutomationConnectionTypeResource.ValidateResourceId(id);
            return new AutomationConnectionTypeResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AutomationCredentialResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutomationCredentialResource.CreateResourceIdentifier" /> to create an <see cref="AutomationCredentialResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutomationCredentialResource" /> object. </returns>
        public virtual AutomationCredentialResource GetAutomationCredentialResource(ResourceIdentifier id)
        {
            AutomationCredentialResource.ValidateResourceId(id);
            return new AutomationCredentialResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AutomationJobScheduleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutomationJobScheduleResource.CreateResourceIdentifier" /> to create an <see cref="AutomationJobScheduleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutomationJobScheduleResource" /> object. </returns>
        public virtual AutomationJobScheduleResource GetAutomationJobScheduleResource(ResourceIdentifier id)
        {
            AutomationJobScheduleResource.ValidateResourceId(id);
            return new AutomationJobScheduleResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AutomationScheduleResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutomationScheduleResource.CreateResourceIdentifier" /> to create an <see cref="AutomationScheduleResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutomationScheduleResource" /> object. </returns>
        public virtual AutomationScheduleResource GetAutomationScheduleResource(ResourceIdentifier id)
        {
            AutomationScheduleResource.ValidateResourceId(id);
            return new AutomationScheduleResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AutomationVariableResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutomationVariableResource.CreateResourceIdentifier" /> to create an <see cref="AutomationVariableResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutomationVariableResource" /> object. </returns>
        public virtual AutomationVariableResource GetAutomationVariableResource(ResourceIdentifier id)
        {
            AutomationVariableResource.ValidateResourceId(id);
            return new AutomationVariableResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AutomationWatcherResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutomationWatcherResource.CreateResourceIdentifier" /> to create an <see cref="AutomationWatcherResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutomationWatcherResource" /> object. </returns>
        public virtual AutomationWatcherResource GetAutomationWatcherResource(ResourceIdentifier id)
        {
            AutomationWatcherResource.ValidateResourceId(id);
            return new AutomationWatcherResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="DscConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DscConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="DscConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DscConfigurationResource" /> object. </returns>
        public virtual DscConfigurationResource GetDscConfigurationResource(ResourceIdentifier id)
        {
            DscConfigurationResource.ValidateResourceId(id);
            return new DscConfigurationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AutomationJobResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutomationJobResource.CreateResourceIdentifier" /> to create an <see cref="AutomationJobResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutomationJobResource" /> object. </returns>
        public virtual AutomationJobResource GetAutomationJobResource(ResourceIdentifier id)
        {
            AutomationJobResource.ValidateResourceId(id);
            return new AutomationJobResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="SoftwareUpdateConfigurationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="SoftwareUpdateConfigurationResource.CreateResourceIdentifier" /> to create a <see cref="SoftwareUpdateConfigurationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="SoftwareUpdateConfigurationResource" /> object. </returns>
        public virtual SoftwareUpdateConfigurationResource GetSoftwareUpdateConfigurationResource(ResourceIdentifier id)
        {
            SoftwareUpdateConfigurationResource.ValidateResourceId(id);
            return new SoftwareUpdateConfigurationResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AutomationRunbookResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutomationRunbookResource.CreateResourceIdentifier" /> to create an <see cref="AutomationRunbookResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutomationRunbookResource" /> object. </returns>
        public virtual AutomationRunbookResource GetAutomationRunbookResource(ResourceIdentifier id)
        {
            AutomationRunbookResource.ValidateResourceId(id);
            return new AutomationRunbookResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing an <see cref="AutomationWebhookResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AutomationWebhookResource.CreateResourceIdentifier" /> to create an <see cref="AutomationWebhookResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AutomationWebhookResource" /> object. </returns>
        public virtual AutomationWebhookResource GetAutomationWebhookResource(ResourceIdentifier id)
        {
            AutomationWebhookResource.ValidateResourceId(id);
            return new AutomationWebhookResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridRunbookWorkerResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridRunbookWorkerResource.CreateResourceIdentifier" /> to create a <see cref="HybridRunbookWorkerResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridRunbookWorkerResource" /> object. </returns>
        public virtual HybridRunbookWorkerResource GetHybridRunbookWorkerResource(ResourceIdentifier id)
        {
            HybridRunbookWorkerResource.ValidateResourceId(id);
            return new HybridRunbookWorkerResource(Client, id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HybridRunbookWorkerGroupResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HybridRunbookWorkerGroupResource.CreateResourceIdentifier" /> to create a <see cref="HybridRunbookWorkerGroupResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HybridRunbookWorkerGroupResource" /> object. </returns>
        public virtual HybridRunbookWorkerGroupResource GetHybridRunbookWorkerGroupResource(ResourceIdentifier id)
        {
            HybridRunbookWorkerGroupResource.ValidateResourceId(id);
            return new HybridRunbookWorkerGroupResource(Client, id);
        }
    }
}
