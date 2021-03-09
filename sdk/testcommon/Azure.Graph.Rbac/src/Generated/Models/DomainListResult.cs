// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    /// <summary> Server response for Get tenant domains API call. </summary>
    internal partial class DomainListResult
    {
        /// <summary> Initializes a new instance of DomainListResult. </summary>
        internal DomainListResult()
        {
            Value = new ChangeTrackingList<Domain>();
        }

        /// <summary> Initializes a new instance of DomainListResult. </summary>
        /// <param name="value"> the list of domains. </param>
        internal DomainListResult(IReadOnlyList<Domain> value)
        {
            Value = value;
        }

        /// <summary> the list of domains. </summary>
        public IReadOnlyList<Domain> Value { get; }
    }
}
