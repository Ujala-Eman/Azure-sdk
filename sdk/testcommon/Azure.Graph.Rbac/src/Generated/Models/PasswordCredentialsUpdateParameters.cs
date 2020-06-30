// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.Graph.Rbac.Models
{
    /// <summary> Request parameters for a PasswordCredentials update operation. </summary>
    public partial class PasswordCredentialsUpdateParameters
    {
        /// <summary> Initializes a new instance of PasswordCredentialsUpdateParameters. </summary>
        /// <param name="value"> A collection of PasswordCredentials. </param>
        public PasswordCredentialsUpdateParameters(IEnumerable<PasswordCredential> value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of PasswordCredentialsUpdateParameters. </summary>
        /// <param name="value"> A collection of PasswordCredentials. </param>
        internal PasswordCredentialsUpdateParameters(IList<PasswordCredential> value)
        {
            Value = value ?? new List<PasswordCredential>();
        }

        /// <summary> A collection of PasswordCredentials. </summary>
        public IList<PasswordCredential> Value { get; }
    }
}
