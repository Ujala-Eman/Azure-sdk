// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> The ClearRange. </summary>
    internal partial class ClearRange
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ClearRange"/>. </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        internal ClearRange(long start, long end)
        {
            Start = start;
            End = end;
        }

        /// <summary> Initializes a new instance of <see cref="ClearRange"/>. </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ClearRange(long start, long end, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Start = start;
            End = end;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ClearRange"/> for deserialization. </summary>
        internal ClearRange()
        {
        }

        /// <summary> Gets the start. </summary>
        public long Start { get; }
        /// <summary> Gets the end. </summary>
        public long End { get; }
    }
}
