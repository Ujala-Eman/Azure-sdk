// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> The details of the authorization for the resource. </summary>
    public partial class ResourceAuthorization
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResourceAuthorization"/>. </summary>
        internal ResourceAuthorization()
        {
            Evidence = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="ResourceAuthorization"/>. </summary>
        /// <param name="scope"> The scope of the authorization. </param>
        /// <param name="action"> The action being requested. </param>
        /// <param name="evidence"> The evidence for the authorization. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceAuthorization(string scope, string action, IReadOnlyDictionary<string, string> evidence, Dictionary<string, BinaryData> rawData)
        {
            Scope = scope;
            Action = action;
            Evidence = evidence;
            _rawData = rawData;
        }

        /// <summary> The scope of the authorization. </summary>
        public string Scope { get; }
        /// <summary> The action being requested. </summary>
        public string Action { get; }
        /// <summary> The evidence for the authorization. </summary>
        public IReadOnlyDictionary<string, string> Evidence { get; }
    }
}
