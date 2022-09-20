// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Cache Upgrade Settings. </summary>
    public partial class StorageCacheUpgradeSettings
    {
        /// <summary> Initializes a new instance of StorageCacheUpgradeSettings. </summary>
        public StorageCacheUpgradeSettings()
        {
        }

        /// <summary> Initializes a new instance of StorageCacheUpgradeSettings. </summary>
        /// <param name="enableUpgradeSchedule"> True if the user chooses to select an installation time between now and firmwareUpdateDeadline. Else the firmware will automatically be installed after firmwareUpdateDeadline if not triggered earlier via the upgrade operation. </param>
        /// <param name="scheduledOn"> When upgradeScheduleEnabled is true, this field holds the user-chosen upgrade time. At the user-chosen time, the firmware update will automatically be installed on the cache. </param>
        internal StorageCacheUpgradeSettings(bool? enableUpgradeSchedule, DateTimeOffset? scheduledOn)
        {
            EnableUpgradeSchedule = enableUpgradeSchedule;
            ScheduledOn = scheduledOn;
        }

        /// <summary> True if the user chooses to select an installation time between now and firmwareUpdateDeadline. Else the firmware will automatically be installed after firmwareUpdateDeadline if not triggered earlier via the upgrade operation. </summary>
        public bool? EnableUpgradeSchedule { get; set; }
        /// <summary> When upgradeScheduleEnabled is true, this field holds the user-chosen upgrade time. At the user-chosen time, the firmware update will automatically be installed on the cache. </summary>
        public DateTimeOffset? ScheduledOn { get; set; }
    }
}
