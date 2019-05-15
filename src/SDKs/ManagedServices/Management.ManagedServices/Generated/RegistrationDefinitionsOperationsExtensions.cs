// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagedServices
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RegistrationDefinitionsOperations.
    /// </summary>
    public static partial class RegistrationDefinitionsOperationsExtensions
    {
            /// <summary>
            /// Gets the registration definition details.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='registrationDefinitionId'>
            /// Guid of the registration definition.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            public static RegistrationDefinition Get(this IRegistrationDefinitionsOperations operations, string scope, string registrationDefinitionId, string apiVersion)
            {
                return operations.GetAsync(scope, registrationDefinitionId, apiVersion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the registration definition details.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='registrationDefinitionId'>
            /// Guid of the registration definition.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RegistrationDefinition> GetAsync(this IRegistrationDefinitionsOperations operations, string scope, string registrationDefinitionId, string apiVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(scope, registrationDefinitionId, apiVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the registration definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='registrationDefinitionId'>
            /// Guid of the registration definition.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            public static RegistrationDefinition Delete(this IRegistrationDefinitionsOperations operations, string registrationDefinitionId, string apiVersion, string scope)
            {
                return operations.DeleteAsync(registrationDefinitionId, apiVersion, scope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the registration definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='registrationDefinitionId'>
            /// Guid of the registration definition.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RegistrationDefinition> DeleteAsync(this IRegistrationDefinitionsOperations operations, string registrationDefinitionId, string apiVersion, string scope, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(registrationDefinitionId, apiVersion, scope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a registration definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='registrationDefinitionId'>
            /// Guid of the registration definition.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='requestBody'>
            /// The parameters required to create new registration definition.
            /// </param>
            public static RegistrationDefinition CreateOrUpdate(this IRegistrationDefinitionsOperations operations, string registrationDefinitionId, string apiVersion, string scope, RegistrationDefinition requestBody)
            {
                return operations.CreateOrUpdateAsync(registrationDefinitionId, apiVersion, scope, requestBody).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a registration definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='registrationDefinitionId'>
            /// Guid of the registration definition.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='requestBody'>
            /// The parameters required to create new registration definition.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RegistrationDefinition> CreateOrUpdateAsync(this IRegistrationDefinitionsOperations operations, string registrationDefinitionId, string apiVersion, string scope, RegistrationDefinition requestBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(registrationDefinitionId, apiVersion, scope, requestBody, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of the registration definitions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            public static IPage<RegistrationDefinition> List(this IRegistrationDefinitionsOperations operations, string scope, string apiVersion)
            {
                return operations.ListAsync(scope, apiVersion).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of the registration definitions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RegistrationDefinition>> ListAsync(this IRegistrationDefinitionsOperations operations, string scope, string apiVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(scope, apiVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a registration definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='registrationDefinitionId'>
            /// Guid of the registration definition.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='requestBody'>
            /// The parameters required to create new registration definition.
            /// </param>
            public static RegistrationDefinition BeginCreateOrUpdate(this IRegistrationDefinitionsOperations operations, string registrationDefinitionId, string apiVersion, string scope, RegistrationDefinition requestBody)
            {
                return operations.BeginCreateOrUpdateAsync(registrationDefinitionId, apiVersion, scope, requestBody).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a registration definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='registrationDefinitionId'>
            /// Guid of the registration definition.
            /// </param>
            /// <param name='apiVersion'>
            /// The API version to use for this operation.
            /// </param>
            /// <param name='scope'>
            /// Scope of the resource.
            /// </param>
            /// <param name='requestBody'>
            /// The parameters required to create new registration definition.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RegistrationDefinition> BeginCreateOrUpdateAsync(this IRegistrationDefinitionsOperations operations, string registrationDefinitionId, string apiVersion, string scope, RegistrationDefinition requestBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(registrationDefinitionId, apiVersion, scope, requestBody, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of the registration definitions.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RegistrationDefinition> ListNext(this IRegistrationDefinitionsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of the registration definitions.
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
            public static async Task<IPage<RegistrationDefinition>> ListNextAsync(this IRegistrationDefinitionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
