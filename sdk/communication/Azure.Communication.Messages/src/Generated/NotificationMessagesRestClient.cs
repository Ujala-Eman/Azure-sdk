// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Communication.Messages
{
    internal partial class NotificationMessagesRestClient
    {
        private readonly HttpPipeline _pipeline;
        private readonly string _endpoint;
        private readonly string _apiVersion;

        /// <summary> The ClientDiagnostics is used to provide tracing support for the client library. </summary>
        internal ClientDiagnostics ClientDiagnostics { get; }

        /// <summary> Initializes a new instance of NotificationMessagesRestClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The communication resource, for example https://my-resource.communication.azure.com. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/>, <paramref name="endpoint"/> or <paramref name="apiVersion"/> is null. </exception>
        public NotificationMessagesRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string endpoint, string apiVersion = "2023-02-01-preview")
        {
            ClientDiagnostics = clientDiagnostics ?? throw new ArgumentNullException(nameof(clientDiagnostics));
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? throw new ArgumentNullException(nameof(endpoint));
            _apiVersion = apiVersion ?? throw new ArgumentNullException(nameof(apiVersion));
        }

        internal HttpMessage CreateSendMessageRequest(string channelRegistrationId, IEnumerable<string> to, CommunicationMessageType type, string content, string mediaUri, MessageTemplateInternal template)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(_endpoint, false);
            uri.AppendPath("/messages/notifications/:send", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var model = new SendNotificationRequest(channelRegistrationId, to.ToList(), type)
            {
                Content = content,
                MediaUri = mediaUri,
                Template = template
            };
            var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(model);
            request.Content = content0;
            return message;
        }

        /// <param name="channelRegistrationId"> The Channel Registration ID for the Business Identifier. </param>
        /// <param name="to"> The native external platform user identifiers of the recipient. </param>
        /// <param name="type"> The type of message. Supports text, image, template. </param>
        /// <param name="content"> Message content. </param>
        /// <param name="mediaUri"> A media url for the file. Required if the type is one of the supported media types, e.g. image. </param>
        /// <param name="template"> The template object used to create templates. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="channelRegistrationId"/> or <paramref name="to"/> is null. </exception>
        public async Task<Response<SendMessageResult>> SendMessageAsync(string channelRegistrationId, IEnumerable<string> to, CommunicationMessageType type, string content = null, string mediaUri = null, MessageTemplateInternal template = null, CancellationToken cancellationToken = default)
        {
            if (channelRegistrationId == null)
            {
                throw new ArgumentNullException(nameof(channelRegistrationId));
            }
            if (to == null)
            {
                throw new ArgumentNullException(nameof(to));
            }

            using var message = CreateSendMessageRequest(channelRegistrationId, to, type, content, mediaUri, template);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        SendMessageResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = SendMessageResult.DeserializeSendMessageResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <param name="channelRegistrationId"> The Channel Registration ID for the Business Identifier. </param>
        /// <param name="to"> The native external platform user identifiers of the recipient. </param>
        /// <param name="type"> The type of message. Supports text, image, template. </param>
        /// <param name="content"> Message content. </param>
        /// <param name="mediaUri"> A media url for the file. Required if the type is one of the supported media types, e.g. image. </param>
        /// <param name="template"> The template object used to create templates. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="channelRegistrationId"/> or <paramref name="to"/> is null. </exception>
        public Response<SendMessageResult> SendMessage(string channelRegistrationId, IEnumerable<string> to, CommunicationMessageType type, string content = null, string mediaUri = null, MessageTemplateInternal template = null, CancellationToken cancellationToken = default)
        {
            if (channelRegistrationId == null)
            {
                throw new ArgumentNullException(nameof(channelRegistrationId));
            }
            if (to == null)
            {
                throw new ArgumentNullException(nameof(to));
            }

            using var message = CreateSendMessageRequest(channelRegistrationId, to, type, content, mediaUri, template);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 202:
                    {
                        SendMessageResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = SendMessageResult.DeserializeSendMessageResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
