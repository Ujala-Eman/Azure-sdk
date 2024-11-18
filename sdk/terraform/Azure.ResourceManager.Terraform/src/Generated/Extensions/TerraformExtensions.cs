// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.Terraform.Mocking;
using Azure.ResourceManager.Terraform.Models;

namespace Azure.ResourceManager.Terraform
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Terraform. </summary>
    public static partial class TerraformExtensions
    {
        private static MockableTerraformSubscriptionResource GetMockableTerraformSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableTerraformSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Exports the Terraform configuration of the specified resource(s).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureTerraform/exportTerraform</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Terraform_ExportTerraform</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01-preview</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTerraformSubscriptionResource.ExportTerraform(WaitUntil,CommonExportProperties,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="body"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="body"/> is null. </exception>
        public static async Task<ArmOperation<TerraformOperationStatus>> ExportTerraformAsync(this SubscriptionResource subscriptionResource, WaitUntil waitUntil, CommonExportProperties body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return await GetMockableTerraformSubscriptionResource(subscriptionResource).ExportTerraformAsync(waitUntil, body, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Exports the Terraform configuration of the specified resource(s).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.AzureTerraform/exportTerraform</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Terraform_ExportTerraform</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2023-07-01-preview</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableTerraformSubscriptionResource.ExportTerraform(WaitUntil,CommonExportProperties,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="body"> The request body. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionResource"/> or <paramref name="body"/> is null. </exception>
        public static ArmOperation<TerraformOperationStatus> ExportTerraform(this SubscriptionResource subscriptionResource, WaitUntil waitUntil, CommonExportProperties body, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(subscriptionResource, nameof(subscriptionResource));

            return GetMockableTerraformSubscriptionResource(subscriptionResource).ExportTerraform(waitUntil, body, cancellationToken);
        }
    }
}
