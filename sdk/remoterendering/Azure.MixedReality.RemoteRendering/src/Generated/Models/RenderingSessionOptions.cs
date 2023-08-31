// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.MixedReality.RemoteRendering
{
    /// <summary> Settings of the session to be created. </summary>
    public partial class RenderingSessionOptions
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RenderingSessionOptions"/>. </summary>
        /// <param name="maxLeaseTimeMinutes"> The time in minutes the session will run after reaching the 'Ready' state. It has to be between 0 and 1440. </param>
        /// <param name="size"> The size of the server used for the rendering session. The size impacts the number of polygons the server can render. Refer to https://docs.microsoft.com/azure/remote-rendering/reference/vm-sizes for details. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RenderingSessionOptions(int maxLeaseTimeMinutes, RenderingServerSize size, Dictionary<string, BinaryData> rawData)
        {
            MaxLeaseTimeMinutes = maxLeaseTimeMinutes;
            Size = size;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="RenderingSessionOptions"/> for deserialization. </summary>
        internal RenderingSessionOptions()
        {
        }
        /// <summary> The size of the server used for the rendering session. The size impacts the number of polygons the server can render. Refer to https://docs.microsoft.com/azure/remote-rendering/reference/vm-sizes for details. </summary>
        public RenderingServerSize Size { get; }
    }
}
