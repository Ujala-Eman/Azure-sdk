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
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Create or update an Azure Cosmos DB SQL userDefinedFunction. </summary>
    public partial class SqlUserDefinedFunctionCreateOrUpdateOperation : Operation<SqlUserDefinedFunction>, IOperationSource<SqlUserDefinedFunction>
    {
        private readonly OperationInternals<SqlUserDefinedFunction> _operation;

        private readonly ArmClient _armClient;

        /// <summary> Initializes a new instance of SqlUserDefinedFunctionCreateOrUpdateOperation for mocking. </summary>
        protected SqlUserDefinedFunctionCreateOrUpdateOperation()
        {
        }

        internal SqlUserDefinedFunctionCreateOrUpdateOperation(ArmClient armClient, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<SqlUserDefinedFunction>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "SqlUserDefinedFunctionCreateOrUpdateOperation");
            _armClient = armClient;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SqlUserDefinedFunction Value => _operation.Value;

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
        public override ValueTask<Response<SqlUserDefinedFunction>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SqlUserDefinedFunction>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        SqlUserDefinedFunction IOperationSource<SqlUserDefinedFunction>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SqlUserDefinedFunctionData.DeserializeSqlUserDefinedFunctionData(document.RootElement);
            return new SqlUserDefinedFunction(_armClient, data);
        }

        async ValueTask<SqlUserDefinedFunction> IOperationSource<SqlUserDefinedFunction>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SqlUserDefinedFunctionData.DeserializeSqlUserDefinedFunctionData(document.RootElement);
            return new SqlUserDefinedFunction(_armClient, data);
        }
    }
}
