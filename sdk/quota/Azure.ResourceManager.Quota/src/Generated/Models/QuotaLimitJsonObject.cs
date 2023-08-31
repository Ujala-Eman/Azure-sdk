// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary>
    /// LimitJson abstract class.
    /// Please note <see cref="QuotaLimitJsonObject"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="QuotaLimitObject"/>.
    /// </summary>
    [AbstractTypeDeserializer(typeof(UnknownLimitJsonObject))]
    public abstract partial class QuotaLimitJsonObject
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="QuotaLimitJsonObject"/>. </summary>
        protected QuotaLimitJsonObject()
        {
        }

        /// <summary> Initializes a new instance of <see cref="QuotaLimitJsonObject"/>. </summary>
        /// <param name="limitObjectType"> The limit object type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal QuotaLimitJsonObject(LimitType limitObjectType, Dictionary<string, BinaryData> rawData)
        {
            LimitObjectType = limitObjectType;
            _rawData = rawData;
        }

        /// <summary> The limit object type. </summary>
        internal LimitType LimitObjectType { get; set; }
    }
}
