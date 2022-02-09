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
using Azure.ResourceManager;
using Azure.ResourceManager.StackHCI;

namespace Azure.ResourceManager.StackHCI.Models
{
    /// <summary> Update Extension for HCI cluster. </summary>
    public partial class ArcExtensionUpdateOperation : Operation<ArcExtension>, IOperationSource<ArcExtension>
    {
        private readonly OperationInternals<ArcExtension> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of ArcExtensionUpdateOperation for mocking. </summary>
        protected ArcExtensionUpdateOperation()
        {
        }

        internal ArcExtensionUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ArcExtension>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.OriginalUri, "ArcExtensionUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ArcExtension Value => _operation.Value;

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
        public override ValueTask<Response<ArcExtension>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ArcExtension>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ArcExtension IOperationSource<ArcExtension>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = ArcExtensionData.DeserializeArcExtensionData(document.RootElement);
            return new ArcExtension(_armClient, data);
        }

        async ValueTask<ArcExtension> IOperationSource<ArcExtension>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = ArcExtensionData.DeserializeArcExtensionData(document.RootElement);
            return new ArcExtension(_armClient, data);
        }
    }
}
