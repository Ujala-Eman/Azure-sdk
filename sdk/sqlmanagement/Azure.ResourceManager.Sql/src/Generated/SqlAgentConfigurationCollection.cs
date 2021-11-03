// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using SqlManagementClient.Models;

namespace SqlManagementClient
{
    /// <summary> A class representing collection of SqlAgentConfiguration and their operations over its parent. </summary>
    public partial class SqlAgentConfigurationCollection : ArmCollection
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly SqlAgentRestOperations _sqlAgentRestClient;

        /// <summary> Initializes a new instance of the <see cref="SqlAgentConfigurationCollection"/> class for mocking. </summary>
        protected SqlAgentConfigurationCollection()
        {
        }

        /// <summary> Initializes a new instance of SqlAgentConfigurationCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SqlAgentConfigurationCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _sqlAgentRestClient = new SqlAgentRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ManagedInstance.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/sqlAgent/current
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: SqlAgent_CreateOrUpdate
        /// <summary> Puts new sql agent configuration to instance. </summary>
        /// <param name="parameters"> The SqlAgentConfiguration to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public virtual SqlAgentCreateOrUpdateOperation CreateOrUpdate(SqlAgentConfigurationData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlAgentConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _sqlAgentRestClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, parameters, cancellationToken);
                var operation = new SqlAgentCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/sqlAgent/current
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: SqlAgent_CreateOrUpdate
        /// <summary> Puts new sql agent configuration to instance. </summary>
        /// <param name="parameters"> The SqlAgentConfiguration to use. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="parameters"/> is null. </exception>
        public async virtual Task<SqlAgentCreateOrUpdateOperation> CreateOrUpdateAsync(SqlAgentConfigurationData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("SqlAgentConfigurationCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _sqlAgentRestClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new SqlAgentCreateOrUpdateOperation(Parent, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/sqlAgent/current
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: SqlAgent_Get
        /// <summary> Gets current instance sql agent configuration. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlAgentConfiguration> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SqlAgentConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = _sqlAgentRestClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlAgentConfiguration(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/sqlAgent/current
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}
        /// OperationId: SqlAgent_Get
        /// <summary> Gets current instance sql agent configuration. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SqlAgentConfiguration>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SqlAgentConfigurationCollection.Get");
            scope.Start();
            try
            {
                var response = await _sqlAgentRestClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SqlAgentConfiguration(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlAgentConfiguration> GetIfExists(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SqlAgentConfigurationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _sqlAgentRestClient.Get(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<SqlAgentConfiguration>(null, response.GetRawResponse())
                    : Response.FromValue(new SqlAgentConfiguration(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<SqlAgentConfiguration>> GetIfExistsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SqlAgentConfigurationCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _sqlAgentRestClient.GetAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<SqlAgentConfiguration>(null, response.GetRawResponse())
                    : Response.FromValue(new SqlAgentConfiguration(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> CheckIfExists(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SqlAgentConfigurationCollection.CheckIfExists");
            scope.Start();
            try
            {
                var response = GetIfExists(cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("SqlAgentConfigurationCollection.CheckIfExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<Azure.ResourceManager.ResourceIdentifier, SqlAgentConfiguration, SqlAgentConfigurationData> Construct() { }
    }
}
