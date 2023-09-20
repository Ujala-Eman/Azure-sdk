namespace System.ServiceModel.Rest
{
    public partial class KeyCredential
    {
        public KeyCredential(string key) { }
        public string Key { get { throw null; } }
        public void Update(string key) { }
    }
    public abstract partial class NullableResult<T>
    {
        protected NullableResult() { }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public abstract bool HasValue { get; }
        public abstract T? Value { get; }
        public abstract System.ServiceModel.Rest.Result GetRawResult();
    }
    public partial class PipelineOptions
    {
        public PipelineOptions() { }
        public System.Threading.CancellationToken CancellationToken { get { throw null; } set { } }
        public static System.Threading.CancellationToken DefaultCancellationToken { get { throw null; } set { } }
        public System.ServiceModel.Rest.ResultErrorOptions ResultErrorOptions { get { throw null; } set { } }
    }
    public partial class RequestErrorException : System.Exception
    {
        protected RequestErrorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public RequestErrorException(System.ServiceModel.Rest.Result result) { }
        protected RequestErrorException(System.ServiceModel.Rest.Result result, string message, System.Exception? innerException) { }
        public int Status { get { throw null; } }
    }
    public abstract partial class Result : System.IDisposable
    {
        protected Result() { }
        public virtual System.BinaryData Content { get { throw null; } }
        public abstract System.IO.Stream? ContentStream { get; set; }
        public virtual bool IsError { get { throw null; } set { } }
        public abstract int Status { get; }
        public abstract void Dispose();
        public static System.ServiceModel.Rest.Result<T> FromValue<T>(T value, System.ServiceModel.Rest.Result result) { throw null; }
        protected abstract bool TryGetHeader(string name, out string? value);
        public bool TryGetHeaderValue(string name, out string? value) { throw null; }
    }
    [System.FlagsAttribute]
    public enum ResultErrorOptions
    {
        Default = 0,
        NoThrow = 1,
    }
    public abstract partial class Result<T> : System.ServiceModel.Rest.NullableResult<T>
    {
        protected Result() { }
    }
    public partial class TelemetrySource
    {
        public TelemetrySource(System.ServiceModel.Rest.PipelineOptions options, bool suppressNestedClientActivities = true) { }
        public System.ServiceModel.Rest.TelemetrySpan CreateSpan(string name) { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct TelemetrySpan : System.IDisposable
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public void Dispose() { }
        public void Failed(System.Exception exception) { }
        public void Start() { }
    }
}
namespace System.ServiceModel.Rest.Core
{
    public abstract partial class RequestBody : System.IDisposable
    {
        protected RequestBody() { }
        public abstract void Dispose();
        public abstract bool TryComputeLength(out long length);
        public abstract void WriteTo(System.IO.Stream stream, System.Threading.CancellationToken cancellation);
        public abstract System.Threading.Tasks.Task WriteToAsync(System.IO.Stream stream, System.Threading.CancellationToken cancellation);
    }
    public partial class ResponseErrorClassifier
    {
        public ResponseErrorClassifier() { }
        public virtual bool IsErrorResponse(System.ServiceModel.Rest.Core.RestMessage message) { throw null; }
    }
    public abstract partial class RestMessage : System.IDisposable
    {
        protected RestMessage() { }
        public System.Threading.CancellationToken CancellationToken { get { throw null; } set { } }
        public abstract System.ServiceModel.Rest.Result? Result { get; }
        public abstract void Dispose();
    }
}
namespace System.ServiceModel.Rest.Core.Pipeline
{
    public abstract partial class MessagePipeline
    {
        protected MessagePipeline() { }
        public abstract System.ServiceModel.Rest.Core.RestMessage CreateRestMessage(System.ServiceModel.Rest.PipelineOptions options, System.ServiceModel.Rest.Core.ResponseErrorClassifier classifier);
        public abstract void Send(System.ServiceModel.Rest.Core.RestMessage message, System.Threading.CancellationToken cancellationToken);
        public abstract System.Threading.Tasks.Task SendAsync(System.ServiceModel.Rest.Core.RestMessage message, System.Threading.CancellationToken cancellationToken);
    }
}
namespace System.ServiceModel.Rest.Shared
{
    public partial class ClientUtilities
    {
        public ClientUtilities() { }
        public static void AssertNotNullOrEmpty(string value, string name) { }
        public static void AssertNotNull<T>(T value, string name) { }
    }
}
namespace System.ServiceModel.Rest.Shared.Core
{
    public partial class RequestUri
    {
        public RequestUri() { }
        protected bool HasPath { get { throw null; } }
        protected bool HasQuery { get { throw null; } }
        public string? Host { get { throw null; } set { } }
        public string Path { get { throw null; } set { } }
        public string PathAndQuery { get { throw null; } }
        public int Port { get { throw null; } set { } }
        public string Query { get { throw null; } set { } }
        public string? Scheme { get { throw null; } set { } }
        public virtual void AppendPath(System.ReadOnlySpan<char> value, bool escape) { }
        public virtual void AppendPath(string value) { }
        public virtual void AppendPath(string value, bool escape) { }
        public virtual void AppendQuery(System.ReadOnlySpan<char> name, System.ReadOnlySpan<char> value, bool escapeValue) { }
        public virtual void AppendQuery(string name, string value) { }
        public virtual void AppendQuery(string name, string value, bool escapeValue) { }
        public virtual void AppendRaw(string value, bool escape) { }
        public virtual void AppendRawNextLink(string nextLink, bool escape) { }
        public virtual void Reset(System.Uri value) { }
        public override string ToString() { throw null; }
        public virtual System.Uri ToUri() { throw null; }
    }
}
namespace System.ServiceModel.Rest.Shared.Core.Pipeline
{
    public static partial class PipelineProtocolExtensions
    {
        public static System.ServiceModel.Rest.Result<bool> ProcessHeadAsBoolMessage(this System.ServiceModel.Rest.Core.Pipeline.MessagePipeline pipeline, System.ServiceModel.Rest.Core.RestMessage message, System.ServiceModel.Rest.TelemetrySource clientDiagnostics, System.ServiceModel.Rest.PipelineOptions? requestContext) { throw null; }
        public static System.Threading.Tasks.ValueTask<System.ServiceModel.Rest.Result<bool>> ProcessHeadAsBoolMessageAsync(this System.ServiceModel.Rest.Core.Pipeline.MessagePipeline pipeline, System.ServiceModel.Rest.Core.RestMessage message, System.ServiceModel.Rest.TelemetrySource clientDiagnostics, System.ServiceModel.Rest.PipelineOptions? requestContext) { throw null; }
        public static System.ServiceModel.Rest.Result ProcessMessage(this System.ServiceModel.Rest.Core.Pipeline.MessagePipeline pipeline, System.ServiceModel.Rest.Core.RestMessage message, System.ServiceModel.Rest.PipelineOptions? requestContext, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.ValueTask<System.ServiceModel.Rest.Result> ProcessMessageAsync(this System.ServiceModel.Rest.Core.Pipeline.MessagePipeline pipeline, System.ServiceModel.Rest.Core.RestMessage message, System.ServiceModel.Rest.PipelineOptions? requestContext, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
}
namespace System.ServiceModel.Rest.Shared.Serialization
{
    public partial interface IUtf8JsonWriteable
    {
        void Write(System.Text.Json.Utf8JsonWriter writer);
    }
}
