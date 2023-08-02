// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.IotFirmwareDefense;

namespace Azure.ResourceManager.IotFirmwareDefense.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class IotFirmwareDefenseResourceGroupMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="IotFirmwareDefenseResourceGroupMockingExtension"/> class for mocking. </summary>
        protected IotFirmwareDefenseResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IotFirmwareDefenseResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal IotFirmwareDefenseResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of FirmwareWorkspaceResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of FirmwareWorkspaceResources and their operations over a FirmwareWorkspaceResource. </returns>
        public virtual FirmwareWorkspaceCollection GetFirmwareWorkspaces()
        {
            return GetCachedClient(Client => new FirmwareWorkspaceCollection(Client, Id));
        }

        /// <summary>
        /// Get firmware analysis workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the firmware analysis workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<FirmwareWorkspaceResource>> GetFirmwareWorkspaceAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            return await GetFirmwareWorkspaces().GetAsync(workspaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get firmware analysis workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.IoTFirmwareDefense/workspaces/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Workspaces_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The name of the firmware analysis workspace. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<FirmwareWorkspaceResource> GetFirmwareWorkspace(string workspaceName, CancellationToken cancellationToken = default)
        {
            return GetFirmwareWorkspaces().Get(workspaceName, cancellationToken);
        }
    }
}
