// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.KubernetesConfiguration.Models
{
    /// <summary> Parameters to authenticate using a Managed Identity. </summary>
    internal partial class KubernetesAzureBlobManagedIdentityUpdateContent
    {
        /// <summary> Initializes a new instance of <see cref="KubernetesAzureBlobManagedIdentityUpdateContent"/>. </summary>
        public KubernetesAzureBlobManagedIdentityUpdateContent()
        {
        }

        /// <summary> The client Id for authenticating a Managed Identity. </summary>
        public string ClientId { get; set; }
    }
}
