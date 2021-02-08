// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.MixedReality.RemoteRendering
{
    /// <summary> The CreateSessionSettings. </summary>
    public partial class RenderingSessionOptions
    {
        /// <summary> Size of the server used for the rendering session. Remote Rendering with Standard size server has a maximum scene size of 20 million polygons. Remote Rendering with Premium size does not enforce a hard maximum, but performance may be degraded if your content exceeds the rendering capabilities of the service. </summary>
        public RenderingServerSize Size { get; }
    }
}
