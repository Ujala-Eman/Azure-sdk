// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Custom domain of app resource payload. </summary>
    public partial class CustomDomainProperties
    {
        /// <summary> Initializes a new instance of CustomDomainProperties. </summary>
        public CustomDomainProperties()
        {
        }

        /// <summary> Initializes a new instance of CustomDomainProperties. </summary>
        /// <param name="thumbprint"> The thumbprint of bound certificate. </param>
        /// <param name="appName"> The app name of domain. </param>
        /// <param name="certName"> The bound certificate name of domain. </param>
        internal CustomDomainProperties(string thumbprint, string appName, string certName)
        {
            Thumbprint = thumbprint;
            AppName = appName;
            CertName = certName;
        }

        /// <summary> The thumbprint of bound certificate. </summary>
        public string Thumbprint { get; set; }
        /// <summary> The app name of domain. </summary>
        public string AppName { get; }
        /// <summary> The bound certificate name of domain. </summary>
        public string CertName { get; set; }
    }
}
