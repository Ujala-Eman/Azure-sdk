// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.Security.KeyVault.Administration.Models;

namespace Azure.Security.KeyVault.Administration
{
    /// <summary> Role definition permissions. </summary>
    public partial class KeyVaultPermission
    {
        /// <summary> Initializes a new instance of KeyVaultPermission. </summary>
        public KeyVaultPermission()
        {
            AllowedActions = new ChangeTrackingList<string>();
            DeniedActions = new ChangeTrackingList<string>();
            AllowedDataActions = new ChangeTrackingList<DataAction>();
            DeniedDataActions = new ChangeTrackingList<DataAction>();
        }

        /// <summary> Initializes a new instance of KeyVaultPermission. </summary>
        /// <param name="allowedActions"> Action permissions that are granted. </param>
        /// <param name="deniedActions"> Action permissions that are excluded but not denied. They may be granted by other role definitions assigned to a principal. </param>
        /// <param name="allowedDataActions"> Data action permissions that are granted. </param>
        /// <param name="deniedDataActions"> Data action permissions that are excluded but not denied. They may be granted by other role definitions assigned to a principal. </param>
        internal KeyVaultPermission(IList<string> allowedActions, IList<string> deniedActions, IList<DataAction> allowedDataActions, IList<DataAction> deniedDataActions)
        {
            AllowedActions = allowedActions;
            DeniedActions = deniedActions;
            AllowedDataActions = allowedDataActions;
            DeniedDataActions = deniedDataActions;
        }
    }
}
