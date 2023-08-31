// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> VMwareCbt security profile input. </summary>
    public partial class VMwareCbtSecurityProfileProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VMwareCbtSecurityProfileProperties"/>. </summary>
        public VMwareCbtSecurityProfileProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VMwareCbtSecurityProfileProperties"/>. </summary>
        /// <param name="targetVmSecurityType"> The target VM security type. </param>
        /// <param name="isTargetVmSecureBootEnabled"> A value indicating whether secure boot to be enabled. </param>
        /// <param name="isTargetVmTpmEnabled"> A value indicating whether trusted platform module to be enabled. </param>
        /// <param name="isTargetVmIntegrityMonitoringEnabled"> A value indicating whether integrity monitoring to be enabled. </param>
        /// <param name="isTargetVmConfidentialEncryptionEnabled"> A value indicating whether confidential compute encryption to be enabled. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VMwareCbtSecurityProfileProperties(SiteRecoveryVmSecurityType? targetVmSecurityType, string isTargetVmSecureBootEnabled, string isTargetVmTpmEnabled, string isTargetVmIntegrityMonitoringEnabled, string isTargetVmConfidentialEncryptionEnabled, Dictionary<string, BinaryData> rawData)
        {
            TargetVmSecurityType = targetVmSecurityType;
            IsTargetVmSecureBootEnabled = isTargetVmSecureBootEnabled;
            IsTargetVmTpmEnabled = isTargetVmTpmEnabled;
            IsTargetVmIntegrityMonitoringEnabled = isTargetVmIntegrityMonitoringEnabled;
            IsTargetVmConfidentialEncryptionEnabled = isTargetVmConfidentialEncryptionEnabled;
            _rawData = rawData;
        }

        /// <summary> The target VM security type. </summary>
        public SiteRecoveryVmSecurityType? TargetVmSecurityType { get; set; }
        /// <summary> A value indicating whether secure boot to be enabled. </summary>
        public string IsTargetVmSecureBootEnabled { get; set; }
        /// <summary> A value indicating whether trusted platform module to be enabled. </summary>
        public string IsTargetVmTpmEnabled { get; set; }
        /// <summary> A value indicating whether integrity monitoring to be enabled. </summary>
        public string IsTargetVmIntegrityMonitoringEnabled { get; set; }
        /// <summary> A value indicating whether confidential compute encryption to be enabled. </summary>
        public string IsTargetVmConfidentialEncryptionEnabled { get; set; }
    }
}
