// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    /// <summary> List of Vpn-Sites. </summary>
    public partial class GetVpnSitesConfigurationRequest
    {
        /// <summary> Initializes a new instance of GetVpnSitesConfigurationRequest. </summary>
        /// <param name="outputBlobSasUrl"> The sas-url to download the configurations for vpn-sites. </param>
        public GetVpnSitesConfigurationRequest(string outputBlobSasUrl)
        {
            if (outputBlobSasUrl == null)
            {
                throw new ArgumentNullException(nameof(outputBlobSasUrl));
            }

            VpnSites = new ChangeTrackingList<string>();
            OutputBlobSasUrl = outputBlobSasUrl;
        }

        /// <summary> Initializes a new instance of GetVpnSitesConfigurationRequest. </summary>
        /// <param name="vpnSites"> List of resource-ids of the vpn-sites for which config is to be downloaded. </param>
        /// <param name="outputBlobSasUrl"> The sas-url to download the configurations for vpn-sites. </param>
        internal GetVpnSitesConfigurationRequest(IList<string> vpnSites, string outputBlobSasUrl)
        {
            VpnSites = vpnSites;
            OutputBlobSasUrl = outputBlobSasUrl;
        }

        /// <summary> List of resource-ids of the vpn-sites for which config is to be downloaded. </summary>
        public IList<string> VpnSites { get; }
        /// <summary> The sas-url to download the configurations for vpn-sites. </summary>
        public string OutputBlobSasUrl { get; }
    }
}
