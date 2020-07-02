// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> List of session IDs. </summary>
    public partial class SessionIds
    {
        /// <summary> Initializes a new instance of SessionIds. </summary>
        public SessionIds()
        {
            SessionIdsValue = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of SessionIds. </summary>
        /// <param name="sessionIdsValue"> List of session IDs. </param>
        internal SessionIds(IList<string> sessionIdsValue)
        {
            SessionIdsValue = sessionIdsValue;
        }

        /// <summary> List of session IDs. </summary>
        public IList<string> SessionIdsValue { get; }
    }
}
