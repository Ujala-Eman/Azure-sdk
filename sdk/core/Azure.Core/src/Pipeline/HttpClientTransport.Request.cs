﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.ServiceModel.Rest.Core;
using System.ServiceModel.Rest.Core.Pipeline;

namespace Azure.Core.Pipeline
{
    /// <summary>
    /// An <see cref="HttpPipelineTransport"/> implementation that uses <see cref="HttpClient"/> as the transport.
    /// </summary>
    public partial class HttpClientTransport : HttpPipelineTransport, IDisposable
    {
        internal static bool TryGetPipelineRequest(Request request, out PipelineRequest? pipelineRequest)
        {
            if (request is RequestAdapter requestAdapter)
            {
                pipelineRequest = requestAdapter.PipelineRequest;
                return true;
            }

            pipelineRequest = null;
            return false;
        }

        private sealed class HttpClientTransportRequest : HttpPipelineRequest
        {
            private RequestUriBuilder? _uriBuilder;

            public override Uri Uri
            {
                get
                {
                    if (_uriBuilder is null)
                    {
                        throw new InvalidOperationException("RequestUriBuilder has not been initialized; please call SetUriBuilder()");
                    }

                    return _uriBuilder.ToUri();
                }
                set
                {
                    if (_uriBuilder is null)
                    {
                        throw new InvalidOperationException("RequestUriBuilder has not been initialized; please call SetUriBuilder()");
                    }

                    _uriBuilder.Reset(value);
                }
            }

            public RequestUriBuilder UriBuilder
            {
                get => _uriBuilder ??= new RequestUriBuilder();
                set
                {
                    Argument.AssertNotNull(value, nameof(value));
                    _uriBuilder = value;
                }
            }

            private const string MessageForServerCertificateCallback = "MessageForServerCertificateCallback";

            internal static void AddAzureProperties(HttpMessage message, HttpRequestMessage httpRequest)
            {
                SetPropertiesOrOptions(httpRequest, MessageForServerCertificateCallback, message);

                AddPropertiesForBlazor(httpRequest);
            }

            private static void AddPropertiesForBlazor(HttpRequestMessage currentRequest)
            {
                // Disable response caching and enable streaming in Blazor apps
                // see https://github.com/dotnet/aspnetcore/blob/3143d9550014006080bb0def5b5c96608b025a13/src/Components/WebAssembly/WebAssembly/src/Http/WebAssemblyHttpRequestMessageExtensions.cs
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Create("BROWSER")))
                {
                    SetPropertiesOrOptions(currentRequest, "WebAssemblyFetchOptions", new Dictionary<string, object> { { "cache", "no-store" } });
                    SetPropertiesOrOptions(currentRequest, "WebAssemblyEnableStreamingResponse", true);
                }
            }

            private static void SetPropertiesOrOptions<T>(HttpRequestMessage httpRequest, string name, T value)
            {
#if NET5_0_OR_GREATER
                httpRequest.Options.Set(new HttpRequestOptionsKey<T>(name), value);
#else
                httpRequest.Properties[name] = value;
#endif
            }
        }

        private class RequestAdapter : Request
        {
            private readonly HttpClientTransportRequest _request;

            public RequestAdapter(HttpClientTransportRequest request)
            {
                _request = request;
            }

            internal PipelineRequest PipelineRequest => _request;

            public override RequestMethod Method
            {
                get => RequestMethod.Parse(_request.Method);
                set => _request.Method = value.Method;
            }

            public override RequestUriBuilder Uri
            {
                get => _request.UriBuilder;
                set => _request.UriBuilder = value;
            }

            public override RequestContent? Content
            {
                get => (RequestContent?)_request.Content;
                set => _request.Content = value;
            }

            public override void Dispose() => _request.Dispose();

            protected internal override void AddHeader(string name, string value)
                => _request.Headers.Add(name, value);

            protected internal override bool ContainsHeader(string name)
                => _request.Headers.TryGetHeader(name, out _);

            protected internal override IEnumerable<HttpHeader> EnumerateHeaders()
            {
                _request.Headers.TryGetHeaders(out IEnumerable<MessageHeader<string, object>> headers);
                foreach (var header in headers)
                {
                    yield return new HttpHeader(header.Name, GetHeaderValueString(header.Name, header.Value));
                }
            }

            // TODO: avoid copying this?
            private static string GetHeaderValueString(string name, object value) => value switch
            {
                string s => s,
                List<string> l => string.Join(",", l),
                _ => throw new InvalidOperationException($"Unexpected type for header {name}: {value?.GetType()}")
            };

            protected internal override bool RemoveHeader(string name)
                => _request.Headers.Remove(name);

            protected internal override bool TryGetHeader(string name, [NotNullWhen(true)] out string? value)
                => _request.Headers.TryGetHeader(name, out value);

            protected internal override bool TryGetHeaderValues(string name, [NotNullWhen(true)] out IEnumerable<string>? values)
            {
                // TODO: we can optimize this, come back to it
                _request.Headers.TryGetHeaders(out IEnumerable<MessageHeader<string, object>> headers);

                var header = headers.Where(h => h.Name == name);
                if (header == null || !header.Any())
                {
                    values = null;
                    return false;
                }

                values = header.First().Value switch
                {
                    string s => new string[] { s },
                    List<string> l => l,
                    _ => throw new InvalidOperationException($"Unexpected type for header {name}: {header.First().Value?.GetType()}")
                };
                return true;
            }
        }
    }
}
