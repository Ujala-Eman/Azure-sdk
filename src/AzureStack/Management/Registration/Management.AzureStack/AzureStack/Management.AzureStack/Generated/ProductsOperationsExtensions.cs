// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AzureStack
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ProductsOperations.
    /// </summary>
    public static partial class ProductsOperationsExtensions
    {
            /// <summary>
            /// Returns a list of products.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// Name of the resource group.
            /// </param>
            /// <param name='registrationName'>
            /// Name of the Azure Stack registration.
            /// </param>
            public static IPage<Product> List(this IProductsOperations operations, string resourceGroup, string registrationName)
            {
                return operations.ListAsync(resourceGroup, registrationName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of products.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// Name of the resource group.
            /// </param>
            /// <param name='registrationName'>
            /// Name of the Azure Stack registration.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Product>> ListAsync(this IProductsOperations operations, string resourceGroup, string registrationName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroup, registrationName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the specified product.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// Name of the resource group.
            /// </param>
            /// <param name='registrationName'>
            /// Name of the Azure Stack registration.
            /// </param>
            /// <param name='productName'>
            /// Name of the product.
            /// </param>
            public static Product Get(this IProductsOperations operations, string resourceGroup, string registrationName, string productName)
            {
                return operations.GetAsync(resourceGroup, registrationName, productName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the specified product.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// Name of the resource group.
            /// </param>
            /// <param name='registrationName'>
            /// Name of the Azure Stack registration.
            /// </param>
            /// <param name='productName'>
            /// Name of the product.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Product> GetAsync(this IProductsOperations operations, string resourceGroup, string registrationName, string productName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroup, registrationName, productName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns the extended properties of a product.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// Name of the resource group.
            /// </param>
            /// <param name='registrationName'>
            /// Name of the Azure Stack registration.
            /// </param>
            /// <param name='productName'>
            /// Name of the product.
            /// </param>
            public static ExtendedProduct ListDetails(this IProductsOperations operations, string resourceGroup, string registrationName, string productName)
            {
                return operations.ListDetailsAsync(resourceGroup, registrationName, productName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the extended properties of a product.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// Name of the resource group.
            /// </param>
            /// <param name='registrationName'>
            /// Name of the Azure Stack registration.
            /// </param>
            /// <param name='productName'>
            /// Name of the product.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExtendedProduct> ListDetailsAsync(this IProductsOperations operations, string resourceGroup, string registrationName, string productName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListDetailsWithHttpMessagesAsync(resourceGroup, registrationName, productName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns a list of products.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Product> ListNext(this IProductsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a list of products.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Product>> ListNextAsync(this IProductsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
