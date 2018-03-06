// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Authorization
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for RoleDefinitionsOperations.
    /// </summary>
    public static partial class RoleDefinitionsOperationsExtensions
    {
            /// <summary>
            /// Deletes a role definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role definition.
            /// </param>
            /// <param name='roleDefinitionId'>
            /// The ID of the role definition to delete.
            /// </param>
            public static RoleDefinition Delete(this IRoleDefinitionsOperations operations, string scope, string roleDefinitionId)
            {
                return operations.DeleteAsync(scope, roleDefinitionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a role definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role definition.
            /// </param>
            /// <param name='roleDefinitionId'>
            /// The ID of the role definition to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleDefinition> DeleteAsync(this IRoleDefinitionsOperations operations, string scope, string roleDefinitionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(scope, roleDefinitionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get role definition by name (GUID).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role definition.
            /// </param>
            /// <param name='roleDefinitionId'>
            /// The ID of the role definition.
            /// </param>
            public static RoleDefinition Get(this IRoleDefinitionsOperations operations, string scope, string roleDefinitionId)
            {
                return operations.GetAsync(scope, roleDefinitionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get role definition by name (GUID).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role definition.
            /// </param>
            /// <param name='roleDefinitionId'>
            /// The ID of the role definition.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleDefinition> GetAsync(this IRoleDefinitionsOperations operations, string scope, string roleDefinitionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(scope, roleDefinitionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a role definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role definition.
            /// </param>
            /// <param name='roleDefinitionId'>
            /// The ID of the role definition.
            /// </param>
            /// <param name='roleDefinition'>
            /// The values for the role definition.
            /// </param>
            public static RoleDefinition CreateOrUpdate(this IRoleDefinitionsOperations operations, string scope, string roleDefinitionId, RoleDefinition roleDefinition)
            {
                return operations.CreateOrUpdateAsync(scope, roleDefinitionId, roleDefinition).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a role definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role definition.
            /// </param>
            /// <param name='roleDefinitionId'>
            /// The ID of the role definition.
            /// </param>
            /// <param name='roleDefinition'>
            /// The values for the role definition.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleDefinition> CreateOrUpdateAsync(this IRoleDefinitionsOperations operations, string scope, string roleDefinitionId, RoleDefinition roleDefinition, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(scope, roleDefinitionId, roleDefinition, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all role definitions that are applicable at scope and above.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role definition.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<RoleDefinition> List(this IRoleDefinitionsOperations operations, string scope, ODataQuery<RoleDefinitionFilter> odataQuery = default(ODataQuery<RoleDefinitionFilter>))
            {
                return operations.ListAsync(scope, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all role definitions that are applicable at scope and above.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scope'>
            /// The scope of the role definition.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<RoleDefinition>> ListAsync(this IRoleDefinitionsOperations operations, string scope, ODataQuery<RoleDefinitionFilter> odataQuery = default(ODataQuery<RoleDefinitionFilter>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(scope, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a role definition by ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='roleId'>
            /// The fully qualified role definition ID. Use the format,
            /// /subscriptions/{guid}/providers/Microsoft.Authorization/roleDefinitions/{roleDefinitionId}
            /// for subscription level role definitions, or
            /// /providers/Microsoft.Authorization/roleDefinitions/{roleDefinitionId} for
            /// tenant level role definitions.
            /// </param>
            public static RoleDefinition GetById(this IRoleDefinitionsOperations operations, string roleId)
            {
                return operations.GetByIdAsync(roleId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a role definition by ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='roleId'>
            /// The fully qualified role definition ID. Use the format,
            /// /subscriptions/{guid}/providers/Microsoft.Authorization/roleDefinitions/{roleDefinitionId}
            /// for subscription level role definitions, or
            /// /providers/Microsoft.Authorization/roleDefinitions/{roleDefinitionId} for
            /// tenant level role definitions.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RoleDefinition> GetByIdAsync(this IRoleDefinitionsOperations operations, string roleId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(roleId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all role definitions that are applicable at scope and above.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<RoleDefinition> ListNext(this IRoleDefinitionsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all role definitions that are applicable at scope and above.
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
            public static async Task<IPage<RoleDefinition>> ListNextAsync(this IRoleDefinitionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
