// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A Class representing a SqlServerAdvisor along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SqlServerAdvisorResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSqlServerAdvisorResource method.
    /// Otherwise you can get one from its parent resource <see cref="SqlServerResource" /> using the GetSqlServerAdvisor method.
    /// </summary>
    public partial class SqlServerAdvisorResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SqlServerAdvisorResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serverName, string advisorName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advisors/{advisorName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _sqlServerAdvisorServerAdvisorsClientDiagnostics;
        private readonly ServerAdvisorsRestOperations _sqlServerAdvisorServerAdvisorsRestClient;
        private readonly AdvisorData _data;

        /// <summary> Initializes a new instance of the <see cref="SqlServerAdvisorResource"/> class for mocking. </summary>
        protected SqlServerAdvisorResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SqlServerAdvisorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SqlServerAdvisorResource(ArmClient client, AdvisorData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SqlServerAdvisorResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SqlServerAdvisorResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _sqlServerAdvisorServerAdvisorsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string sqlServerAdvisorServerAdvisorsApiVersion);
            _sqlServerAdvisorServerAdvisorsRestClient = new ServerAdvisorsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, sqlServerAdvisorServerAdvisorsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/servers/advisors";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual AdvisorData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets a server advisor.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advisors/{advisorName}
        /// Operation Id: ServerAdvisors_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SqlServerAdvisorResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerAdvisorServerAdvisorsClientDiagnostics.CreateScope("SqlServerAdvisorResource.Get");
            scope.Start();
            try
            {
                var response = await _sqlServerAdvisorServerAdvisorsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerAdvisorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a server advisor.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advisors/{advisorName}
        /// Operation Id: ServerAdvisors_Get
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SqlServerAdvisorResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _sqlServerAdvisorServerAdvisorsClientDiagnostics.CreateScope("SqlServerAdvisorResource.Get");
            scope.Start();
            try
            {
                var response = _sqlServerAdvisorServerAdvisorsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SqlServerAdvisorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates a server advisor.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advisors/{advisorName}
        /// Operation Id: ServerAdvisors_Update
        /// </summary>
        /// <param name="data"> The requested advisor resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<Response<SqlServerAdvisorResource>> UpdateAsync(AdvisorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerAdvisorServerAdvisorsClientDiagnostics.CreateScope("SqlServerAdvisorResource.Update");
            scope.Start();
            try
            {
                var response = await _sqlServerAdvisorServerAdvisorsRestClient.UpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new SqlServerAdvisorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Updates a server advisor.
        /// Request Path: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/advisors/{advisorName}
        /// Operation Id: ServerAdvisors_Update
        /// </summary>
        /// <param name="data"> The requested advisor resource state. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual Response<SqlServerAdvisorResource> Update(AdvisorData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _sqlServerAdvisorServerAdvisorsClientDiagnostics.CreateScope("SqlServerAdvisorResource.Update");
            scope.Start();
            try
            {
                var response = _sqlServerAdvisorServerAdvisorsRestClient.Update(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, data, cancellationToken);
                return Response.FromValue(new SqlServerAdvisorResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
