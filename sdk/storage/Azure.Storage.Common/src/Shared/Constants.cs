﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace Azure.Storage
{
    internal static class Constants
    {
        public const int KB = 1024;
        public const int MB = KB * 1024;
        public const int GB = MB * 1024;
        public const long TB = GB * 1024L;

        public const int MaxReliabilityRetries = 5;

        /// <summary>
        /// The maximum allowed time between read or write calls to the stream for IdleCancellingStream.
        /// </summary>
        public const int MaxIdleTimeMs = 120000;

        /// <summary>
        /// Gets the default service version to use when building shared access
        /// signatures.
        /// </summary>
        public const string DefaultSasVersion = "2019-07-07";

        /// <summary>
        /// The default size of staged blocks when uploading small blobs.
        /// </summary>
        public const int DefaultBufferSize = 4 * Constants.MB;

        /// <summary>
        /// The size of staged blocks when uploading large blobs.
        /// </summary>
        public const int LargeBufferSize = 8 * Constants.MB;

        /// <summary>
        /// The threshold where we switch from staging <see cref="DefaultBufferSize"/>
        /// buffers to staging <see cref="LargeBufferSize"/> buffers.
        /// </summary>
        public const int LargeUploadThreshold = 100 * Constants.MB;

        /// <summary>
        /// Different .NET implementations have different default sizes for <see cref="System.IO.Stream.CopyTo(System.IO.Stream)"/>
        /// and it's overloads. This is the default for .NET Core to be applied everywhere for test consistency.
        /// </summary>
        public const int DefaultStreamCopyBufferSize = 81920;

        /// <summary>
        /// The size of the buffer to use when copying streams during a
        /// download operation.
        /// </summary>
        public const int DefaultDownloadCopyBufferSize = 16384;

        public const string CloseAllHandles = "*";
        public const string Wildcard = "*";

        /// <summary>
        /// The default format we use for block names.  There are 50,000
        /// maximum blocks so we pad the size with up to 4 leading zeros.
        /// </summary>
        public const string BlockNameFormat = "Block_{0:D5}";

        // SASTimeFormat represents the format of a SAS start or expiry time. Use it when formatting/parsing a time.Time.
        // ISO 8601 uses "yyyy'-'MM'-'dd'T'HH':'mm':'ss"
        public const string SasTimeFormat = "yyyy-MM-ddTHH:mm:ssZ";

        public const string SnapshotParameterName = "snapshot";
        public const string VersionIdParameterName = "versionid";

        public const string Https = "https";
        public const string Http = "http";

        /// <summary>
        /// Storage Connection String constant values.
        /// </summary>
        internal static class ConnectionStrings
        {
            /// <summary>
            /// The default port numbers for development storage credentials
            /// </summary>
            internal const int BlobEndpointPortNumber = 10000;
            internal const int QueueEndpointPortNumber = 10001;
            internal const int TableEndpointPortNumber = 10002;

            internal const string UseDevelopmentSetting = "UseDevelopmentStorage";
            internal const string DevelopmentProxyUriSetting = "DevelopmentStorageProxyUri";
            internal const string DefaultEndpointsProtocolSetting = "DefaultEndpointsProtocol";
            internal const string AccountNameSetting = "AccountName";
            internal const string AccountKeyNameSetting = "AccountKeyName";
            internal const string AccountKeySetting = "AccountKey";
            internal const string BlobEndpointSetting = "BlobEndpoint";
            internal const string QueueEndpointSetting = "QueueEndpoint";
            internal const string TableEndpointSetting = "TableEndpoint";
            internal const string FileEndpointSetting = "FileEndpoint";
            internal const string BlobSecondaryEndpointSetting = "BlobSecondaryEndpoint";
            internal const string QueueSecondaryEndpointSetting = "QueueSecondaryEndpoint";
            internal const string TableSecondaryEndpointSetting = "TableSecondaryEndpoint";
            internal const string FileSecondaryEndpointSetting = "FileSecondaryEndpoint";
            internal const string EndpointSuffixSetting = "EndpointSuffix";
            internal const string SharedAccessSignatureSetting = "SharedAccessSignature";
            internal const string DevStoreAccountName = "devstoreaccount1";
            internal const string DevStoreAccountKey =
                "Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==";
            internal const string SecondaryLocationAccountSuffix = "-secondary";
            internal const string DefaultEndpointSuffix = "core.windows.net";
            internal const string DefaultBlobHostnamePrefix = "blob";
            internal const string DefaultQueueHostnamePrefix = "queue";
            internal const string DefaultTableHostnamePrefix = "table";
            internal const string DefaultFileHostnamePrefix = "file";
        }

        /// <summary>
        /// Header Name constant values.
        /// </summary>
        internal static class HeaderNames
        {
            public const string XMsPrefix = "x-ms-";
            public const string MetadataPrefix = "x-ms-meta-";
            public const string ErrorCode = "x-ms-error-code";
            public const string RequestId = "x-ms-request-id";
            public const string ClientRequestId = "x-ms-client-request-id";
            public const string Date = "x-ms-date";
            public const string SharedKey = "SharedKey";
            public const string Authorization = "Authorization";
            public const string ContentEncoding = "Content-Encoding";
            public const string ContentLanguage = "Content-Language";
            public const string ContentLength = "Content-Length";
            public const string ContentMD5 = "Content-MD5";
            public const string ContentType = "Content-Type";
            public const string IfModifiedSince = "If-Modified-Since";
            public const string IfMatch = "If-Match";
            public const string IfNoneMatch = "If-None-Match";
            public const string IfUnmodifiedSince = "If-Unmodified-Since";
            public const string Range = "Range";
            public const string ContentRange = "Content-Range";
            public const string VersionId = "x-ms-version-id";
        }

        internal static class ErrorCodes
        {
            public const string InternalError = "InternalError";
            public const string OperationTimedOut = "OperationTimedOut";
            public const string ServerBusy = "ServerBusy";
        }

        /// <summary>
        /// Blob constant values.
        /// </summary>
        internal static class Blob
        {
            public const int HttpsPort = 443;
            public const string UriSubDomain = "blob";

            internal static class Append
            {
                public const int MaxAppendBlockBytes = 4 * Constants.MB; // 4MB
                public const int MaxBlocks = 50000;
            }

            internal static class Block
            {
                public const int DefaultConcurrentTransfersCount = 5;
                public const int DefaultInitalDownloadRangeSize = 256 * Constants.MB; // 256 MB
                public const int Pre_2019_12_12_MaxUploadBytes = 256 * Constants.MB; // 256 MB
                public const long MaxUploadBytes = 5000L * Constants.MB; // 5000MB
                public const int MaxDownloadBytes = 256 * Constants.MB; // 256MB
                public const int Pre_2019_12_12_MaxStageBytes = 100 * Constants.MB; // 100 MB
                public const long MaxStageBytes = 4000L * Constants.MB; // 4000MB
                public const int MaxBlocks = 50000;
            }

            internal static class Container
            {
                /// <summary>
                /// The Azure Storage name used to identify a storage account's root container.
                /// </summary>
                public const string RootName = "$root";

                /// <summary>
                /// The Azure Storage name used to identify a storage account's logs container.
                /// </summary>
                public const string LogsName = "$logs";

                /// <summary>
                /// The Azure Storage name used to identify a storage account's web content container.
                /// </summary>
                public const string WebName = "$web";
            }

            internal static class Lease
            {
                /// <summary>
                /// Lease Duration is set as infinite when passed -1.
                /// </summary>
                public const int InfiniteLeaseDuration = -1;
            }
        }

        /// <summary>
        /// File constant values.
        /// </summary>
        internal static class File
        {
            public const string UriSubDomain = "file";
            public const string FileAttributesNone = "None";
            public const string FileTimeNow = "Now";
            public const string Preserve = "Preserve";
            public const string FilePermissionInherit = "Inherit";
            public const int MaxFilePermissionHeaderSize = 8 * KB;
            public const int MaxFileUpdateRange = 4 * MB;
            public const string FileTimeFormat = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffff'Z'";

            internal static class Lease
            {
                /// <summary>
                /// Lease Duration is set as infinite when passed -1.
                /// </summary>
                public const int InfiniteLeaseDuration = -1;
            }

            internal static class Errors
            {
                public const string ShareUsageBytesOverflow =
                    "ShareUsageBytes exceeds int.MaxValue. Use ShareUsageInBytes instead.";

                public const string LeaseNotPresentWithFileOperation =
                    "LeaseNotPresentWithFileOperation";
            }
        }

        /// <summary>
        /// Data Lake constant values.
        /// </summary>
        internal static class DataLake
        {
            /// <summary>
            /// The blob URI suffix.
            /// </summary>
            public const string BlobUriSuffix = Blob.UriSubDomain;

            /// <summary>
            /// The DFS URI suffix.
            /// </summary>
            public const string DfsUriSuffix = "dfs";

            /// <summary>
            /// The key of the object json object returned for errors.
            /// </summary>
            public const string ErrorKey = "error";

            /// <summary>
            /// The key of the error code returned for errors.
            /// </summary>
            public const string ErrorCodeKey = "code";

            /// <summary>
            /// The key of the error message returned for errors.
            /// </summary>
            public const string ErrorMessageKey = "message";

            /// <summary>
            /// The Azure Storage error codes for Datalake Client.
            /// </summary>
            public const string AlreadyExists = "ContainerAlreadyExists";

            /// <summary>
            /// Default concurrent transfers count.
            /// </summary>
            public const int DefaultConcurrentTransfersCount = 5;

            /// <summary>
            /// Max upload bytes.
            /// </summary>
            public const int MaxAppendBytes = 100 * Constants.MB; // 100 MB

            /// <summary>
            /// Metadata key for isFolder property.
            /// </summary>
            public const string IsDirectoryKey = "hdi_isFolder";
        }

        /// <summary>
        /// Queue constant values.
        /// </summary>
        internal static class Queue
        {
            /// <summary>
            /// QueueMaxMessagesDequeue indicates the maximum number of messages
            /// you can retrieve with each call to Dequeue.
            /// </summary>
            public const int MaxMessagesDequeue = 32;

            /// <summary>
            /// QueueMessageMaxBytes indicates the maximum number of bytes allowed for a message's UTF-8 text.
            /// </summary>
            public const int QueueMessageMaxBytes = 64 * Constants.KB;

            public const int StatusCodeNoContent = 204;

            public const string MessagesUri = "messages";

            public const string UriSubDomain = "queue";
        }

        /// <summary>
        /// ChangeFeed constant values.
        /// </summary>
        internal static class ChangeFeed
        {
            public const string ChangeFeedContainerName = "$blobchangefeed";
            public const string SegmentPrefix = "idx/segments/";
            public const string InitalizationManifestPath = "/0000/";
            public const string InitalizationSegment = "1601";
            public const string MetaSegmentsPath = "meta/segments.json";
            public const long ChunkBlockDownloadSize = MB;
            public const int DefaultPageSize = 512;

            internal static class Event
            {
                public const string Topic = "topic";
                public const string Subject = "subject";
                public const string EventType = "eventType";
                public const string EventTime = "eventTime";
                public const string EventId = "id";
                public const string Data = "data";
                public const string DataVersion = "dataVersion";
                public const string MetadataVersion = "metadataVersion";
            }

            internal static class EventData
            {
                public const string Api = "api";
                public const string ClientRequestId = "clientRequestId";
                public const string RequestId = "requestId";
                public const string Etag = "etag";
                public const string ContentType = "contentType";
                public const string ContentLength = "contentLength";
                public const string BlobType = "blobType";
                public const string BlockBlob = "BlockBlob";
                public const string PageBlob = "pageBlob";
                public const string AppendBlob = "AppendBlob";
                public const string ContentOffset = "contentOffset";
                public const string DestinationUrl = "destinationUrl";
                public const string SourceUrl = "sourceUrl";
                public const string Url = "url";
                public const string Recursive = "recursive";
                public const string Sequencer = "sequencer";
            }
        }

        /// <summary>
        /// Sas constant values.
        /// </summary>
        internal static class Sas
        {
            internal static class Permissions
            {
                public const char Read = 'r';
                public const char Write = 'w';
                public const char Delete = 'd';
                public const char List = 'l';
                public const char Add = 'a';
                public const char Update = 'u';
                public const char Process = 'p';
                public const char Create = 'c';
                public const char Tag = 't';
            }

            internal static class Parameters
            {
                public const string Version = "sv";
                public const string VersionUpper = "SV";
                public const string Services = "ss";
                public const string ServicesUpper = "SS";
                public const string ResourceTypes = "srt";
                public const string ResourceTypesUpper = "SRT";
                public const string Protocol = "spr";
                public const string ProtocolUpper = "SPR";
                public const string StartTime = "st";
                public const string StartTimeUpper = "ST";
                public const string ExpiryTime = "se";
                public const string ExpiryTimeUpper = "SE";
                public const string IPRange = "sip";
                public const string IPRangeUpper = "SIP";
                public const string Identifier = "si";
                public const string IdentifierUpper = "SI";
                public const string Resource = "sr";
                public const string ResourceUpper = "SR";
                public const string Permissions = "sp";
                public const string PermissionsUpper = "SP";
                public const string Signature = "sig";
                public const string SignatureUpper = "SIG";
                public const string KeyObjectId = "skoid";
                public const string KeyObjectIdUpper = "SKOID";
                public const string KeyTenantId = "sktid";
                public const string KeyTenantIdUpper = "SKTID";
                public const string KeyStart = "skt";
                public const string KeyStartUpper = "SKT";
                public const string KeyExpiry = "ske";
                public const string KeyExpiryUpper = "SKE";
                public const string KeyService = "sks";
                public const string KeyServiceUpper = "SKS";
                public const string KeyVersion = "skv";
                public const string KeyVersionUpper = "SKV";
                public const string CacheControl = "rscc";
                public const string CacheControlUpper = "RSCC";
                public const string ContentDisposition = "rscd";
                public const string ContentDispositionUpper = "RSCD";
                public const string ContentEncoding = "rsce";
                public const string ContentEncodingUpper = "RSCE";
                public const string ContentLanguage = "rscl";
                public const string ContentLanguageUpper = "RSCL";
                public const string ContentType = "rsct";
                public const string ContentTypeUpper = "RSCT";
            }

            internal static class Resource
            {
                public const string BlobSnapshot = "bs";
                public const string Blob = "b";
                public const string Container = "c";
                public const string File = "f";
                public const string Share = "s";
            }

            internal static class AccountServices
            {
                public const char Blob = 'b';
                public const char Queue = 'q';
                public const char File = 'f';
                public const char Table = 't';
            }

            internal static class AccountResources
            {
                public const char Service = 's';
                public const char Container = 'c';
                public const char Object = 'o';
            }
        }

        /// <summary>
        /// XML Element Name constant values.
        /// </summary>
        internal static class Xml
        {
            internal const string Code = "Code";
            internal const string Message = "Message";
        }

        internal static class GeoRedundantRead
        {
            internal const string AlternateHostKey = "AlternateHostKey";
            internal const string ResourceNotReplicated = "ResourceNotReplicated";
        }

        internal static class HttpStatusCode
        {
            internal const int NotFound = 404;
        }
    }
}
