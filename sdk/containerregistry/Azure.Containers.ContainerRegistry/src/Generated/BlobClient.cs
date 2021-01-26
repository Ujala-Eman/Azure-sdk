// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> The Blob service client. </summary>
    public partial class BlobClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal BlobRestClient RestClient { get; }
        /// <summary> Initializes a new instance of BlobClient for mocking. </summary>
        protected BlobClient()
        {
        }
        /// <summary> Initializes a new instance of BlobClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="url"> Registry login URL. </param>
        internal BlobClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string url)
        {
            RestClient = new BlobRestClient(clientDiagnostics, pipeline, url);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Retrieve the blob from the registry identified by digest. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Stream>> GetAsync(string name, string digest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobClient.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(name, digest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieve the blob from the registry identified by digest. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Stream> Get(string name, string digest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobClient.Get");
            scope.Start();
            try
            {
                return RestClient.Get(name, digest, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Same as GET, except only the headers are returned. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CheckAsync(string name, string digest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobClient.Check");
            scope.Start();
            try
            {
                return (await RestClient.CheckAsync(name, digest, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Same as GET, except only the headers are returned. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Check(string name, string digest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobClient.Check");
            scope.Start();
            try
            {
                return RestClient.Check(name, digest, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes an already uploaded blob. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Stream>> DeleteAsync(string name, string digest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobClient.Delete");
            scope.Start();
            try
            {
                return await RestClient.DeleteAsync(name, digest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Removes an already uploaded blob. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Stream> Delete(string name, string digest, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobClient.Delete");
            scope.Start();
            try
            {
                return RestClient.Delete(name, digest, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Mount a blob identified by the `mount` parameter from another repository. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="from"> Name of the source repository. </param>
        /// <param name="mount"> Digest of blob to mount from the source repository. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> MountAsync(string name, string @from, string mount, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobClient.Mount");
            scope.Start();
            try
            {
                return (await RestClient.MountAsync(name, @from, mount, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Mount a blob identified by the `mount` parameter from another repository. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="from"> Name of the source repository. </param>
        /// <param name="mount"> Digest of blob to mount from the source repository. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Mount(string name, string @from, string mount, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobClient.Mount");
            scope.Start();
            try
            {
                return RestClient.Mount(name, @from, mount, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieve status of upload identified by uuid. The primary purpose of this endpoint is to resolve the current status of a resumable upload. </summary>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> GetStatusAsync(string location, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobClient.GetStatus");
            scope.Start();
            try
            {
                return (await RestClient.GetStatusAsync(location, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieve status of upload identified by uuid. The primary purpose of this endpoint is to resolve the current status of a resumable upload. </summary>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response GetStatus(string location, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobClient.GetStatus");
            scope.Start();
            try
            {
                return RestClient.GetStatus(location, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Upload a stream of data without completing the upload. </summary>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        /// <param name="value"> Raw data of blob. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> UploadAsync(string location, Stream value, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobClient.Upload");
            scope.Start();
            try
            {
                return (await RestClient.UploadAsync(location, value, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Upload a stream of data without completing the upload. </summary>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        /// <param name="value"> Raw data of blob. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response Upload(string location, Stream value, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobClient.Upload");
            scope.Start();
            try
            {
                return RestClient.Upload(location, value, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Complete the upload, providing all the data in the body, if necessary. A request without a body will just complete the upload with previously uploaded content. </summary>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        /// <param name="value"> Optional raw data of blob. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> EndUploadAsync(string digest, string location, Stream value, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobClient.EndUpload");
            scope.Start();
            try
            {
                return (await RestClient.EndUploadAsync(digest, location, value, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Complete the upload, providing all the data in the body, if necessary. A request without a body will just complete the upload with previously uploaded content. </summary>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        /// <param name="value"> Optional raw data of blob. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response EndUpload(string digest, string location, Stream value, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobClient.EndUpload");
            scope.Start();
            try
            {
                return RestClient.EndUpload(digest, location, value, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancel outstanding upload processes, releasing associated resources. If this is not called, the unfinished uploads will eventually timeout. </summary>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CancelUploadAsync(string location, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobClient.CancelUpload");
            scope.Start();
            try
            {
                return await RestClient.CancelUploadAsync(location, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Cancel outstanding upload processes, releasing associated resources. If this is not called, the unfinished uploads will eventually timeout. </summary>
        /// <param name="location"> Link acquired from upload start or previous chunk. Note, do not include initial / (must do substring(1) ). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CancelUpload(string location, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobClient.CancelUpload");
            scope.Start();
            try
            {
                return RestClient.CancelUpload(location, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Initiate a resumable blob upload with an empty request body. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> StartUploadAsync(string name, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobClient.StartUpload");
            scope.Start();
            try
            {
                return (await RestClient.StartUploadAsync(name, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Initiate a resumable blob upload with an empty request body. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response StartUpload(string name, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobClient.StartUpload");
            scope.Start();
            try
            {
                return RestClient.StartUpload(name, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieve the blob from the registry identified by `digest`. This endpoint may also support RFC7233 compliant range requests. Support can be detected by issuing a HEAD request. If the header `Accept-Range: bytes` is returned, range requests can be used to fetch partial content. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="range"> Format : bytes=&lt;start&gt;-&lt;end&gt;,  HTTP Range header specifying blob chunk. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<Stream>> GetChunkAsync(string name, string digest, string range, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobClient.GetChunk");
            scope.Start();
            try
            {
                return await RestClient.GetChunkAsync(name, digest, range, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Retrieve the blob from the registry identified by `digest`. This endpoint may also support RFC7233 compliant range requests. Support can be detected by issuing a HEAD request. If the header `Accept-Range: bytes` is returned, range requests can be used to fetch partial content. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="range"> Format : bytes=&lt;start&gt;-&lt;end&gt;,  HTTP Range header specifying blob chunk. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<Stream> GetChunk(string name, string digest, string range, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobClient.GetChunk");
            scope.Start();
            try
            {
                return RestClient.GetChunk(name, digest, range, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Same as GET, except only the headers are returned. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="range"> Format : bytes=&lt;start&gt;-&lt;end&gt;,  HTTP Range header specifying blob chunk. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response> CheckChunkAsync(string name, string digest, string range, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobClient.CheckChunk");
            scope.Start();
            try
            {
                return (await RestClient.CheckChunkAsync(name, digest, range, cancellationToken).ConfigureAwait(false)).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Same as GET, except only the headers are returned. </summary>
        /// <param name="name"> Name of the image (including the namespace). </param>
        /// <param name="digest"> Digest of a BLOB. </param>
        /// <param name="range"> Format : bytes=&lt;start&gt;-&lt;end&gt;,  HTTP Range header specifying blob chunk. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response CheckChunk(string name, string digest, string range, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("BlobClient.CheckChunk");
            scope.Start();
            try
            {
                return RestClient.CheckChunk(name, digest, range, cancellationToken).GetRawResponse();
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
