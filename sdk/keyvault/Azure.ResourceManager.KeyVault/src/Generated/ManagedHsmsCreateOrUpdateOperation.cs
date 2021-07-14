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
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.KeyVault
{
    /// <summary> Create or update a managed HSM Pool in the specified subscription. </summary>
    public partial class ManagedHsmsCreateOrUpdateOperation : Operation<ManagedHsm>, IOperationSource<ManagedHsm>
    {
        private readonly OperationInternals<ManagedHsm> _operation;

        private readonly OperationsBase _operationBase;

        /// <summary> Initializes a new instance of ManagedHsmsCreateOrUpdateOperation for mocking. </summary>
        protected ManagedHsmsCreateOrUpdateOperation()
        {
        }

        internal ManagedHsmsCreateOrUpdateOperation(OperationsBase operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<ManagedHsm>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "ManagedHsmsCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override ManagedHsm Value => _operation.Value;

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
        public override ValueTask<Response<ManagedHsm>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<ManagedHsm>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        ManagedHsm IOperationSource<ManagedHsm>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new ManagedHsm(_operationBase, ManagedHsmData.DeserializeManagedHsmData(document.RootElement));
        }

        async ValueTask<ManagedHsm> IOperationSource<ManagedHsm>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new ManagedHsm(_operationBase, ManagedHsmData.DeserializeManagedHsmData(document.RootElement));
        }
    }
}
