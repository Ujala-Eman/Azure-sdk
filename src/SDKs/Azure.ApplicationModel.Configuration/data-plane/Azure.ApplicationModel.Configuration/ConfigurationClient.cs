﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core.Pipeline;
using Azure.Core.Pipeline.Policies;

namespace Azure.ApplicationModel.Configuration
{
    public partial class ConfigurationClient
    {
        private readonly Uri _baseUri;
        private readonly HttpPipeline _pipeline;


        /// <summary>
        /// Protected constructor to allow mocking
        /// </summary>
        protected ConfigurationClient()
        {
        }

        public ConfigurationClient(string connectionString)
            : this(connectionString, new ConfigurationClientOptions())
        {
        }

        public ConfigurationClient(string connectionString, ConfigurationClientOptions options)
        {
            if (connectionString == null)
                throw new ArgumentNullException(nameof(connectionString));
            if (options == null)
                throw new ArgumentNullException(nameof(options));

            ParseConnectionString(connectionString, out _baseUri, out var credential, out var secret);

            _pipeline = HttpPipeline.Build(options,
                    options.ResponseClassifier,
                    options.RetryPolicy,
                    ClientRequestIdPolicy.Singleton,
                    new AuthenticationPolicy(credential, secret),
                    options.LoggingPolicy,
                    BufferResponsePolicy.Singleton);
        }

        public virtual async Task<Response<ConfigurationSetting>> AddAsync(string key, string value, string label = default, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException($"{nameof(key)}");
            return await AddAsync(new ConfigurationSetting(key, value, label), cancellationToken);
        }

        public virtual Response<ConfigurationSetting> Add(string key, string value, string label = default, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(key)) throw new ArgumentNullException($"{nameof(key)}");
            return Add(new ConfigurationSetting(key, value, label), cancellationToken);
        }

        public virtual async Task<Response<ConfigurationSetting>> AddAsync(ConfigurationSetting setting, CancellationToken cancellationToken = default)
        {
            using (Request request = CreateAddRequest(setting))
            {
                Response response = await _pipeline.SendRequestAsync(request, cancellationToken).ConfigureAwait(false);

                switch (response.Status)
                {
                    case 200:
                    case 201:
                        return await CreateResponseAsync(response, cancellationToken);
                    default:
                        throw new RequestFailedException(response);
                }
            }
        }

        public Response<ConfigurationSetting> Add(ConfigurationSetting setting, CancellationToken cancellationToken = default)
        {
            using (Request request = CreateAddRequest(setting))
            {
                Response response = _pipeline.SendRequest(request, cancellationToken);

                switch (response.Status)
                {
                    case 200:
                    case 201:
                        return CreateResponse(response, cancellationToken);
                    default:
                        throw new RequestFailedException(response);
                }
            }
        }

        private Request CreateAddRequest(ConfigurationSetting setting)
        {
            if (setting == null)
                throw new ArgumentNullException(nameof(setting));
            if (string.IsNullOrEmpty(setting.Key))
                throw new ArgumentNullException($"{nameof(setting)}.{nameof(setting.Key)}");

            var request = _pipeline.CreateRequest();

            ReadOnlyMemory<byte> content = Serialize(setting);

            request.Method = HttpPipelineMethod.Put;

            BuildUriForKvRoute(request.UriBuilder, setting);

            request.Headers.Add(IfNoneMatch, "*");
            request.Headers.Add(MediaTypeKeyValueApplicationHeader);
            request.Headers.Add(HttpHeader.Common.JsonContentType);
            request.Content = HttpPipelineRequestContent.Create(content);

            return request;
        }

        public virtual async Task<Response<ConfigurationSetting>> SetAsync(ConfigurationSetting setting, CancellationToken cancellationToken = default)
        {
            using (Request request = CreateSetRequest(setting))
            {
                Response response = await _pipeline.SendRequestAsync(request, cancellationToken).ConfigureAwait(false);

                switch (response.Status)
                {
                    case 200:
                        return await CreateResponseAsync(response, cancellationToken);
                    case 409:
                        throw new RequestFailedException(response, "the item is locked");
                    default:
                        throw new RequestFailedException(response);
                }
            }
        }

        public virtual Response<ConfigurationSetting> Set(ConfigurationSetting setting, CancellationToken cancellationToken = default)
        {
            using (Request request = CreateSetRequest(setting))
            {
                var response = _pipeline.SendRequest(request, cancellationToken);

                switch (response.Status)
                {
                    case 200:
                        return CreateResponse(response, cancellationToken);
                    case 409:
                        throw new RequestFailedException(response, "the item is locked");
                    default:
                        throw new RequestFailedException(response);
                }
            }
        }

        private Request CreateSetRequest(ConfigurationSetting setting)
        {
            if (setting == null)
                throw new ArgumentNullException(nameof(setting));
            if (string.IsNullOrEmpty(setting.Key))
                throw new ArgumentNullException($"{nameof(setting)}.{nameof(setting.Key)}");

            Request request = _pipeline.CreateRequest();
            ReadOnlyMemory<byte> content = Serialize(setting);

            request.Method = HttpPipelineMethod.Put;
            BuildUriForKvRoute(request.UriBuilder, setting);
            request.Headers.Add(MediaTypeKeyValueApplicationHeader);
            request.Headers.Add(HttpHeader.Common.JsonContentType);

            if (setting.ETag != default)
            {
                request.Headers.Add(IfMatchName, $"\"{setting.ETag.ToString()}\"");
            }

            request.Content = HttpPipelineRequestContent.Create(content);
            return request;
        }

        public virtual async Task<Response<ConfigurationSetting>> UpdateAsync(string key, string value, string label = default, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException($"{nameof(key)}");
            return await UpdateAsync(new ConfigurationSetting(key, value, label), cancellationToken);
        }

        public virtual Response<ConfigurationSetting> Update(string key, string value, string label = default, CancellationToken cancellationToken = default)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException($"{nameof(key)}");
            return Update(new ConfigurationSetting(key, value, label), cancellationToken);
        }

        public virtual async Task<Response<ConfigurationSetting>> UpdateAsync(ConfigurationSetting setting, CancellationToken cancellation = default)
        {
            using (Request request = CreateUpdateRequest(setting))
            {
                Response response = await _pipeline.SendRequestAsync(request, cancellation).ConfigureAwait(false);

                switch (response.Status)
                {
                    case 200:
                        return await CreateResponseAsync(response, cancellation);
                    default:
                        throw new RequestFailedException(response);
                }
            }
        }

        public virtual Response<ConfigurationSetting> Update(ConfigurationSetting setting, CancellationToken cancellation = default)
        {
            using (Request request = CreateUpdateRequest(setting))
            {
                Response response = _pipeline.SendRequest(request, cancellation);

                switch (response.Status)
                {
                    case 200:
                        return CreateResponse(response, cancellation);
                    default:
                        throw new RequestFailedException(response);
                }
            }
        }

        private Request CreateUpdateRequest(ConfigurationSetting setting)
        {
            if (setting == null)
                throw new ArgumentNullException(nameof(setting));
            if (string.IsNullOrEmpty(setting.Key))
                throw new ArgumentNullException($"{nameof(setting)}.{nameof(setting.Key)}");

            Request request = _pipeline.CreateRequest();
            ReadOnlyMemory<byte> content = Serialize(setting);

            request.Method = HttpPipelineMethod.Put;
            BuildUriForKvRoute(request.UriBuilder, setting);
            request.Headers.Add(MediaTypeKeyValueApplicationHeader);
            request.Headers.Add(HttpHeader.Common.JsonContentType);

            if (setting.ETag != default)
            {
                request.Headers.Add(IfMatchName, $"\"{setting.ETag}\"");
            }
            else
            {
                request.Headers.Add(IfMatchName, "*");
            }

            request.Content = HttpPipelineRequestContent.Create(content);
            return request;
        }

        public virtual async Task<Response> DeleteAsync(string key, string label = default, ETag etag = default, CancellationToken cancellationToken = default)
        {
            using (Request request = CreateDeleteRequest(key, label, etag))
            {
                Response response = await _pipeline.SendRequestAsync(request, cancellationToken).ConfigureAwait(false);

                switch (response.Status)
                {
                    case 200:
                    case 204:
                        return response;
                    default:
                        throw new RequestFailedException(response);
                }
            }
        }

        public virtual Response Delete(string key, string label = default, ETag etag = default, CancellationToken cancellationToken = default)
        {
            using (Request request = CreateDeleteRequest(key, label, etag))
            {
                Response response = _pipeline.SendRequest(request, cancellationToken);

                switch (response.Status)
                {
                    case 200:
                    case 204:
                        return response;
                    default:
                        throw new RequestFailedException(response);
                }
            }
        }

        private Request CreateDeleteRequest(string key, string label, ETag etag)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException(nameof(key));

            Request request = _pipeline.CreateRequest();
            request.Method = HttpPipelineMethod.Delete;
            BuildUriForKvRoute(request.UriBuilder, key, label);

            if (etag != default)
            {
                request.Headers.Add(IfMatchName, $"\"{etag.ToString()}\"");
            }

            return request;
        }

        public virtual async Task<Response<ConfigurationSetting>> GetAsync(string key, string label = default, DateTimeOffset acceptDateTime = default, CancellationToken cancellationToken = default)
        {
            using (Request request = CreateGetRequest(key, label, acceptDateTime))
            {
                Response response = await _pipeline.SendRequestAsync(request, cancellationToken).ConfigureAwait(false);

                switch (response.Status)
                {
                    case 200:
                        return await CreateResponseAsync(response, cancellationToken);
                    default:
                        throw new RequestFailedException(response);
                }
            }
        }

        public virtual Response<ConfigurationSetting> Get(string key, string label = default, DateTimeOffset acceptDateTime = default, CancellationToken cancellationToken = default)
        {
            using (Request request = CreateGetRequest(key, label, acceptDateTime))
            {
                Response response = _pipeline.SendRequest(request, cancellationToken);

                switch (response.Status)
                {
                    case 200:
                        return CreateResponse(response, cancellationToken);
                    default:
                        throw new RequestFailedException(response);
                }
            }
        }

        private Request CreateGetRequest(string key, string label, DateTimeOffset acceptDateTime)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentNullException($"{nameof(key)}");

            Request request = _pipeline.CreateRequest();
            request.Method = HttpPipelineMethod.Get;
            BuildUriForKvRoute(request.UriBuilder, key, label);
            request.Headers.Add(MediaTypeKeyValueApplicationHeader);

            if (acceptDateTime != default)
            {
                var dateTime = acceptDateTime.UtcDateTime.ToString(AcceptDateTimeFormat);
                request.Headers.Add(AcceptDatetimeHeader, dateTime);
            }

            request.Headers.Add(HttpHeader.Common.JsonContentType);
            return request;
        }

        public virtual async Task<Response<SettingBatch>> GetBatchAsync(SettingSelector selector, CancellationToken cancellation = default)
        {
            using (Request request = CreateBatchRequest(selector))
            {
                Response response = await _pipeline.SendRequestAsync(request, cancellation).ConfigureAwait(false);

                switch (response.Status)
                {
                    case 200:
                    case 206:
                        return new Response<SettingBatch>(response, await ConfigurationServiceSerializer.ParseBatchAsync(response, selector, cancellation));
                    default:
                        throw new RequestFailedException(response);
                }
            }

        }

        public virtual Response<SettingBatch> GetBatch(SettingSelector selector, CancellationToken cancellation = default)
        {
            using (Request request = CreateBatchRequest(selector))
            {
                Response response = _pipeline.SendRequest(request, cancellation);

                switch (response.Status)
                {
                    case 200:
                    case 206:
                        return new Response<SettingBatch>(response, ConfigurationServiceSerializer.ParseBatch(response, selector, cancellation));
                    default:
                        throw new RequestFailedException(response);
                }
            }
        }

        private Request CreateBatchRequest(SettingSelector selector)
        {
            Request request = _pipeline.CreateRequest();
            request.Method = HttpPipelineMethod.Get;
            BuildUriForGetBatch(request.UriBuilder, selector);
            request.Headers.Add(MediaTypeKeyValueApplicationHeader);
            if (selector.AsOf.HasValue)
            {
                var dateTime = selector.AsOf.Value.UtcDateTime.ToString(AcceptDateTimeFormat);
                request.Headers.Add(AcceptDatetimeHeader, dateTime);
            }

            return request;
        }

        public virtual async Task<Response<SettingBatch>> GetRevisionsAsync(SettingSelector selector, CancellationToken cancellationToken = default)
        {
            using (Request request = CreateGetRevisionsRequest(selector))
            {
                Response response = await _pipeline.SendRequestAsync(request, cancellationToken).ConfigureAwait(false);
                switch (response.Status)
                {
                    case 200:
                    case 206:
                    {
                        return new Response<SettingBatch>(response, await ConfigurationServiceSerializer.ParseBatchAsync(response, selector, cancellationToken));
                    }
                    default:
                        throw new RequestFailedException(response);
                }
            }
        }

        public virtual Response<SettingBatch> GetRevisions(SettingSelector selector, CancellationToken cancellationToken = default)
        {
            using (Request request = CreateGetRevisionsRequest(selector))
            {
                Response response = _pipeline.SendRequest(request, cancellationToken);
                switch (response.Status)
                {
                    case 200:
                    case 206:
                    {
                        return new Response<SettingBatch>(response, ConfigurationServiceSerializer.ParseBatch(response, selector, cancellationToken));
                    }
                    default:
                        throw new RequestFailedException(response);
                }
            }
        }

        private Request CreateGetRevisionsRequest(SettingSelector selector)
        {
            var request = _pipeline.CreateRequest();
            request.Method = HttpPipelineMethod.Get;
            BuildUriForRevisions(request.UriBuilder, selector);
            request.Headers.Add(MediaTypeKeyValueApplicationHeader);
            if (selector.AsOf.HasValue)
            {
                var dateTime = selector.AsOf.Value.UtcDateTime.ToString(AcceptDateTimeFormat);
                request.Headers.Add(AcceptDatetimeHeader, dateTime);
            }

            return request;
        }
    }
}
