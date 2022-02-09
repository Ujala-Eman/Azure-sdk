// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Description for Migrates a local (in-app) MySql database to a remote MySql database. </summary>
    public partial class WebSiteMigrateMySqlOperation : Operation<OperationInformation>, IOperationSource<OperationInformation>
    {
        private readonly OperationInternals<OperationInformation> _operation;

        /// <summary> Initializes a new instance of WebSiteMigrateMySqlOperation for mocking. </summary>
        protected WebSiteMigrateMySqlOperation()
        {
        }

        internal WebSiteMigrateMySqlOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<OperationInformation>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "WebSiteMigrateMySqlOperation");
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override OperationInformation Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<OperationInformation>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<OperationInformation>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        OperationInformation IOperationSource<OperationInformation>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return OperationInformation.DeserializeOperationInformation(document.RootElement);
        }

        async ValueTask<OperationInformation> IOperationSource<OperationInformation>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return OperationInformation.DeserializeOperationInformation(document.RootElement);
        }
    }
}
