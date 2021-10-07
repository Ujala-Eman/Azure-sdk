﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure.AI.FormRecognizer.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.AI.FormRecognizer.Training
{
    /// <summary>
    /// Tracks the status of a long-running operation for creating a custom model.
    /// </summary>
    public class CreateCustomFormModelOperation : Operation<CustomFormModel>, IOperation<CustomFormModel>
    {
        private readonly OperationInternal<CustomFormModel> _operationInternal;

        /// <summary>Provides communication with the Form Recognizer Azure Cognitive Service through its REST API.</summary>
        private readonly FormRecognizerRestClient _serviceClient;

        /// <summary>Provides tools for exception creation in case of failure.</summary>
        private readonly ClientDiagnostics _diagnostics;

        /// <summary>Service version used in this client.</summary>
        private readonly FormRecognizerClientOptions.ServiceVersion _serviceVersion;

        /// <summary>
        /// Gets operation Id that can be used to poll for the status
        /// of the long-running operation.
        /// </summary>
        public override string Id { get; }

        /// <summary>
        /// Final result of the long-running operation.
        /// </summary>
        /// <remarks>
        /// This property can be accessed only after the operation completes successfully (HasValue is true).
        /// </remarks>
        public override CustomFormModel Value => _operationInternal.Value;

        /// <summary>
        /// Returns true if the long-running operation completed.
        /// </summary>
        public override bool HasCompleted => _operationInternal.HasCompleted;

        /// <summary>
        /// Returns true if the long-running operation completed successfully and has produced final result (accessible by Value property).
        /// </summary>
        public override bool HasValue => _operationInternal.HasValue;

        /// <summary>
        /// The last HTTP response received from the server.
        /// </summary>
        /// <remarks>
        /// The last response returned from the server during the lifecycle of this instance.
        /// An instance of <see cref="CreateCustomFormModelOperation"/> sends requests to a server in UpdateStatusAsync, UpdateStatus, and other methods.
        /// Responses from these requests can be accessed using GetRawResponse.
        /// </remarks>
        public override Response GetRawResponse() => _operationInternal.RawResponse;

        /// <summary>
        /// Periodically calls the server till the long-running operation completes.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used for the periodical service calls.</param>
        /// <returns>The last HTTP response received from the server.</returns>
        /// <remarks>
        /// This method will periodically call UpdateStatusAsync till HasCompleted is true, then return the final result of the operation.
        /// </remarks>
        public override async ValueTask<Response<CustomFormModel>> WaitForCompletionAsync(CancellationToken cancellationToken = default) =>
            await _operationInternal.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);

        /// <summary>
        /// Periodically calls the server till the long-running operation completes.
        /// </summary>
        /// <param name="pollingInterval">
        /// The interval between status requests to the server.
        /// The interval can change based on information returned from the server.
        /// For example, the server might communicate to the client that there is not reason to poll for status change sooner than some time.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used for the periodical service calls.</param>
        /// <returns>The last HTTP response received from the server.</returns>
        /// <remarks>
        /// This method will periodically call UpdateStatusAsync till HasCompleted is true, then return the final result of the operation.
        /// </remarks>
        public override async ValueTask<Response<CustomFormModel>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) =>
            await _operationInternal.WaitForCompletionAsync(pollingInterval, cancellationToken).ConfigureAwait(false);

        internal CreateCustomFormModelOperation(
            string location,
            FormRecognizerRestClient allOperations,
            ClientDiagnostics diagnostics,
            FormRecognizerClientOptions.ServiceVersion serviceVersion)
        {
            _serviceClient = allOperations;
            _diagnostics = diagnostics;
            _serviceVersion = serviceVersion;
            _operationInternal = new(_diagnostics, this, rawResponse: null, nameof(CreateCustomFormModelOperation));

            Id = location.Split('/').Last();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomFormModelOperation"/> class which
        /// tracks the status of a long-running operation for creating a custom model.
        /// </summary>
        /// <param name="operationId">The ID of this operation.</param>
        /// <param name="client">The client used to check for completion.</param>
        public CreateCustomFormModelOperation(string operationId, FormTrainingClient client)
        {
            Argument.AssertNotNull(client, nameof(client));

            Id = operationId;
            _diagnostics = client.Diagnostics;
            _serviceClient = client.ServiceClient;
            _serviceVersion = client.ServiceVersion;
            _operationInternal = new(_diagnostics, this, rawResponse: null, nameof(CreateCustomFormModelOperation));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomFormModelOperation"/> class. This constructor
        /// is intended to be used for mocking only.
        /// </summary>
        protected CreateCustomFormModelOperation()
        {
        }

        /// <summary>
        /// Calls the server to get updated status of the long-running operation.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used for the service call.</param>
        /// <returns>The HTTP response received from the server.</returns>
        /// <remarks>
        /// This operation will update the value returned from GetRawResponse and might update HasCompleted, HasValue, and Value.
        /// </remarks>
        public override Response UpdateStatus(CancellationToken cancellationToken = default) =>
            _operationInternal.UpdateStatus(cancellationToken);

        /// <summary>
        /// Calls the server to get updated status of the long-running operation.
        /// </summary>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> used for the service call.</param>
        /// <returns>The HTTP response received from the server.</returns>
        /// <remarks>
        /// This operation will update the value returned from GetRawResponse and might update HasCompleted, HasValue, and Value.
        /// </remarks>
        public override async ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) =>
            await _operationInternal.UpdateStatusAsync(cancellationToken).ConfigureAwait(false);

        async ValueTask<OperationState<CustomFormModel>> IOperation<CustomFormModel>.UpdateStateAsync(bool async, CancellationToken cancellationToken)
        {
            // Include keys is always set to true -- the service does not have a use case for includeKeys: false.
            Response<Model> response = async
                ? await _serviceClient.GetCustomModelAsync(new Guid(Id), includeKeys: true, cancellationToken).ConfigureAwait(false)
                : _serviceClient.GetCustomModel(new Guid(Id), includeKeys: true, cancellationToken);

            CustomFormModelStatus status = response.Value.ModelInfo.Status;
            Response rawResponse = response.GetRawResponse();

            if (status == CustomFormModelStatus.Ready)
            {
                return OperationState<CustomFormModel>.Success(rawResponse, new CustomFormModel(response.Value, _serviceVersion));
            }
            else if (status == CustomFormModelStatus.Invalid)
            {
                RequestFailedException requestFailedException = await ClientCommon.CreateExceptionForFailedOperationAsync(
                                                                      async,
                                                                      _diagnostics,
                                                                      rawResponse,
                                                                      response.Value.TrainResult.Errors,
                                                                      $"Invalid model created with ID {response.Value.ModelInfo.ModelId}").ConfigureAwait(false);

                return OperationState<CustomFormModel>.Failure(rawResponse, requestFailedException);
            }

            return OperationState<CustomFormModel>.Pending(rawResponse);
        }
    }
}
