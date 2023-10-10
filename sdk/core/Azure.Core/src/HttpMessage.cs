﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.ServiceModel.Rest.Core;
using Azure.Core.Pipeline;

namespace Azure.Core
{
    /// <summary>
    /// Represents a context flowing through the <see cref="HttpPipeline"/>.
    /// </summary>
    public sealed class HttpMessage : PipelineMessage
    {
        private ArrayBackedPropertyBag<ulong, object> _propertyBag;

        private Response? _response;

        /// <summary>
        /// Creates a new instance of <see cref="HttpMessage"/>.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="responseClassifier">The response classifier.</param>
        public HttpMessage(Request request, ResponseClassifier responseClassifier)
            : base(request)
        {
            Argument.AssertNotNull(request, nameof(request));

            BufferResponse = true;
            _propertyBag = new ArrayBackedPropertyBag<ulong, object>();
            ResponseClassifier = responseClassifier;
        }

        /// <summary>
        /// Gets the <see cref="Request"/> associated with this message.
        /// </summary>
        public new Request Request { get => (Request)base.Request; }

        /// <summary>
        /// Gets the <see cref="Response"/> associated with this message. Throws an exception if it wasn't set yet.
        /// To avoid the exception use <see cref="HasResponse"/> property to check.
        /// </summary>
        public new Response Response
        {
            get => ResponseInternal!;
            set => ResponseInternal = value;
        }

        private Response? ResponseInternal
        {
            get
            {
                if (_response is not null)
                {
                    return _response;
                }

                if (base.Response is null)
                {
                    throw new InvalidOperationException("Response was not set, make sure SendAsync was called");
                }

                if (base.Response is not Response response)
                {
                    throw new InvalidOperationException($"Invalid response type: '{base.Response.GetType()}'.");
                }

                return response;
            }

            set => base.Response = _response = value!;
        }

        /// <summary>
        /// Gets the value indicating if the response is set on this message.
        /// </summary>
        public new bool HasResponse => _response != null || base.HasResponse;

        internal void ClearResponse() => ResponseInternal = null;

        /// <summary>
        /// The <see cref="ResponseClassifier"/> instance to use for response classification during pipeline invocation.
        /// </summary>
        public new ResponseClassifier ResponseClassifier
        {
            get => (ResponseClassifier)base.ResponseClassifier;
            set => base.ResponseClassifier = value;
        }

        internal int RetryNumber { get; set; }

        internal DateTimeOffset ProcessingStartTime { get; set; }

        /// <summary>
        /// The processing context for the message.
        /// </summary>
        public MessageProcessingContext ProcessingContext => new(this);

        internal void ApplyRequestContext(RequestContext? context, ResponseClassifier? classifier)
        {
            if (context == null)
            {
                return;
            }

            context.Freeze();

            if (context.Policies?.Count > 0)
            {
                Policies ??= new(context.Policies.Count);
                Policies.AddRange(context.Policies);
            }

            if (classifier != null)
            {
                ResponseClassifier = context.Apply(classifier);
            }
        }

        internal List<(HttpPipelinePosition Position, HttpPipelinePolicy Policy)>? Policies { get; set; }

        /// <summary>
        /// Gets a property that modifies the pipeline behavior. Please refer to individual policies documentation on what properties it supports.
        /// </summary>
        /// <param name="name">The property name.</param>
        /// <param name="value">The property value.</param>
        /// <returns><c>true</c> if property exists, otherwise. <c>false</c>.</returns>
        public bool TryGetProperty(string name, out object? value)
        {
            value = null;
            if (_propertyBag.IsEmpty || !_propertyBag.TryGetValue((ulong)typeof(MessagePropertyKey).TypeHandle.Value, out var rawValue))
            {
                return false;
            }
            var properties = (Dictionary<string, object>)rawValue!;
            return properties.TryGetValue(name, out value);
        }

        /// <summary>
        /// Sets a property that modifies the pipeline behavior. Please refer to individual policies documentation on what properties it supports.
        /// </summary>
        /// <param name="name">The property name.</param>
        /// <param name="value">The property value.</param>
        public void SetProperty(string name, object value)
        {
            Dictionary<string, object> properties;
            if (!_propertyBag.TryGetValue((ulong)typeof(MessagePropertyKey).TypeHandle.Value, out var rawValue))
            {
                properties = new Dictionary<string, object>();
                _propertyBag.Set((ulong)typeof(MessagePropertyKey).TypeHandle.Value, properties);
            }
            else
            {
                properties = (Dictionary<string, object>)rawValue!;
            }
            properties[name] = value;
        }

        /// <summary>
        /// Gets a property that is stored with this <see cref="HttpMessage"/> instance and can be used for modifying pipeline behavior.
        /// </summary>
        /// <param name="type">The property type.</param>
        /// <param name="value">The property value.</param>
        /// <remarks>
        /// The key value is of type <c>Type</c> for a couple of reasons. Primarily, it allows values to be stored such that though the accessor methods
        /// are public, storing values keyed by internal types make them inaccessible to other assemblies. This protects internal values from being overwritten
        /// by external code. See the <see cref="TelemetryDetails"/> and <see cref="UserAgentValueKey"/> types for an example of this usage. Secondly, <c>Type</c>
        /// comparisons are faster than string comparisons.
        /// </remarks>
        /// <returns><c>true</c> if property exists, otherwise. <c>false</c>.</returns>
        public bool TryGetProperty(Type type, out object? value) =>
            _propertyBag.TryGetValue((ulong)type.TypeHandle.Value, out value);

        /// <summary>
        /// Sets a property that is stored with this <see cref="HttpMessage"/> instance and can be used for modifying pipeline behavior.
        /// Internal properties can be keyed with internal types to prevent external code from overwriting these values.
        /// </summary>
        /// <param name="type">The key for the value.</param>
        /// <param name="value">The property value.</param>
        public void SetProperty(Type type, object value) =>
            _propertyBag.Set((ulong)type.TypeHandle.Value, value);

        /// <summary>
        /// Returns the response content stream and releases it ownership to the caller. After calling this methods using <see cref="PipelineResponse.ContentStream"/> or <see cref="PipelineResponse.Content"/> would result in exception.
        /// </summary>
        /// <returns>The content stream or null if response didn't have any.</returns>
        public Stream? ExtractResponseContent()
        {
            switch (ResponseInternal?.ContentStream)
            {
                case ResponseShouldNotBeUsedStream responseContent:
                    return responseContent.Original;
                case Stream stream:
                    ResponseInternal.ContentStream = new ResponseShouldNotBeUsedStream(ResponseInternal.ContentStream);
                    return stream;
                default:
                    return null;
            }
        }

        /// <summary>
        /// Disposes the request and response.
        /// </summary>
        public override void Dispose()
        {
            Request.Dispose();
            _propertyBag.Dispose();

            Response? response = _response;
            if (response != null)
            {
                response.Dispose();
                _response = null;
            }

            base.Dispose();
        }

        private class ResponseShouldNotBeUsedStream : Stream
        {
            public Stream Original { get; }

            public ResponseShouldNotBeUsedStream(Stream original)
            {
                Original = original;
            }

            private static Exception CreateException()
            {
                return new InvalidOperationException("The operation has called ExtractResponseContent and will provide the stream as part of its response type.");
            }

            public override void Flush()
            {
                throw CreateException();
            }

            public override int Read(byte[] buffer, int offset, int count)
            {
                throw CreateException();
            }

            public override long Seek(long offset, SeekOrigin origin)
            {
                throw CreateException();
            }

            public override void SetLength(long value)
            {
                throw CreateException();
            }

            public override void Write(byte[] buffer, int offset, int count)
            {
                throw CreateException();
            }

            public override bool CanRead => throw CreateException();
            public override bool CanSeek => throw CreateException();
            public override bool CanWrite => throw CreateException();
            public override long Length => throw CreateException();

            public override long Position
            {
                get => throw CreateException();
                set => throw CreateException();
            }
        }

        /// <summary>
        /// Exists as a private key entry into the <see cref="_propertyBag"/> dictionary for stashing string keyed entries in the Type keyed dictionary.
        /// </summary>
        private class MessagePropertyKey { }
    }
}
