// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> The UnknownSourceShareSynchronizationSetting. </summary>
    internal partial class UnknownSourceShareSynchronizationSetting : SourceShareSynchronizationSetting
    {
        /// <summary> Initializes a new instance of <see cref="UnknownSourceShareSynchronizationSetting"/>. </summary>
        /// <param name="kind"> Kind of synchronization setting on share. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownSourceShareSynchronizationSetting(SourceShareSynchronizationSettingKind kind, Dictionary<string, BinaryData> rawData) : base(kind, rawData)
        {
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownSourceShareSynchronizationSetting"/> for deserialization. </summary>
        internal UnknownSourceShareSynchronizationSetting()
        {
        }
    }
}
