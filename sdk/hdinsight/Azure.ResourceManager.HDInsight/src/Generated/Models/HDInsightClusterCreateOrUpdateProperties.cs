// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The cluster create parameters. </summary>
    public partial class HDInsightClusterCreateOrUpdateProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterCreateOrUpdateProperties"/>. </summary>
        public HDInsightClusterCreateOrUpdateProperties()
        {
            PrivateLinkConfigurations = new ChangeTrackingList<HDInsightPrivateLinkConfiguration>();
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterCreateOrUpdateProperties"/>. </summary>
        /// <param name="clusterVersion"> The version of the cluster. </param>
        /// <param name="osType"> The type of operating system. </param>
        /// <param name="tier"> The cluster tier. </param>
        /// <param name="clusterDefinition"> The cluster definition. </param>
        /// <param name="kafkaRestProperties"> The cluster kafka rest proxy configuration. </param>
        /// <param name="securityProfile"> The security profile. </param>
        /// <param name="computeProfile"> The compute profile. </param>
        /// <param name="storageProfile"> The storage profile. </param>
        /// <param name="diskEncryptionProperties"> The disk encryption properties. </param>
        /// <param name="encryptionInTransitProperties"> The encryption-in-transit properties. </param>
        /// <param name="minSupportedTlsVersion"> The minimal supported tls version. </param>
        /// <param name="networkProperties"> The network properties. </param>
        /// <param name="computeIsolationProperties"> The compute isolation properties. </param>
        /// <param name="privateLinkConfigurations"> The private link configurations. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightClusterCreateOrUpdateProperties(string clusterVersion, HDInsightOSType? osType, HDInsightTier? tier, HDInsightClusterDefinition clusterDefinition, KafkaRestProperties kafkaRestProperties, HDInsightSecurityProfile securityProfile, ComputeProfile computeProfile, StorageProfile storageProfile, HDInsightDiskEncryptionProperties diskEncryptionProperties, EncryptionInTransitProperties encryptionInTransitProperties, string minSupportedTlsVersion, HDInsightClusterNetworkProperties networkProperties, HDInsightComputeIsolationProperties computeIsolationProperties, IList<HDInsightPrivateLinkConfiguration> privateLinkConfigurations, Dictionary<string, BinaryData> rawData)
        {
            ClusterVersion = clusterVersion;
            OSType = osType;
            Tier = tier;
            ClusterDefinition = clusterDefinition;
            KafkaRestProperties = kafkaRestProperties;
            SecurityProfile = securityProfile;
            ComputeProfile = computeProfile;
            StorageProfile = storageProfile;
            DiskEncryptionProperties = diskEncryptionProperties;
            EncryptionInTransitProperties = encryptionInTransitProperties;
            MinSupportedTlsVersion = minSupportedTlsVersion;
            NetworkProperties = networkProperties;
            ComputeIsolationProperties = computeIsolationProperties;
            PrivateLinkConfigurations = privateLinkConfigurations;
            _rawData = rawData;
        }

        /// <summary> The version of the cluster. </summary>
        public string ClusterVersion { get; set; }
        /// <summary> The type of operating system. </summary>
        public HDInsightOSType? OSType { get; set; }
        /// <summary> The cluster tier. </summary>
        public HDInsightTier? Tier { get; set; }
        /// <summary> The cluster definition. </summary>
        public HDInsightClusterDefinition ClusterDefinition { get; set; }
        /// <summary> The cluster kafka rest proxy configuration. </summary>
        public KafkaRestProperties KafkaRestProperties { get; set; }
        /// <summary> The security profile. </summary>
        public HDInsightSecurityProfile SecurityProfile { get; set; }
        /// <summary> The compute profile. </summary>
        internal ComputeProfile ComputeProfile { get; set; }
        /// <summary> The list of roles in the cluster. </summary>
        public IList<HDInsightClusterRole> ComputeRoles
        {
            get
            {
                if (ComputeProfile is null)
                    ComputeProfile = new ComputeProfile();
                return ComputeProfile.Roles;
            }
        }

        /// <summary> The storage profile. </summary>
        internal StorageProfile StorageProfile { get; set; }
        /// <summary> The list of storage accounts in the cluster. </summary>
        public IList<HDInsightStorageAccountInfo> StorageAccounts
        {
            get
            {
                if (StorageProfile is null)
                    StorageProfile = new StorageProfile();
                return StorageProfile.StorageAccounts;
            }
        }

        /// <summary> The disk encryption properties. </summary>
        public HDInsightDiskEncryptionProperties DiskEncryptionProperties { get; set; }
        /// <summary> The encryption-in-transit properties. </summary>
        internal EncryptionInTransitProperties EncryptionInTransitProperties { get; set; }
        /// <summary> Indicates whether or not inter cluster node communication is encrypted in transit. </summary>
        public bool? IsEncryptionInTransitEnabled
        {
            get => EncryptionInTransitProperties is null ? default : EncryptionInTransitProperties.IsEncryptionInTransitEnabled;
            set
            {
                if (EncryptionInTransitProperties is null)
                    EncryptionInTransitProperties = new EncryptionInTransitProperties();
                EncryptionInTransitProperties.IsEncryptionInTransitEnabled = value;
            }
        }

        /// <summary> The minimal supported tls version. </summary>
        public string MinSupportedTlsVersion { get; set; }
        /// <summary> The network properties. </summary>
        public HDInsightClusterNetworkProperties NetworkProperties { get; set; }
        /// <summary> The compute isolation properties. </summary>
        public HDInsightComputeIsolationProperties ComputeIsolationProperties { get; set; }
        /// <summary> The private link configurations. </summary>
        public IList<HDInsightPrivateLinkConfiguration> PrivateLinkConfigurations { get; }
    }
}
