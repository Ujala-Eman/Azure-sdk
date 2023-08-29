// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Represents a .rdp file. </summary>
    public partial class DevTestLabRdpConnection
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DevTestLabRdpConnection"/>. </summary>
        internal DevTestLabRdpConnection()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabRdpConnection"/>. </summary>
        /// <param name="contents"> The contents of the .rdp file. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DevTestLabRdpConnection(string contents, Dictionary<string, BinaryData> rawData)
        {
            Contents = contents;
            _rawData = rawData;
        }

        /// <summary> The contents of the .rdp file. </summary>
        public string Contents { get; }
    }
}
