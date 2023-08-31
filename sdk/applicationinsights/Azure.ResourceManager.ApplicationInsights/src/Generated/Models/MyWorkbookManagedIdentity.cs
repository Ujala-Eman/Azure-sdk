// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Customer Managed Identity. </summary>
    public partial class MyWorkbookManagedIdentity
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MyWorkbookManagedIdentity"/>. </summary>
        public MyWorkbookManagedIdentity()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MyWorkbookManagedIdentity"/>. </summary>
        /// <param name="userAssignedIdentities"> Customer Managed Identity. </param>
        /// <param name="identityType"> The identity type. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MyWorkbookManagedIdentity(MyWorkbookUserAssignedIdentities userAssignedIdentities, MyWorkbookManagedIdentityType? identityType, Dictionary<string, BinaryData> rawData)
        {
            UserAssignedIdentities = userAssignedIdentities;
            IdentityType = identityType;
            _rawData = rawData;
        }

        /// <summary> Customer Managed Identity. </summary>
        public MyWorkbookUserAssignedIdentities UserAssignedIdentities { get; set; }
        /// <summary> The identity type. </summary>
        public MyWorkbookManagedIdentityType? IdentityType { get; set; }
    }
}
