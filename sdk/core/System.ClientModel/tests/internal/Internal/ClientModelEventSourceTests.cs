﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ClientModel.Internal;
using System.ClientModel.Options;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using ClientModel.Tests.Mocks;
using ClientModel.Tests;
using NUnit.Framework;
using System.IO;

namespace System.ClientModel.Tests.Internal
{
    // Avoid running these tests in parallel with anything else that's sharing the event source
    [NonParallelizable]
    public class ClientModelEventSourceTests : SyncAsyncPolicyTestBase
    {
        private const int BackgroundRefreshFailedEvent = 19;
        private const int RequestEvent = 1;
        private const int RequestContentEvent = 2;
        private const int RequestContentTextEvent = 17;
        private const int ResponseEvent = 5;
        private const int ResponseContentEvent = 6;
        private const int ResponseContentBlockEvent = 11;
        private const int ErrorResponseEvent = 8;
        private const int ErrorResponseContentEvent = 9;
        private const int ErrorResponseContentBlockEvent = 12;
        private const int ResponseContentTextEvent = 13;
        private const int ResponseContentTextBlockEvent = 15;
        private const int ErrorResponseContentTextEvent = 14;
        private const int ErrorResponseContentTextBlockEvent = 16;
        private const int ExceptionResponseEvent = 18;

        private TestClientEventListener _listener;

        private static readonly string[] s_allowedHeaders = new[] { "Date", "Custom-Header", "Custom-Response-Header" };
        private static readonly string[] s_allowedQueryParameters = new[] { "api-version" };
        private const string SystemClientModelEventSourceName = "System.ClientModel";
        private const string AzureCoreEventSourceName = "Azure-Core";
        private const string ClientRequestIdHeaderName = "Client-Id";

        public ClientModelEventSourceTests(bool isAsync) : base(isAsync)
        {
            _listener = new TestClientEventListener();
        }

        [SetUp]
        public void Setup()
        {
            _listener = new TestClientEventListener();
        }

        [TearDown]
        public void TearDown()
        {
            _listener?.Dispose();
        }

        [Test]
        public async Task LogsAreNotWrittenWhenTheSourceDoesNotHaveAnyListeners()
        {
            var response = new MockPipelineResponse(200);
            response.SetContent("Hello");

            var loggingOptions = new LoggingOptions
            {
                IsLoggingEnabled = true,
                IsLoggingContentEnabled = true,
                LoggedHeaderNames = s_allowedHeaders
            };

            ClientPipelineOptions options = new()
            {
                Transport = new MockPipelineTransport("Transport", i => response),
                LoggingPolicy = new NotEnabledLoggingPolicy(loggingOptions)
            };

            ClientPipeline pipeline = ClientPipeline.Create(options);

            PipelineMessage message = pipeline.CreateMessage();
            message.Request.Uri = new Uri("http://example.com");
            message.Request.Content = BinaryContent.Create(new BinaryData("Hello"));

            await pipeline.SendSyncOrAsync(message, IsAsync);

            IEnumerable<EventWrittenEventArgs> args = _listener.EventData;
            Assert.AreEqual(0, args.Count());
        }

        [Test]
        public async Task SourceCanWriteToCustomName()
        {
            string requestContent = "This is a request.";
            string responseContent = "This is a response.";
            string clientIdHeaderName = "x-ms-request-client-id";
            string clientId = "client-123456789";
            string clientAssemblyName = "Test-Azure-SDK";

            var headers = new MockResponseHeaders(new Dictionary<string, string> { { clientIdHeaderName, clientId } });
            var response = new MockPipelineResponse(200, mockHeaders: headers);
            response.SetContent(responseContent);
            var loggingOptions = new LoggingOptions
            {
                IsLoggingEnabled = true,
                IsLoggingContentEnabled = true,
                LoggedHeaderNames = new List<string> { clientIdHeaderName },
                LoggedClientAssemblyName = clientAssemblyName,
                RequestIdHeaderName = clientIdHeaderName
            };

            ClientPipelineOptions options = new()
            {
                Transport = new MockPipelineTransport("Transport", i => response),
                LoggingPolicy = new AzureCoreLoggingPolicy(loggingOptions)
            };

            ClientPipeline pipeline = ClientPipeline.Create(options);

            PipelineMessage message = pipeline.CreateMessage();
            message.Request.Uri = new Uri("http://example.com");
            message.Request.Headers.Add(clientIdHeaderName, clientId);
            message.Request.Content = BinaryContent.Create(new BinaryData(requestContent));

            await pipeline.SendSyncOrAsync(message, IsAsync);

            EventWrittenEventArgs args = _listener.SingleEventById(RequestEvent);
            Assert.AreEqual(EventLevel.Informational, args.Level);
            Assert.AreEqual(AzureCoreEventSourceName, args.EventSource.Name);
            Assert.AreEqual("Request", args.EventName);
            Assert.AreEqual(clientId, args.GetProperty<string>("requestId"));
            Assert.AreEqual("http://example.com/", args.GetProperty<string>("uri"));
            Assert.AreEqual("GET", args.GetProperty<string>("method"));
            Assert.AreEqual(clientAssemblyName, args.GetProperty<string>("clientAssembly"));

            args = _listener.SingleEventById(RequestContentEvent);
            Assert.AreEqual(AzureCoreEventSourceName, args.EventSource.Name);
            Assert.AreEqual(EventLevel.Verbose, args.Level);
            Assert.AreEqual("RequestContent", args.EventName);
            Assert.AreEqual(clientId, args.GetProperty<string>("requestId"));
            CollectionAssert.AreEqual("This is a request.", args.GetProperty<byte[]>("content"));

            args = _listener.SingleEventById(ResponseEvent);
            Assert.AreEqual(AzureCoreEventSourceName, args.EventSource.Name);
            Assert.AreEqual(EventLevel.Informational, args.Level);
            Assert.AreEqual("Response", args.EventName);
            Assert.AreEqual(clientId, args.GetProperty<string>("requestId"));
            Assert.AreEqual(args.GetProperty<int>("status"), 200);

            args = _listener.SingleEventById(ResponseContentEvent);
            Assert.AreEqual(AzureCoreEventSourceName, args.EventSource.Name);
            Assert.AreEqual(EventLevel.Verbose, args.Level);
            Assert.AreEqual("ResponseContent", args.EventName);
            Assert.AreEqual(clientId, args.GetProperty<string>("requestId"));
            CollectionAssert.AreEqual(responseContent, args.GetProperty<byte[]>("content"));
        }

        [Test]
        public async Task SendingRequestProducesEvents()
        {
            string requestContent = "Hello";
            string responseContent = "World";
            string clientId = "client1";

            var headers = new MockResponseHeaders(new Dictionary<string, string> { { "Custom-Response-Header", "Value" } });
            var response = new MockPipelineResponse(200, mockHeaders: headers);
            response.SetContent(responseContent);

            ClientPipelineOptions options = new()
            {
                Transport = new MockPipelineTransport("Transport", i => response),
                LoggingOptions = new LoggingOptions
                {
                    IsLoggingEnabled = true,
                    IsLoggingContentEnabled = true,
                    LoggedHeaderNames = s_allowedHeaders,
                    LoggedClientAssemblyName = "Test-SDK",
                    RequestIdHeaderName = ClientRequestIdHeaderName
                }
            };

            ClientPipeline pipeline = ClientPipeline.Create(options);

            PipelineMessage message = pipeline.CreateMessage();
            message.Request.Method = "GET";
            message.Request.Uri = new Uri("http://example.com");
            message.Request.Headers.Add("Custom-Header", "Value");
            message.Request.Headers.Add(ClientRequestIdHeaderName, clientId);
            message.Request.Headers.Add("Date", "3/28/2024");
            message.Request.Content= BinaryContent.Create(new BinaryData(requestContent));

            await pipeline.SendSyncOrAsync(message, IsAsync);

            EventWrittenEventArgs args = _listener.SingleEventById(RequestEvent);
            Assert.AreEqual(EventLevel.Informational, args.Level);
            Assert.AreEqual(SystemClientModelEventSourceName, args.EventSource.Name);
            Assert.AreEqual("Request", args.EventName);
            Assert.AreEqual(clientId, args.GetProperty<string>("requestId"));
            Assert.AreEqual("http://example.com/", args.GetProperty<string>("uri"));
            Assert.AreEqual("GET", args.GetProperty<string>("method"));
            StringAssert.Contains($"Date:3/28/2024{Environment.NewLine}", args.GetProperty<string>("headers"));
            StringAssert.Contains($"Custom-Header:Value{Environment.NewLine}", args.GetProperty<string>("headers"));
            Assert.AreEqual("Test-SDK", args.GetProperty<string>("clientAssembly"));

            args = _listener.SingleEventById(RequestContentEvent);
            Assert.AreEqual(EventLevel.Verbose, args.Level);
            Assert.AreEqual(SystemClientModelEventSourceName, args.EventSource.Name);
            Assert.AreEqual("RequestContent", args.EventName);
            Assert.AreEqual(clientId, args.GetProperty<string>("requestId"));
            CollectionAssert.AreEqual(requestContent, args.GetProperty<byte[]>("content"));

            args = _listener.SingleEventById(ResponseEvent);
            Assert.AreEqual(EventLevel.Informational, args.Level);
            Assert.AreEqual(SystemClientModelEventSourceName, args.EventSource.Name);
            Assert.AreEqual("Response", args.EventName);
            Assert.AreEqual(clientId, args.GetProperty<string>("requestId"));
            Assert.AreEqual(args.GetProperty<int>("status"), 200);
            StringAssert.Contains($"Custom-Response-Header:Value{Environment.NewLine}", args.GetProperty<string>("headers"));

            args = _listener.SingleEventById(ResponseContentEvent);
            Assert.AreEqual(EventLevel.Verbose, args.Level);
            Assert.AreEqual(SystemClientModelEventSourceName, args.EventSource.Name);
            Assert.AreEqual("ResponseContent", args.EventName);
            Assert.AreEqual(clientId, args.GetProperty<string>("requestId"));
            CollectionAssert.AreEqual(responseContent, args.GetProperty<byte[]>("content"));
        }

        [Test]
        public void GettingExceptionResponseProducesEvents()
        {
            string clientId = "client1";

            var exception = new InvalidOperationException();
            ClientPipelineOptions options = new()
            {
                Transport = new MockPipelineTransport("Transport", (PipelineMessage i) => throw exception),
                LoggingOptions = new LoggingOptions
                {
                    IsLoggingEnabled = true,
                    IsLoggingContentEnabled = true,
                    LoggedHeaderNames = s_allowedHeaders,
                    LoggedClientAssemblyName = "Test-SDK",
                    RequestIdHeaderName = ClientRequestIdHeaderName
                }
            };

            ClientPipeline pipeline = ClientPipeline.Create(options);

            PipelineMessage message = pipeline.CreateMessage();
            message.Request.Method = "GET";
            message.Request.Uri = new Uri("http://example.com");
            message.Request.Headers.Add("User-Agent", "agent");
            message.Request.Headers.Add(ClientRequestIdHeaderName, clientId);

            Assert.ThrowsAsync<InvalidOperationException>(async () => await pipeline.SendSyncOrAsync(message, IsAsync));

            EventWrittenEventArgs e = _listener.SingleEventById(ExceptionResponseEvent);
            Assert.AreEqual(SystemClientModelEventSourceName, e.EventSource.Name);
            Assert.AreEqual(EventLevel.Informational, e.Level);
            Assert.AreEqual(clientId, e.GetProperty<string>("requestId"));
            Assert.AreEqual(exception.ToString().Split(Environment.NewLine.ToCharArray())[0],
                e.GetProperty<string>("exception").Split(Environment.NewLine.ToCharArray())[0]);
        }

        [Test]
        public void FailingAccessTokenBackgroundRefreshProducesEvents()
        {
            // TODO
            //var credentialMre = new ManualResetEventSlim(true);

            //var currentTime = DateTimeOffset.UtcNow;
            //var callCount = 0;
            //var exception = new InvalidOperationException();

            //var credential = new TokenCredentialStub((r, c) =>
            //{
            //    callCount++;
            //    credentialMre.Set();
            //    return callCount == 1 ? new AccessToken(Guid.NewGuid().ToString(), currentTime.AddMinutes(2)) : throw exception;
            //}, IsAsync);

            //var policy = new BearerTokenAuthenticationPolicy(credential, "scope");
            //MockTransport mockTransport = CreateMockTransport(r =>
            //{
            //    credentialMre.Wait();
            //    return new MockResponse(200);
            //});

            //var pipeline = new HttpPipeline(mockTransport, new HttpPipelinePolicy[] { policy, new LoggingPolicy(logContent: true, int.MaxValue, _sanitizer, "Test-SDK") });
            //await SendRequestAsync(pipeline, request =>
            //{
            //    request.Method = RequestMethod.Get;
            //    request.Uri.Reset(new Uri("https://example.com/1"));
            //    request.Headers.Add("User-Agent", "agent");
            //});

            //credentialMre.Reset();
            //string requestId = null;
            //await SendRequestAsync(pipeline, request =>
            //{
            //    request.Method = RequestMethod.Get;
            //    request.Uri.Reset(new Uri("https://example.com/2"));
            //    request.Headers.Add("User-Agent", "agent");
            //    requestId = request.ClientRequestId;
            //});

            //await Task.Delay(1_000);

            //EventWrittenEventArgs e = _listener.SingleEventById(BackgroundRefreshFailedEvent);
            //Assert.AreEqual(EventLevel.Informational, e.Level);
            //Assert.AreEqual(requestId, e.GetProperty<string>("requestId"));
            //Assert.AreEqual(exception.ToString().Split(Environment.NewLine.ToCharArray())[0], e.GetProperty<string>("exception").Split(Environment.NewLine.ToCharArray())[0]);
        }

        [Test]
        public async Task GettingErrorResponseProducesEvents()
        {
            byte[] requestContent = new byte[] { 1, 2, 3, 4, 5 };
            byte[] responseContent = new byte[] { 6, 7, 8, 9, 0 };
            string clientId = "client1";

            var headers = new MockResponseHeaders(new Dictionary<string, string> { { "Custom-Response-Header", "Value - 2" } });
            var response = new MockPipelineResponse(500, mockHeaders: headers);
            response.SetContent(responseContent);

            ClientPipelineOptions options = new()
            {
                Transport = new MockPipelineTransport("Transport", i => response),
                RetryPolicy = new ObservablePolicy("RetryPolicy"),
                LoggingOptions = new LoggingOptions
                {
                    IsLoggingContentEnabled = true,
                    LoggedContentSizeLimit = int.MaxValue,
                    LoggedClientAssemblyName = "Test-SDK",
                    RequestIdHeaderName = ClientRequestIdHeaderName,
                    LoggedHeaderNames = s_allowedHeaders
                }
            };

            ClientPipeline pipeline = ClientPipeline.Create(options);

            PipelineMessage message = pipeline.CreateMessage();
            message.Request.Method = "GET";
            message.Request.Uri = new Uri("http://example.com");
            message.Request.Headers.Add("Custom-Header", "Value");
            message.Request.Headers.Add(clientId, clientId);
            message.Request.Headers.Add("Date", "3/28/2024");
            message.Request.Content = BinaryContent.Create(new BinaryData(new byte[] { 1, 2, 3, 4, 5 }));
            message.Request.Headers.Add(ClientRequestIdHeaderName, clientId);

            await pipeline.SendSyncOrAsync(message, IsAsync);

            EventWrittenEventArgs e = _listener.SingleEventById(ErrorResponseEvent);
            Assert.AreEqual(SystemClientModelEventSourceName, e.EventSource.Name);
            Assert.AreEqual(EventLevel.Warning, e.Level);
            Assert.AreEqual("ErrorResponse", e.EventName);
            Assert.AreEqual(clientId, e.GetProperty<string>("requestId"));
            Assert.AreEqual(e.GetProperty<int>("status"), 500);
            StringAssert.Contains($"Custom-Response-Header:Value - 2{Environment.NewLine}", e.GetProperty<string>("headers"));

            e = _listener.SingleEventById(ErrorResponseContentEvent);
            Assert.AreEqual(SystemClientModelEventSourceName, e.EventSource.Name);
            Assert.AreEqual(EventLevel.Informational, e.Level);
            Assert.AreEqual("ErrorResponseContent", e.EventName);
            Assert.AreEqual(clientId, e.GetProperty<string>("requestId"));
            CollectionAssert.AreEqual(responseContent, e.GetProperty<byte[]>("content"));
        }

        [Test]
        public async Task RequestContentIsLoggedAsText()
        {
            string clientId = "client1";
            string requestContent = "Hello world";

            var response = new MockPipelineResponse(500);

            ClientPipelineOptions options = new()
            {
                Transport = new MockPipelineTransport("Transport", i => response),
                RetryPolicy = new ObservablePolicy("RetryPolicy"),
                LoggingOptions = new LoggingOptions
                {
                    IsLoggingContentEnabled = true,
                    LoggedContentSizeLimit = int.MaxValue,
                    LoggedClientAssemblyName = "Test-SDK",
                    RequestIdHeaderName = ClientRequestIdHeaderName,
                    LoggedHeaderNames = s_allowedHeaders
                }
            };

            ClientPipeline pipeline = ClientPipeline.Create(options);

            PipelineMessage message = pipeline.CreateMessage();
            message.Request.Method = "GET";
            message.Request.Uri = new Uri("http://example.com");
            message.Request.Headers.Add("Custom-Header", "Value");
            message.Request.Headers.Add(ClientRequestIdHeaderName, clientId);
            message.Request.Headers.Add("Date", "3/28/2024");
            message.Request.Headers.Add("Content-Type", "text/json");
            message.Request.Content = BinaryContent.Create(new BinaryData(Encoding.UTF8.GetBytes(requestContent)));

            await pipeline.SendSyncOrAsync(message, IsAsync);

            EventWrittenEventArgs e = _listener.SingleEventById(RequestContentTextEvent);
            Assert.AreEqual(EventLevel.Verbose, e.Level);
            Assert.AreEqual(SystemClientModelEventSourceName, e.EventSource.Name);
            Assert.AreEqual("RequestContentText", e.EventName);
            Assert.AreEqual(clientId, e.GetProperty<string>("requestId"));
            Assert.AreEqual(requestContent, e.GetProperty<string>("content"));

            CollectionAssert.IsEmpty(_listener.EventsById(ResponseContentEvent));
        }

        [Test]
        public async Task ContentIsNotLoggedAsTextWhenDisabled()
        {
            var headers = new MockResponseHeaders(new Dictionary<string, string> { { "Content-Type", "text/json" } });
            var response = new MockPipelineResponse(500);
            response.ContentStream = new MemoryStream(new byte[] { 1, 2, 3 });

            ClientPipelineOptions options = new()
            {
                Transport = new MockPipelineTransport("Transport", i => response),
                LoggingOptions = new LoggingOptions
                {
                    IsLoggingContentEnabled = false,
                    LoggedContentSizeLimit = int.MaxValue,
                    LoggedClientAssemblyName = "Test-SDK",
                    RequestIdHeaderName = ClientRequestIdHeaderName,
                    LoggedHeaderNames = s_allowedHeaders
                }
            };

            ClientPipeline pipeline = ClientPipeline.Create(options);

            PipelineMessage message = pipeline.CreateMessage();
            message.Request.Method = "GET";
            message.Request.Uri = new Uri("http://example.com");
            message.Request.Headers.Add("Custom-Header", "Value");
            message.Request.Headers.Add("Date", "3/28/2024");
            message.Request.Headers.Add("Content-Type", "text/json");
            message.Request.Content = BinaryContent.Create(new BinaryData(Encoding.UTF8.GetBytes("Hello world")));
            message.Request.Headers.Add(ClientRequestIdHeaderName, "client1");

            await pipeline.SendSyncOrAsync(message, IsAsync);

            AssertNoContentLogged();
        }

        [Test]
        public async Task ContentIsNotLoggedWhenDisabled()
        {
            var response = new MockPipelineResponse(500);
            response.ContentStream = new NonSeekableMemoryStream(new byte[] { 1, 2, 3 });

            ClientPipelineOptions options = new()
            {
                Transport = new MockPipelineTransport("Transport", i => response),
                LoggingOptions = new LoggingOptions
                {
                    LoggedClientAssemblyName = "Test-SDK",
                    RequestIdHeaderName = ClientRequestIdHeaderName,
                    LoggedHeaderNames = s_allowedHeaders
                }
            };

            ClientPipeline pipeline = ClientPipeline.Create(options);

            PipelineMessage message = pipeline.CreateMessage();
            message.Request.Method = "GET";
            message.Request.Uri = new Uri("http://example.com");
            message.Request.Content = BinaryContent.Create(new BinaryData(Encoding.UTF8.GetBytes("Hello world")));
            message.Request.Headers.Add(ClientRequestIdHeaderName, "client-id");

            await pipeline.SendSyncOrAsync(message, IsAsync);

            AssertNoContentLogged();
        }

        [Test]
        public async Task RequestContentIsNotLoggedWhenDisabled()
        {
            var response = new MockPipelineResponse(500);
            response.ContentStream = new MemoryStream(new byte[] { 1, 2, 3 });

            ClientPipelineOptions options = new()
            {
                Transport = new MockPipelineTransport("Transport", i => response),
                LoggingOptions = new LoggingOptions
                {
                    LoggedClientAssemblyName = "Test-SDK",
                    RequestIdHeaderName = ClientRequestIdHeaderName,
                    LoggedHeaderNames = s_allowedHeaders
                }
            };

            ClientPipeline pipeline = ClientPipeline.Create(options);

            PipelineMessage message = pipeline.CreateMessage();
            message.Request.Method = "GET";
            message.Request.Uri = new Uri("http://example.com");
            message.Request.Content = BinaryContent.Create(new BinaryData(Encoding.UTF8.GetBytes("Hello world")));

            await pipeline.SendSyncOrAsync(message, IsAsync);

            AssertNoContentLogged();
        }

        private void AssertNoContentLogged()
        {
            CollectionAssert.IsEmpty(_listener.EventsById(RequestContentEvent));
            CollectionAssert.IsEmpty(_listener.EventsById(RequestContentTextEvent));

            CollectionAssert.IsEmpty(_listener.EventsById(ResponseContentEvent));
            CollectionAssert.IsEmpty(_listener.EventsById(ResponseContentBlockEvent));
            CollectionAssert.IsEmpty(_listener.EventsById(ResponseContentTextBlockEvent));

            CollectionAssert.IsEmpty(_listener.EventsById(ErrorResponseContentEvent));
            CollectionAssert.IsEmpty(_listener.EventsById(ErrorResponseContentTextEvent));
            CollectionAssert.IsEmpty(_listener.EventsById(ErrorResponseContentTextBlockEvent));
        }

        [Test]
        public async Task NonSeekableResponsesAreLoggedInBlocks()
        {
            await SendRequest(isSeekable: false, isError: false);

            EventWrittenEventArgs[] contentEvents = _listener.EventsById(ResponseContentBlockEvent).ToArray();

            Assert.AreEqual(2, contentEvents.Length);

            Assert.AreEqual(EventLevel.Verbose, contentEvents[0].Level);
            Assert.AreEqual(SystemClientModelEventSourceName, contentEvents[0].EventSource.Name);
            Assert.AreEqual("ResponseContentBlock", contentEvents[0].EventName);
            Assert.AreEqual("client-id", contentEvents[0].GetProperty<string>("requestId"));
            Assert.AreEqual(0, contentEvents[0].GetProperty<int>("blockNumber"));
            CollectionAssert.AreEqual(new byte[] { 72, 101, 108, 108, 111, 32 }, contentEvents[0].GetProperty<byte[]>("content"));

            Assert.AreEqual(EventLevel.Verbose, contentEvents[1].Level);
            Assert.AreEqual(SystemClientModelEventSourceName, contentEvents[1].EventSource.Name);
            Assert.AreEqual("ResponseContentBlock", contentEvents[1].EventName);
            Assert.AreEqual("client-id", contentEvents[1].GetProperty<string>("requestId"));
            Assert.AreEqual(1, contentEvents[1].GetProperty<int>("blockNumber"));
            CollectionAssert.AreEqual(new byte[] { 119, 111, 114, 108, 100 }, contentEvents[1].GetProperty<byte[]>("content"));

            CollectionAssert.IsEmpty(_listener.EventsById(ResponseContentEvent));
        }

        [Test]
        public async Task NonSeekableResponsesErrorsAreLoggedInBlocks()
        {
            await SendRequest(isSeekable: false, isError: true);

            EventWrittenEventArgs[] errorContentEvents = _listener.EventsById(ErrorResponseContentBlockEvent).ToArray();

            Assert.AreEqual(2, errorContentEvents.Length);

            Assert.AreEqual(EventLevel.Informational, errorContentEvents[0].Level);
            Assert.AreEqual(SystemClientModelEventSourceName, errorContentEvents[0].EventSource.Name);
            Assert.AreEqual("ErrorResponseContentBlock", errorContentEvents[0].EventName);
            Assert.AreEqual("client-id", errorContentEvents[0].GetProperty<string>("requestId"));
            Assert.AreEqual(0, errorContentEvents[0].GetProperty<int>("blockNumber"));
            CollectionAssert.AreEqual(new byte[] { 72, 101, 108, 108, 111, 32 }, errorContentEvents[0].GetProperty<byte[]>("content"));

            Assert.AreEqual(EventLevel.Informational, errorContentEvents[1].Level);
            Assert.AreEqual(SystemClientModelEventSourceName, errorContentEvents[1].EventSource.Name);
            Assert.AreEqual("ErrorResponseContentBlock", errorContentEvents[1].EventName);
            Assert.AreEqual("client-id", errorContentEvents[1].GetProperty<string>("requestId"));
            Assert.AreEqual(1, errorContentEvents[1].GetProperty<int>("blockNumber"));
            CollectionAssert.AreEqual(new byte[] { 119, 111, 114, 108, 100 }, errorContentEvents[1].GetProperty<byte[]>("content"));

            CollectionAssert.IsEmpty(_listener.EventsById(ErrorResponseContentEvent));
        }

        [Test]
        public async Task NonSeekableResponsesAreLoggedInTextBlocks()
        {
            await SendRequest(
                isSeekable: false,
                isError: false,
                mockHeaders: new MockResponseHeaders(new Dictionary<string, string>() { { "Content-Type", "text/xml" } })
            );

            EventWrittenEventArgs[] contentEvents = _listener.EventsById(ResponseContentTextBlockEvent).ToArray();

            Assert.AreEqual(2, contentEvents.Length);

            Assert.AreEqual(EventLevel.Verbose, contentEvents[0].Level);
            Assert.AreEqual(SystemClientModelEventSourceName, contentEvents[0].EventSource.Name);
            Assert.AreEqual("ResponseContentTextBlock", contentEvents[0].EventName);
            Assert.AreEqual("client-id", contentEvents[0].GetProperty<string>("requestId"));
            Assert.AreEqual(0, contentEvents[0].GetProperty<int>("blockNumber"));
            Assert.AreEqual("Hello ", contentEvents[0].GetProperty<string>("content"));

            Assert.AreEqual(EventLevel.Verbose, contentEvents[1].Level);
            Assert.AreEqual(SystemClientModelEventSourceName, contentEvents[1].EventSource.Name);
            Assert.AreEqual("ResponseContentTextBlock", contentEvents[1].EventName);
            Assert.AreEqual("client-id", contentEvents[1].GetProperty<string>("requestId"));
            Assert.AreEqual(1, contentEvents[1].GetProperty<int>("blockNumber"));
            Assert.AreEqual("world", contentEvents[1].GetProperty<string>("content"));

            CollectionAssert.IsEmpty(_listener.EventsById(ResponseContentEvent));
        }

        [Test]
        public async Task NonSeekableResponsesErrorsAreLoggedInTextBlocks()
        {
            await SendRequest(
                isSeekable: false,
                isError: true,
                mockHeaders: new MockResponseHeaders(new Dictionary<string, string>() { { "Content-Type", "text/xml" } })
            );

            EventWrittenEventArgs[] errorContentEvents = _listener.EventsById(ErrorResponseContentTextBlockEvent).ToArray();

            Assert.AreEqual(2, errorContentEvents.Length);

            Assert.AreEqual(EventLevel.Informational, errorContentEvents[0].Level);
            Assert.AreEqual(SystemClientModelEventSourceName, errorContentEvents[0].EventSource.Name);
            Assert.AreEqual("ErrorResponseContentTextBlock", errorContentEvents[0].EventName);
            Assert.AreEqual("client-id", errorContentEvents[0].GetProperty<string>("requestId"));
            Assert.AreEqual(0, errorContentEvents[0].GetProperty<int>("blockNumber"));
            Assert.AreEqual("Hello ", errorContentEvents[0].GetProperty<string>("content"));

            Assert.AreEqual(EventLevel.Informational, errorContentEvents[1].Level);
            Assert.AreEqual(SystemClientModelEventSourceName, errorContentEvents[1].EventSource.Name);
            Assert.AreEqual("ErrorResponseContentTextBlock", errorContentEvents[1].EventName);
            Assert.AreEqual("client-id", errorContentEvents[1].GetProperty<string>("requestId"));
            Assert.AreEqual(1, errorContentEvents[1].GetProperty<int>("blockNumber"));
            Assert.AreEqual("world", errorContentEvents[1].GetProperty<string>("content"));

            CollectionAssert.IsEmpty(_listener.EventsById(ErrorResponseContentEvent));
        }

        [Test]
        public async Task SeekableTextResponsesAreLoggedInText()
        {
            await SendRequest(
                isSeekable: true,
                isError: false,
                mockHeaders: new MockResponseHeaders(new Dictionary<string, string>() { { "Content-Type", "text/xml" } })
            );

            EventWrittenEventArgs contentEvent = _listener.SingleEventById(ResponseContentTextEvent);

            Assert.AreEqual(EventLevel.Verbose, contentEvent.Level);
            Assert.AreEqual(SystemClientModelEventSourceName, contentEvent.EventSource.Name);
            Assert.AreEqual("ResponseContentText", contentEvent.EventName);
            Assert.AreEqual("client-id", contentEvent.GetProperty<string>("requestId"));
            Assert.AreEqual("Hello world", contentEvent.GetProperty<string>("content"));
        }

        [Test]
        public async Task SeekableTextResponsesErrorsAreLoggedInText()
        {
            await SendRequest(
                isSeekable: true,
                isError: true,
                mockHeaders: new MockResponseHeaders(new Dictionary<string, string>() { { "Content-Type", "text/xml" } }),
                maxLength: 5
            );

            EventWrittenEventArgs errorContentEvent = _listener.SingleEventById(ErrorResponseContentTextEvent);

            Assert.AreEqual(EventLevel.Informational, errorContentEvent.Level);
            Assert.AreEqual(SystemClientModelEventSourceName, errorContentEvent.EventSource.Name);
            Assert.AreEqual("ErrorResponseContentText", errorContentEvent.EventName);
            Assert.AreEqual("client-id", errorContentEvent.GetProperty<string>("requestId"));
            Assert.AreEqual("Hello", errorContentEvent.GetProperty<string>("content"));
        }

        [Test]
        public async Task SeekableTextResponsesAreLimitedInLength()
        {
            await SendRequest(
                isSeekable: true,
                isError: false,
                mockHeaders: new MockResponseHeaders(new Dictionary<string, string>() { { "Content-Type", "text/xml" } }),
                maxLength: 5
            );

            EventWrittenEventArgs contentEvent = _listener.SingleEventById(ResponseContentTextEvent);

            Assert.AreEqual(EventLevel.Verbose, contentEvent.Level);
            Assert.AreEqual(SystemClientModelEventSourceName, contentEvent.EventSource.Name);
            Assert.AreEqual("ResponseContentText", contentEvent.EventName);
            Assert.AreEqual("client-id", contentEvent.GetProperty<string>("requestId"));
            Assert.AreEqual("Hello", contentEvent.GetProperty<string>("content"));
        }

        [Test]
        public async Task RequestContentLogsAreLimitedInLength()
        {
            var response = new MockPipelineResponse(500);

            ClientPipelineOptions options = new()
            {
                Transport = new MockPipelineTransport("Transport", i => response),
                RetryPolicy = new ObservablePolicy("RetryPolicy"),
                LoggingOptions = new LoggingOptions
                {
                    IsLoggingContentEnabled = true,
                    LoggedContentSizeLimit = 5,
                    LoggedClientAssemblyName = "Test-SDK",
                    RequestIdHeaderName = ClientRequestIdHeaderName,
                    LoggedHeaderNames = s_allowedHeaders
                }
            };

            ClientPipeline pipeline = ClientPipeline.Create(options);

            PipelineMessage message = pipeline.CreateMessage();
            message.Request.Method = "GET";
            message.Request.Uri = new Uri("http://example.com");
            message.Request.Content = BinaryContent.Create(new BinaryData(Encoding.UTF8.GetBytes("Hello world")));
            message.Request.Headers.Add("Content-Type", "text/json");
            message.Request.Headers.Add(ClientRequestIdHeaderName, "client1");

            await pipeline.SendSyncOrAsync(message, IsAsync);

            EventWrittenEventArgs e = _listener.SingleEventById(RequestContentTextEvent);
            Assert.AreEqual(SystemClientModelEventSourceName, e.EventSource.Name);
            Assert.AreEqual(EventLevel.Verbose, e.Level);
            Assert.AreEqual("RequestContentText", e.EventName);
            Assert.AreEqual("client1", e.GetProperty<string>("requestId"));
            Assert.AreEqual("Hello", e.GetProperty<string>("content"));

            CollectionAssert.IsEmpty(_listener.EventsById(ResponseContentEvent));
        }

        [Test]
        public async Task NonSeekableResponsesAreLimitedInLength()
        {
            await SendRequest(
                isSeekable: false,
                isError: false,
                mockHeaders: new MockResponseHeaders(new Dictionary<string, string>() { { "Content-Type", "text/xml" } }),
                maxLength: 5
            );

            EventWrittenEventArgs[] contentEvents = _listener.EventsById(ResponseContentTextBlockEvent).ToArray();

            Assert.AreEqual(1, contentEvents.Length);

            Assert.AreEqual(EventLevel.Verbose, contentEvents[0].Level);
            Assert.AreEqual(SystemClientModelEventSourceName, contentEvents[0].EventSource.Name);
            Assert.AreEqual("ResponseContentTextBlock", contentEvents[0].EventName);
            Assert.AreEqual("client-id", contentEvents[0].GetProperty<string>("requestId"));
            Assert.AreEqual(0, contentEvents[0].GetProperty<int>("blockNumber"));
            Assert.AreEqual("Hello", contentEvents[0].GetProperty<string>("content"));

            CollectionAssert.IsEmpty(_listener.EventsById(ResponseContentEvent));
        }

        [Test]
        public async Task HeadersAndQueryParametersAreSanitized()
        {
            string clientId = "client1";

            var mockHeaders = new MockResponseHeaders(new Dictionary<string, string> { { "Custom-Response-Header", "Improved value" }, { "Secret-Response-Header", "Very secret" } });
            var response = new MockPipelineResponse(200, mockHeaders: mockHeaders);
            response.SetContent(new byte[] { 6, 7, 8, 9, 0 });

            ClientPipelineOptions options = new()
            {
                Transport = new MockPipelineTransport("Transport", i => response),
                LoggingOptions = new LoggingOptions
                {
                    LoggedClientAssemblyName = "Test-SDK",
                    RequestIdHeaderName = ClientRequestIdHeaderName,
                    LoggedHeaderNames = s_allowedHeaders,
                    LoggedQueryParameters = s_allowedQueryParameters
                }
            };

            ClientPipeline pipeline = ClientPipeline.Create(options);

            PipelineMessage message = pipeline.CreateMessage();
            message.Request.Method = "GET";
            message.Request.Uri = new Uri("https://contoso.a.io?api-version=5&secret=123");
            message.Request.Content = BinaryContent.Create(new BinaryData(new byte[] { 1, 2, 3, 4, 5 }));
            message.Request.Headers.Add("Content-Type", "text/json");
            message.Request.Headers.Add(ClientRequestIdHeaderName, clientId);
            message.Request.Headers.Add("Date", "4/18/2024");
            message.Request.Headers.Add("Custom-Header", "Value");
            message.Request.Headers.Add("Secret-Custom-Header", "Value");

            await pipeline.SendSyncOrAsync(message, IsAsync);

            EventWrittenEventArgs e = _listener.SingleEventById(RequestEvent);
            Assert.AreEqual(SystemClientModelEventSourceName, e.EventSource.Name);
            Assert.AreEqual(EventLevel.Informational, e.Level);
            Assert.AreEqual("Request", e.EventName);
            Assert.AreEqual(clientId, e.GetProperty<string>("requestId"));
            Assert.AreEqual("https://contoso.a.io/?api-version=5&secret=REDACTED", e.GetProperty<string>("uri"));
            Assert.AreEqual("GET", e.GetProperty<string>("method"));
            StringAssert.Contains($"Date:4/18/2024{Environment.NewLine}", e.GetProperty<string>("headers"));
            StringAssert.Contains($"Custom-Header:Value{Environment.NewLine}", e.GetProperty<string>("headers"));
            StringAssert.Contains($"Secret-Custom-Header:REDACTED{Environment.NewLine}", e.GetProperty<string>("headers"));
            Assert.AreEqual("Test-SDK", e.GetProperty<string>("clientAssembly"));

            e = _listener.SingleEventById(ResponseEvent);
            Assert.AreEqual(SystemClientModelEventSourceName, e.EventSource.Name);
            Assert.AreEqual(EventLevel.Informational, e.Level);
            Assert.AreEqual("Response", e.EventName);
            Assert.AreEqual(clientId, e.GetProperty<string>("requestId"));
            Assert.AreEqual(e.GetProperty<int>("status"), 200);
            StringAssert.Contains($"Custom-Response-Header:Improved value{Environment.NewLine}", e.GetProperty<string>("headers"));
            StringAssert.Contains($"Secret-Response-Header:REDACTED{Environment.NewLine}", e.GetProperty<string>("headers"));
        }

        [Test]
        public async Task HeadersAndQueryParametersAreNotSanitizedWhenStars()
        {
            string clientId = "client1";
            var mockHeaders = new MockResponseHeaders(new Dictionary<string, string> { { "Custom-Response-Header", "Improved value" }, { "Secret-Response-Header", "Very secret" } });
            var response = new MockPipelineResponse(200, mockHeaders: mockHeaders);
            response.SetContent(new byte[] { 6, 7, 8, 9, 0 });

            ClientPipelineOptions options = new()
            {
                Transport = new MockPipelineTransport("Transport", i => response),
                LoggingOptions = new LoggingOptions
                {
                    LoggedClientAssemblyName = "Test-SDK",
                    RequestIdHeaderName = ClientRequestIdHeaderName,
                    LoggedHeaderNames = new List<string>() { "*" },
                    LoggedQueryParameters = new List<string>() { "*" }
                }
            };

            ClientPipeline pipeline = ClientPipeline.Create(options);

            PipelineMessage message = pipeline.CreateMessage();
            message.Request.Method = "GET";
            message.Request.Uri = new Uri("https://contoso.a.io?api-version=5&secret=123");
            message.Request.Content = BinaryContent.Create(new BinaryData(new byte[] { 1, 2, 3, 4, 5 }));
            message.Request.Headers.Add("Content-Type", "text/json");
            message.Request.Headers.Add(ClientRequestIdHeaderName, clientId);
            message.Request.Headers.Add("Date", "4/18/2024");
            message.Request.Headers.Add("Secret-Custom-Header", "Value");

            await pipeline.SendSyncOrAsync(message, IsAsync);

            EventWrittenEventArgs e = _listener.SingleEventById(RequestEvent);
            Assert.AreEqual(SystemClientModelEventSourceName, e.EventSource.Name);
            Assert.AreEqual(EventLevel.Informational, e.Level);
            Assert.AreEqual("Request", e.EventName);
            Assert.AreEqual(clientId, e.GetProperty<string>("requestId"));
            Assert.AreEqual("https://contoso.a.io/?api-version=5&secret=123", e.GetProperty<string>("uri"));
            Assert.AreEqual("GET", e.GetProperty<string>("method"));
            StringAssert.Contains($"Date:4/18/2024{Environment.NewLine}", e.GetProperty<string>("headers"));
            StringAssert.Contains($"Custom-Header:Value{Environment.NewLine}", e.GetProperty<string>("headers"));
            StringAssert.Contains($"Secret-Custom-Header:Value{Environment.NewLine}", e.GetProperty<string>("headers"));
            Assert.AreEqual("Test-SDK", e.GetProperty<string>("clientAssembly"));

            e = _listener.SingleEventById(ResponseEvent);
            Assert.AreEqual(EventLevel.Informational, e.Level);
            Assert.AreEqual(SystemClientModelEventSourceName, e.EventSource.Name);
            Assert.AreEqual("Response", e.EventName);
            Assert.AreEqual(clientId, e.GetProperty<string>("requestId"));
            Assert.AreEqual(e.GetProperty<int>("status"), 200);
            StringAssert.Contains($"Custom-Response-Header:Improved value{Environment.NewLine}", e.GetProperty<string>("headers"));
            StringAssert.Contains($"Secret-Response-Header:Very secret{Environment.NewLine}", e.GetProperty<string>("headers"));
        }

        private async Task<MockPipelineResponse> SendRequest(bool isSeekable, bool isError, MockResponseHeaders? mockHeaders = default, int maxLength = int.MaxValue)
        {
            var response = new MockPipelineResponse(isError ? 500 : 200, mockHeaders: mockHeaders);
            byte[] responseContent = Encoding.UTF8.GetBytes("Hello world");
            if (isSeekable)
            {
                response.ContentStream = new MemoryStream(responseContent);
            }
            else
            {
                response.ContentStream = new NonSeekableMemoryStream(responseContent);
            }

            ClientPipelineOptions options = new()
            {
                Transport = new MockPipelineTransport("Transport", i => response),
                RetryPolicy = new ObservablePolicy("RetryPolicy"),
                LoggingOptions = new LoggingOptions
                {
                    IsLoggingContentEnabled = true,
                    LoggedContentSizeLimit = maxLength,
                    LoggedClientAssemblyName = "Test-SDK",
                    RequestIdHeaderName = ClientRequestIdHeaderName,
                    LoggedHeaderNames = s_allowedHeaders
                }
            };

            ClientPipeline pipeline = ClientPipeline.Create(options);

            PipelineMessage message = pipeline.CreateMessage();
            message.Request.Method = "GET";
            message.Request.Uri = new Uri("http://example.com");
            message.Request.Headers.Add(ClientRequestIdHeaderName, "client-id");

            // These tests are essentially testing whether the logging policy works
            // correctly when responses are buffered (memory stream) and unbuffered
            // (non-seekable). In order to validate the intent of the test, we set
            // message.BufferResponse accordingly here.
            message.BufferResponse = isSeekable;

            await pipeline.SendSyncOrAsync(message, IsAsync);

            var buffer = new byte[11];

            if (IsAsync)
            {
                Assert.AreEqual(6, await response.ContentStream.ReadAsync(buffer, 5, 6));
                Assert.AreEqual(5, await response.ContentStream.ReadAsync(buffer, 6, 5));
                Assert.AreEqual(0, await response.ContentStream.ReadAsync(buffer, 0, 5));
            }
            else
            {
                Assert.AreEqual(6, response.ContentStream.Read(buffer, 5, 6));
                Assert.AreEqual(5, response.ContentStream.Read(buffer, 6, 5));
                Assert.AreEqual(0, response.ContentStream.Read(buffer, 0, 5));
            }

            return response;
        }

        private class AzureCoreLoggingPolicy : ClientLoggingPolicy
        {
            public AzureCoreLoggingPolicy(LoggingOptions options) : base("Azure-Core", new string[] { "Trait", "True" }, options)
            {
            }
        }

        private class NotEnabledLoggingPolicy : ClientLoggingPolicy
        {
            public NotEnabledLoggingPolicy(LoggingOptions options) : base("Do-Not-Enable", new string[] { "Trait", "True" }, options)
            {
            }
        }
    }
}
