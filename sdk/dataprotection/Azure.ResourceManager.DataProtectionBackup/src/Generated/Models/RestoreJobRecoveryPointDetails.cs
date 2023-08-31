// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> The RestoreJobRecoveryPointDetails. </summary>
    public partial class RestoreJobRecoveryPointDetails
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RestoreJobRecoveryPointDetails"/>. </summary>
        internal RestoreJobRecoveryPointDetails()
        {
        }

        /// <summary> Initializes a new instance of <see cref="RestoreJobRecoveryPointDetails"/>. </summary>
        /// <param name="recoveryPointId"></param>
        /// <param name="recoverOn"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RestoreJobRecoveryPointDetails(string recoveryPointId, DateTimeOffset? recoverOn, Dictionary<string, BinaryData> rawData)
        {
            RecoveryPointId = recoveryPointId;
            RecoverOn = recoverOn;
            _rawData = rawData;
        }

        /// <summary> Gets the recovery point id. </summary>
        public string RecoveryPointId { get; }
        /// <summary> Gets the recover on. </summary>
        public DateTimeOffset? RecoverOn { get; }
    }
}
