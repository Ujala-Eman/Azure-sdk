﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace Azure
{
    /// <summary>
    /// Represents a long running operation (LRO).
    /// </summary>
    /// <typeparam name="T">The final result of the LRO.</typeparam>
    public abstract class Operation<T> where T : notnull
    {
        private T _value;
        private Response _response;

        /// <summary>
        /// Creates a new instance of the Operation representing the specified
        /// <paramref name="id"/>.
        /// </summary>
        /// <param name="id">The ID of the LRO.</param>
        protected Operation(string id)
        {
            Id = id;
        }

        /// <summary>
        /// Gets an ID representing the operation that can be used to poll for
        /// the status of the LRO.
        /// </summary>
        public string Id { get; }

        /// <summary>
        /// Final result of the LRO.
        /// </summary>
        /// <remarks>
        /// This property can be accessed only after the operation completes succesfully (HasValue is true).
        /// </remarks>
        public T Value
        {
            get
            {
#pragma warning disable CA1065 // Do not raise exceptions in unexpected locations
                if (!HasValue)
                    throw new InvalidOperationException("operation has not completed");
#pragma warning restore CA1065 // Do not raise exceptions in unexpected locations
                return _value;
            }
            protected set
            {
                _value = value;
            }
        }

        /// <summary>
        /// The last HTTP response received from the server.
        /// </summary>
        /// <remarks>
        /// The last response returned from the server during the lifecycle of this instance.
        /// An instance of Operation<typeparamref name="T"/> sends requests to a server in UpdateStatusAsync, UpdateStatus, and other methods.
        /// Responses from these requests can be accessed using GetRawResponse.
        /// </remarks>
        public Response GetRawResponse() => _response;
        protected void SetRawResponse(Response response) => _response = response;

        /// <summary>
        /// Returns true if the LRO completed.
        /// </summary>
        public abstract bool HasCompleted { get; }

        /// <summary>
        /// Returns true if the LRO completed succesfully and has produced final result (accessible by Value property).
        /// </summary>
        public abstract bool HasValue { get; }

        /// <summary>
        /// Gets or sets the value indicating default polling interval used by WaitForCompletion method.
        /// </summary>
        protected virtual TimeSpan DefaultPollingInterval { get; } = TimeSpan.FromSeconds(1);

        /// <summary>
        /// Periodically calls the server till the LRO completes.
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// This method will periodically call UpdateStatusAsync till HasCompleted is true, then return the final result of the operation.
        /// </remarks>
        public ValueTask<Response<T>> WaitForCompletionAsync()
        {
            return WaitForCompletionAsync(null, CancellationToken.None);
        }

        /// <summary>
        /// Periodically calls the server till the LRO completes.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <remarks>
        /// This method will periodically call UpdateStatusAsync till HasCompleted is true, then return the final result of the operation.
        /// </remarks>
        public ValueTask<Response<T>> WaitForCompletionAsync(CancellationToken cancellationToken)
        {
            return WaitForCompletionAsync(null, cancellationToken);
        }

        /// <summary>
        /// Periodically calls the server till the LRO completes.
        /// </summary>
        /// <param name="pollingInterval">
        /// The interval between status requests to the server.
        /// The interval can change based on information returned from the server.
        /// For example, the server might communicate to the client that there is not reason to poll for status change sooner than some time.
        /// </param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <remarks>
        /// This method will periodically call UpdateStatusAsync till HasCompleted is true, then return the final result of the operation.
        /// </remarks>
        public virtual async ValueTask<Response<T>> WaitForCompletionAsync(TimeSpan? pollingInterval, CancellationToken cancellationToken)
        {
            while (true)
            {
                await UpdateStatusAsync(cancellationToken).ConfigureAwait(false);
                if (HasCompleted)
                {
                    return Response.FromValue(Value, _response);
                }
                await Task.Delay(pollingInterval.GetValueOrDefault(), cancellationToken).ConfigureAwait(false);
            }
        }

        /// <summary>
        /// Calls the server to get updated status of the LRO.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <remarks>
        /// This operation will update the value returned from GetRawResponse and might update HasCompleted, HasValue, and Value.
        /// </remarks>
        public abstract ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Calls the server to get updated status of the LRO.
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <remarks>
        /// This operation will update the value returned from GetRawResponse and might update HasCompleted, HasValue, and Value.
        /// </remarks>
        public abstract Response UpdateStatus(CancellationToken cancellationToken = default);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => base.Equals(obj);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => base.GetHashCode();

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override string ToString() => base.ToString();
    }
}
