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

namespace Azure.ResourceManager.Blueprint
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.Blueprint. </summary>
    public static partial class BlueprintExtensions
    {
        private static ArmResourceExtensionClient GetExtensionClient(ArmClient client, ResourceIdentifier scope)
        {
            return client.GetResourceClient(() =>
            {
                return new ArmResourceExtensionClient(client, scope);
            }
            );
        }

        private static ArmResourceExtensionClient GetExtensionClient(ArmResource armResource)
        {
            return armResource.GetCachedClient((client) =>
            {
                return new ArmResourceExtensionClient(client, armResource.Id);
            }
            );
        }

        /// <summary> Gets a collection of BlueprintResources in the ArmResource. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of BlueprintResources and their operations over a BlueprintResource. </returns>
        public static BlueprintCollection GetBlueprints(this ArmClient client, ResourceIdentifier scope)
        {
            return GetExtensionClient(client, scope).GetBlueprints();
        }

        /// <summary>
        /// Get a blueprint definition.
        /// Request Path: /{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}
        /// Operation Id: Blueprints_Get
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="blueprintName"> Name of the blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="blueprintName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="blueprintName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<BlueprintResource>> GetBlueprintAsync(this ArmClient client, ResourceIdentifier scope, string blueprintName, CancellationToken cancellationToken = default)
        {
            return await client.GetBlueprints(scope).GetAsync(blueprintName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a blueprint definition.
        /// Request Path: /{resourceScope}/providers/Microsoft.Blueprint/blueprints/{blueprintName}
        /// Operation Id: Blueprints_Get
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="blueprintName"> Name of the blueprint definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="blueprintName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="blueprintName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<BlueprintResource> GetBlueprint(this ArmClient client, ResourceIdentifier scope, string blueprintName, CancellationToken cancellationToken = default)
        {
            return client.GetBlueprints(scope).Get(blueprintName, cancellationToken);
        }

        /// <summary> Gets a collection of AssignmentResources in the ArmResource. </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <returns> An object representing collection of AssignmentResources and their operations over a AssignmentResource. </returns>
        public static AssignmentCollection GetAssignments(this ArmClient client, ResourceIdentifier scope)
        {
            return GetExtensionClient(client, scope).GetAssignments();
        }

        /// <summary>
        /// Get a blueprint assignment.
        /// Request Path: /{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}
        /// Operation Id: Assignments_Get
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="assignmentName"> Name of the blueprint assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentName"/> is null. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<AssignmentResource>> GetAssignmentAsync(this ArmClient client, ResourceIdentifier scope, string assignmentName, CancellationToken cancellationToken = default)
        {
            return await client.GetAssignments(scope).GetAsync(assignmentName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get a blueprint assignment.
        /// Request Path: /{resourceScope}/providers/Microsoft.Blueprint/blueprintAssignments/{assignmentName}
        /// Operation Id: Assignments_Get
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="scope"> The scope that the resource will apply against. </param>
        /// <param name="assignmentName"> Name of the blueprint assignment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="assignmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="assignmentName"/> is null. </exception>
        [ForwardsClientCalls]
        public static Response<AssignmentResource> GetAssignment(this ArmClient client, ResourceIdentifier scope, string assignmentName, CancellationToken cancellationToken = default)
        {
            return client.GetAssignments(scope).Get(assignmentName, cancellationToken);
        }

        #region BlueprintResource
        /// <summary>
        /// Gets an object representing a <see cref="BlueprintResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BlueprintResource.CreateResourceIdentifier" /> to create a <see cref="BlueprintResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlueprintResource" /> object. </returns>
        public static BlueprintResource GetBlueprintResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BlueprintResource.ValidateResourceId(id);
                return new BlueprintResource(client, id);
            }
            );
        }
        #endregion

        #region BlueprintArtifactResource
        /// <summary>
        /// Gets an object representing a <see cref="BlueprintArtifactResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BlueprintArtifactResource.CreateResourceIdentifier" /> to create a <see cref="BlueprintArtifactResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlueprintArtifactResource" /> object. </returns>
        public static BlueprintArtifactResource GetBlueprintArtifactResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BlueprintArtifactResource.ValidateResourceId(id);
                return new BlueprintArtifactResource(client, id);
            }
            );
        }
        #endregion

        #region BlueprintVersionArtifactResource
        /// <summary>
        /// Gets an object representing a <see cref="BlueprintVersionArtifactResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="BlueprintVersionArtifactResource.CreateResourceIdentifier" /> to create a <see cref="BlueprintVersionArtifactResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="BlueprintVersionArtifactResource" /> object. </returns>
        public static BlueprintVersionArtifactResource GetBlueprintVersionArtifactResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                BlueprintVersionArtifactResource.ValidateResourceId(id);
                return new BlueprintVersionArtifactResource(client, id);
            }
            );
        }
        #endregion

        #region PublishedBlueprintResource
        /// <summary>
        /// Gets an object representing a <see cref="PublishedBlueprintResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="PublishedBlueprintResource.CreateResourceIdentifier" /> to create a <see cref="PublishedBlueprintResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="PublishedBlueprintResource" /> object. </returns>
        public static PublishedBlueprintResource GetPublishedBlueprintResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                PublishedBlueprintResource.ValidateResourceId(id);
                return new PublishedBlueprintResource(client, id);
            }
            );
        }
        #endregion

        #region AssignmentResource
        /// <summary>
        /// Gets an object representing an <see cref="AssignmentResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AssignmentResource.CreateResourceIdentifier" /> to create an <see cref="AssignmentResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AssignmentResource" /> object. </returns>
        public static AssignmentResource GetAssignmentResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AssignmentResource.ValidateResourceId(id);
                return new AssignmentResource(client, id);
            }
            );
        }
        #endregion

        #region AssignmentOperationResource
        /// <summary>
        /// Gets an object representing an <see cref="AssignmentOperationResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="AssignmentOperationResource.CreateResourceIdentifier" /> to create an <see cref="AssignmentOperationResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="AssignmentOperationResource" /> object. </returns>
        public static AssignmentOperationResource GetAssignmentOperationResource(this ArmClient client, ResourceIdentifier id)
        {
            return client.GetResourceClient(() =>
            {
                AssignmentOperationResource.ValidateResourceId(id);
                return new AssignmentOperationResource(client, id);
            }
            );
        }
        #endregion
    }
}
