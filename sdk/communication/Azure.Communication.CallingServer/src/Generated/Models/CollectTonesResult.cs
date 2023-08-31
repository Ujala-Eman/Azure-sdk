// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    /// <summary> The CollectTonesResult. </summary>
    public partial class CollectTonesResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="CollectTonesResult"/>. </summary>
        internal CollectTonesResult()
        {
            Tones = new ChangeTrackingList<DtmfTone>();
        }

        /// <summary> Initializes a new instance of <see cref="CollectTonesResult"/>. </summary>
        /// <param name="tones"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal CollectTonesResult(IReadOnlyList<DtmfTone> tones, Dictionary<string, BinaryData> rawData)
        {
            Tones = tones;
            _rawData = rawData;
        }
    }
}
