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
using Azure.ResourceManager.DataBox.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.DataBox
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.DataBox. </summary>
    public static partial class DataBoxExtensions
    {
        private static SubscriptionResourceExtensionClient GetExtensionClient(SubscriptionResource subscriptionResource)
        {
            return subscriptionResource.GetCachedClient((client) =>
            {
                return new SubscriptionResourceExtensionClient(client, subscriptionResource.Id);
            }
            );
        }

        /// <summary>
        /// Lists all the jobs available under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataBox/jobs
        /// Operation Id: Jobs_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of jobs, which provides the next page in the list of jobs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataBoxJobResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DataBoxJobResource> GetDataBoxJobsAsync(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetDataBoxJobsAsync(skipToken, cancellationToken);
        }

        /// <summary>
        /// Lists all the jobs available under the subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataBox/jobs
        /// Operation Id: Jobs_List
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="skipToken"> $skipToken is supported on Get list of jobs, which provides the next page in the list of jobs. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataBoxJobResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DataBoxJobResource> GetDataBoxJobs(this SubscriptionResource subscriptionResource, string skipToken = null, CancellationToken cancellationToken = default)
        {
            return GetExtensionClient(subscriptionResource).GetDataBoxJobs(skipToken, cancellationToken);
        }

        /// <summary>
        /// [DEPRECATED NOTICE: This operation will soon be removed]. This method validates the customer shipping address and provide alternate addresses if any.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataBox/locations/{location}/validateAddress
        /// Operation Id: Service_ValidateAddress
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Shipping address of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<AddressValidationOutput>> ValidateAddressAsync(this SubscriptionResource subscriptionResource, AzureLocation location, ValidateAddressContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).ValidateAddressAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// [DEPRECATED NOTICE: This operation will soon be removed]. This method validates the customer shipping address and provide alternate addresses if any.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataBox/locations/{location}/validateAddress
        /// Operation Id: Service_ValidateAddress
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Shipping address of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<AddressValidationOutput> ValidateAddress(this SubscriptionResource subscriptionResource, AzureLocation location, ValidateAddressContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).ValidateAddress(location, content, cancellationToken);
        }

        /// <summary>
        /// This method does all necessary pre-job creation validation under subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataBox/locations/{location}/validateInputs
        /// Operation Id: Service_ValidateInputs
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Inputs of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<ValidationResult>> ValidateInputsAsync(this SubscriptionResource subscriptionResource, AzureLocation location, ValidationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).ValidateInputsAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// This method does all necessary pre-job creation validation under subscription.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataBox/locations/{location}/validateInputs
        /// Operation Id: Service_ValidateInputs
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Inputs of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<ValidationResult> ValidateInputs(this SubscriptionResource subscriptionResource, AzureLocation location, ValidationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).ValidateInputs(location, content, cancellationToken);
        }

        /// <summary>
        /// This API provides configuration details specific to given region/location at Subscription level.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataBox/locations/{location}/regionConfiguration
        /// Operation Id: Service_RegionConfiguration
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Request body to get the configuration for the region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<RegionConfigurationResult>> GetRegionConfigurationAsync(this SubscriptionResource subscriptionResource, AzureLocation location, RegionConfigurationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(subscriptionResource).GetRegionConfigurationAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// This API provides configuration details specific to given region/location at Subscription level.
        /// Request Path: /subscriptions/{subscriptionId}/providers/Microsoft.DataBox/locations/{location}/regionConfiguration
        /// Operation Id: Service_RegionConfiguration
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Request body to get the configuration for the region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<RegionConfigurationResult> GetRegionConfiguration(this SubscriptionResource subscriptionResource, AzureLocation location, RegionConfigurationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(subscriptionResource).GetRegionConfiguration(location, content, cancellationToken);
        }

        private static ResourceGroupResourceExtensionClient GetExtensionClient(ResourceGroupResource resourceGroupResource)
        {
            return resourceGroupResource.GetCachedClient((client) =>
            {
                return new ResourceGroupResourceExtensionClient(client, resourceGroupResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of DataBoxJobResources in the ResourceGroupResource. </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of DataBoxJobResources and their operations over a DataBoxJobResource. </returns>
        public static DataBoxJobCollection GetDataBoxJobs(this ResourceGroupResource resourceGroupResource)
        {
            return GetExtensionClient(resourceGroupResource).GetDataBoxJobs();
        }

        /// <summary>
        /// Gets information about the specified job.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/jobs/{jobName}
        /// Operation Id: Jobs_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="jobName"> The name of the job Resource within the specified resource group. job names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="expand"> $expand is supported on details parameter for job, which provides details on the job stages. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<DataBoxJobResource>> GetDataBoxJobAsync(this ResourceGroupResource resourceGroupResource, string jobName, string expand = null, CancellationToken cancellationToken = default)
        {
            return await resourceGroupResource.GetDataBoxJobs().GetAsync(jobName, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets information about the specified job.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/jobs/{jobName}
        /// Operation Id: Jobs_Get
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="jobName"> The name of the job Resource within the specified resource group. job names must be between 3 and 24 characters in length and use any alphanumeric and underscore only. </param>
        /// <param name="expand"> $expand is supported on details parameter for job, which provides details on the job stages. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="jobName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="jobName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<DataBoxJobResource> GetDataBoxJob(this ResourceGroupResource resourceGroupResource, string jobName, string expand = null, CancellationToken cancellationToken = default)
        {
            return resourceGroupResource.GetDataBoxJobs().Get(jobName, expand, cancellationToken);
        }

        /// <summary>
        /// This method provides the list of available skus for the given subscription, resource group and location.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/locations/{location}/availableSkus
        /// Operation Id: Service_ListAvailableSkusByResourceGroup
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Filters for showing the available skus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <returns> An async collection of <see cref="DataBoxSkuInformation" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<DataBoxSkuInformation> GetAvailableSkusAsync(this ResourceGroupResource resourceGroupResource, AzureLocation location, AvailableSkuContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(resourceGroupResource).GetAvailableSkusAsync(location, content, cancellationToken);
        }

        /// <summary>
        /// This method provides the list of available skus for the given subscription, resource group and location.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/locations/{location}/availableSkus
        /// Operation Id: Service_ListAvailableSkusByResourceGroup
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Filters for showing the available skus. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        /// <returns> A collection of <see cref="DataBoxSkuInformation" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<DataBoxSkuInformation> GetAvailableSkus(this ResourceGroupResource resourceGroupResource, AzureLocation location, AvailableSkuContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(resourceGroupResource).GetAvailableSkus(location, content, cancellationToken);
        }

        /// <summary>
        /// This method does all necessary pre-job creation validation under resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/locations/{location}/validateInputs
        /// Operation Id: Service_ValidateInputsByResourceGroup
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Inputs of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<ValidationResult>> ValidateInputsAsync(this ResourceGroupResource resourceGroupResource, AzureLocation location, ValidationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(resourceGroupResource).ValidateInputsAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// This method does all necessary pre-job creation validation under resource group.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/locations/{location}/validateInputs
        /// Operation Id: Service_ValidateInputsByResourceGroup
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Inputs of the customer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<ValidationResult> ValidateInputs(this ResourceGroupResource resourceGroupResource, AzureLocation location, ValidationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(resourceGroupResource).ValidateInputs(location, content, cancellationToken);
        }

        /// <summary>
        /// This API provides configuration details specific to given region/location at Resource group level.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/locations/{location}/regionConfiguration
        /// Operation Id: Service_RegionConfigurationByResourceGroup
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Request body to get the configuration for the region at resource group level. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<RegionConfigurationResult>> GetRegionConfigurationAsync(this ResourceGroupResource resourceGroupResource, AzureLocation location, RegionConfigurationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return await GetExtensionClient(resourceGroupResource).GetRegionConfigurationAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// This API provides configuration details specific to given region/location at Resource group level.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataBox/locations/{location}/regionConfiguration
        /// Operation Id: Service_RegionConfigurationByResourceGroup
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="location"> The location of the resource. </param>
        /// <param name="content"> Request body to get the configuration for the region at resource group level. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<RegionConfigurationResult> GetRegionConfiguration(this ResourceGroupResource resourceGroupResource, AzureLocation location, RegionConfigurationContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            return GetExtensionClient(resourceGroupResource).GetRegionConfiguration(location, content, cancellationToken);
        }

        #region DataBoxJobResource
        /// <summary>
        /// Gets an object representing a <see cref="DataBoxJobResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="DataBoxJobResource.CreateResourceIdentifier" /> to create a <see cref="DataBoxJobResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="DataBoxJobResource" /> object. </returns>
        public static DataBoxJobResource GetDataBoxJobResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                DataBoxJobResource.ValidateResourceId(id);
                return new DataBoxJobResource(client, id);
            }
            );
        }
        #endregion
    }
}
