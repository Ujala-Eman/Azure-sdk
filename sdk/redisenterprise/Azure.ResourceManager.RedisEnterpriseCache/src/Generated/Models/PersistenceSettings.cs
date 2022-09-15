// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RedisEnterpriseCache.Models
{
    /// <summary> Persistence-related configuration for the RedisEnterprise database. </summary>
    public partial class PersistenceSettings
    {
        /// <summary> Initializes a new instance of PersistenceSettings. </summary>
        public PersistenceSettings()
        {
        }

        /// <summary> Initializes a new instance of PersistenceSettings. </summary>
        /// <param name="isAofEnabled"> Sets whether AOF is enabled. </param>
        /// <param name="isRdbEnabled"> Sets whether RDB is enabled. </param>
        /// <param name="aofFrequency"> Sets the frequency at which data is written to disk. </param>
        /// <param name="rdbFrequency"> Sets the frequency at which a snapshot of the database is created. </param>
        internal PersistenceSettings(bool? isAofEnabled, bool? isRdbEnabled, PersistenceSettingAofFrequency? aofFrequency, PersistenceSettingRdbFrequency? rdbFrequency)
        {
            IsAofEnabled = isAofEnabled;
            IsRdbEnabled = isRdbEnabled;
            AofFrequency = aofFrequency;
            RdbFrequency = rdbFrequency;
        }

        /// <summary> Sets whether AOF is enabled. </summary>
        public bool? IsAofEnabled { get; set; }
        /// <summary> Sets whether RDB is enabled. </summary>
        public bool? IsRdbEnabled { get; set; }
        /// <summary> Sets the frequency at which data is written to disk. </summary>
        public PersistenceSettingAofFrequency? AofFrequency { get; set; }
        /// <summary> Sets the frequency at which a snapshot of the database is created. </summary>
        public PersistenceSettingRdbFrequency? RdbFrequency { get; set; }
    }
}
