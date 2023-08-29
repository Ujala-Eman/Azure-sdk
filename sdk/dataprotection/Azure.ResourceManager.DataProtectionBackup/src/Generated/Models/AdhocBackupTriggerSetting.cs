// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Adhoc backup trigger option. </summary>
    internal partial class AdhocBackupTriggerSetting
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AdhocBackupTriggerSetting"/>. </summary>
        public AdhocBackupTriggerSetting()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AdhocBackupTriggerSetting"/>. </summary>
        /// <param name="retentionTagOverride"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AdhocBackupTriggerSetting(string retentionTagOverride, Dictionary<string, BinaryData> rawData)
        {
            RetentionTagOverride = retentionTagOverride;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the retention tag override. </summary>
        public string RetentionTagOverride { get; set; }
    }
}
