// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.AppService
{
    /// <summary> A class representing collection of SourceControl and their operations over its parent. </summary>
    public partial class SourceControlCollection : ArmCollection, IEnumerable<SourceControl>, IAsyncEnumerable<SourceControl>
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WebSiteManagementRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="SourceControlCollection"/> class for mocking. </summary>
        protected SourceControlCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SourceControlCollection"/> class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal SourceControlCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new WebSiteManagementRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != Tenant.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, Tenant.ResourceType), nameof(id));
        }

        // Collection level operations.

        /// RequestPath: /providers/Microsoft.Web/sourcecontrols/{sourceControlType}
        /// ContextualPath: /
        /// OperationId: UpdateSourceControl
        /// <summary> Description for Updates source control token. </summary>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="requestMessage"> Source control token information. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> or <paramref name="requestMessage"/> is null. </exception>
        public virtual WebSiteManagementUpdateSourceControlOperation CreateOrUpdate(bool waitForCompletion, string sourceControlType, SourceControlData requestMessage, CancellationToken cancellationToken = default)
        {
            if (sourceControlType == null)
            {
                throw new ArgumentNullException(nameof(sourceControlType));
            }
            if (requestMessage == null)
            {
                throw new ArgumentNullException(nameof(requestMessage));
            }

            using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.UpdateSourceControl(sourceControlType, requestMessage, cancellationToken);
                var operation = new WebSiteManagementUpdateSourceControlOperation(Parent, response);
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

        /// RequestPath: /providers/Microsoft.Web/sourcecontrols/{sourceControlType}
        /// ContextualPath: /
        /// OperationId: UpdateSourceControl
        /// <summary> Description for Updates source control token. </summary>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="requestMessage"> Source control token information. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> or <paramref name="requestMessage"/> is null. </exception>
        public async virtual Task<WebSiteManagementUpdateSourceControlOperation> CreateOrUpdateAsync(bool waitForCompletion, string sourceControlType, SourceControlData requestMessage, CancellationToken cancellationToken = default)
        {
            if (sourceControlType == null)
            {
                throw new ArgumentNullException(nameof(sourceControlType));
            }
            if (requestMessage == null)
            {
                throw new ArgumentNullException(nameof(requestMessage));
            }

            using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.UpdateSourceControlAsync(sourceControlType, requestMessage, cancellationToken).ConfigureAwait(false);
                var operation = new WebSiteManagementUpdateSourceControlOperation(Parent, response);
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

        /// RequestPath: /providers/Microsoft.Web/sourcecontrols/{sourceControlType}
        /// ContextualPath: /
        /// OperationId: GetSourceControl
        /// <summary> Description for Gets source control token. </summary>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> is null. </exception>
        public virtual Response<SourceControl> Get(string sourceControlType, CancellationToken cancellationToken = default)
        {
            if (sourceControlType == null)
            {
                throw new ArgumentNullException(nameof(sourceControlType));
            }

            using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.Get");
            scope.Start();
            try
            {
                var response = _restClient.GetSourceControl(sourceControlType, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SourceControl(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Web/sourcecontrols/{sourceControlType}
        /// ContextualPath: /
        /// OperationId: GetSourceControl
        /// <summary> Description for Gets source control token. </summary>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> is null. </exception>
        public async virtual Task<Response<SourceControl>> GetAsync(string sourceControlType, CancellationToken cancellationToken = default)
        {
            if (sourceControlType == null)
            {
                throw new ArgumentNullException(nameof(sourceControlType));
            }

            using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.Get");
            scope.Start();
            try
            {
                var response = await _restClient.GetSourceControlAsync(sourceControlType, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new SourceControl(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> is null. </exception>
        public virtual Response<SourceControl> GetIfExists(string sourceControlType, CancellationToken cancellationToken = default)
        {
            if (sourceControlType == null)
            {
                throw new ArgumentNullException(nameof(sourceControlType));
            }

            using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _restClient.GetSourceControl(sourceControlType, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return Response.FromValue<SourceControl>(null, response.GetRawResponse());
                return Response.FromValue(new SourceControl(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> is null. </exception>
        public async virtual Task<Response<SourceControl>> GetIfExistsAsync(string sourceControlType, CancellationToken cancellationToken = default)
        {
            if (sourceControlType == null)
            {
                throw new ArgumentNullException(nameof(sourceControlType));
            }

            using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _restClient.GetSourceControlAsync(sourceControlType, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return Response.FromValue<SourceControl>(null, response.GetRawResponse());
                return Response.FromValue(new SourceControl(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> is null. </exception>
        public virtual Response<bool> Exists(string sourceControlType, CancellationToken cancellationToken = default)
        {
            if (sourceControlType == null)
            {
                throw new ArgumentNullException(nameof(sourceControlType));
            }

            using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(sourceControlType, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="sourceControlType"> Type of source control. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceControlType"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string sourceControlType, CancellationToken cancellationToken = default)
        {
            if (sourceControlType == null)
            {
                throw new ArgumentNullException(nameof(sourceControlType));
            }

            using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.Exists");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(sourceControlType, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /providers/Microsoft.Web/sourcecontrols
        /// ContextualPath: /
        /// OperationId: ListSourceControls
        /// <summary> Description for Gets the source controls available for Azure websites. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SourceControl" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SourceControl> GetAll(CancellationToken cancellationToken = default)
        {
            Page<SourceControl> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.ListSourceControls(cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SourceControl(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<SourceControl> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.ListSourceControlsNextPage(nextLink, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new SourceControl(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /providers/Microsoft.Web/sourcecontrols
        /// ContextualPath: /
        /// OperationId: ListSourceControls
        /// <summary> Description for Gets the source controls available for Azure websites. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SourceControl" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SourceControl> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<SourceControl>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.ListSourceControlsAsync(cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SourceControl(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<SourceControl>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("SourceControlCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.ListSourceControlsNextPageAsync(nextLink, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new SourceControl(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<SourceControl> IEnumerable<SourceControl>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SourceControl> IAsyncEnumerable<SourceControl>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, SourceControl, SourceControlData> Construct() { }
    }
}
