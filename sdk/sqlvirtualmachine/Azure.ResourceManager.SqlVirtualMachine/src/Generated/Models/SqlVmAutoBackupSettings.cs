// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    /// <summary> Configure backups for databases in your SQL virtual machine. </summary>
    public partial class SqlVmAutoBackupSettings
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SqlVmAutoBackupSettings"/>. </summary>
        public SqlVmAutoBackupSettings()
        {
            DaysOfWeek = new ChangeTrackingList<SqlVmAutoBackupDayOfWeek>();
        }

        /// <summary> Initializes a new instance of <see cref="SqlVmAutoBackupSettings"/>. </summary>
        /// <param name="isEnabled"> Enable or disable autobackup on SQL virtual machine. </param>
        /// <param name="isEncryptionEnabled"> Enable or disable encryption for backup on SQL virtual machine. </param>
        /// <param name="retentionPeriodInDays"> Retention period of backup: 1-90 days. </param>
        /// <param name="storageAccountUri"> Storage account url where backup will be taken to. </param>
        /// <param name="storageContainerName"> Storage container name where backup will be taken to. </param>
        /// <param name="storageAccessKey"> Storage account key where backup will be taken to. </param>
        /// <param name="password"> Password for encryption on backup. </param>
        /// <param name="areSystemDbsIncludedInBackup"> Include or exclude system databases from auto backup. </param>
        /// <param name="backupScheduleType"> Backup schedule type. </param>
        /// <param name="fullBackupFrequency"> Frequency of full backups. In both cases, full backups begin during the next scheduled time window. </param>
        /// <param name="daysOfWeek"> Days of the week for the backups when FullBackupFrequency is set to Weekly. </param>
        /// <param name="fullBackupStartHour"> Start time of a given day during which full backups can take place. 0-23 hours. </param>
        /// <param name="fullBackupWindowHours"> Duration of the time window of a given day during which full backups can take place. 1-23 hours. </param>
        /// <param name="logBackupFrequency"> Frequency of log backups. 5-60 minutes. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlVmAutoBackupSettings(bool? isEnabled, bool? isEncryptionEnabled, int? retentionPeriodInDays, Uri storageAccountUri, string storageContainerName, string storageAccessKey, string password, bool? areSystemDbsIncludedInBackup, SqVmBackupScheduleType? backupScheduleType, SqlVmFullBackupFrequency? fullBackupFrequency, IList<SqlVmAutoBackupDayOfWeek> daysOfWeek, int? fullBackupStartHour, int? fullBackupWindowHours, int? logBackupFrequency, Dictionary<string, BinaryData> rawData)
        {
            IsEnabled = isEnabled;
            IsEncryptionEnabled = isEncryptionEnabled;
            RetentionPeriodInDays = retentionPeriodInDays;
            StorageAccountUri = storageAccountUri;
            StorageContainerName = storageContainerName;
            StorageAccessKey = storageAccessKey;
            Password = password;
            AreSystemDbsIncludedInBackup = areSystemDbsIncludedInBackup;
            BackupScheduleType = backupScheduleType;
            FullBackupFrequency = fullBackupFrequency;
            DaysOfWeek = daysOfWeek;
            FullBackupStartHour = fullBackupStartHour;
            FullBackupWindowHours = fullBackupWindowHours;
            LogBackupFrequency = logBackupFrequency;
            _rawData = rawData;
        }

        /// <summary> Enable or disable autobackup on SQL virtual machine. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> Enable or disable encryption for backup on SQL virtual machine. </summary>
        public bool? IsEncryptionEnabled { get; set; }
        /// <summary> Retention period of backup: 1-90 days. </summary>
        public int? RetentionPeriodInDays { get; set; }
        /// <summary> Storage account url where backup will be taken to. </summary>
        public Uri StorageAccountUri { get; set; }
        /// <summary> Storage container name where backup will be taken to. </summary>
        public string StorageContainerName { get; set; }
        /// <summary> Storage account key where backup will be taken to. </summary>
        public string StorageAccessKey { get; set; }
        /// <summary> Password for encryption on backup. </summary>
        public string Password { get; set; }
        /// <summary> Include or exclude system databases from auto backup. </summary>
        public bool? AreSystemDbsIncludedInBackup { get; set; }
        /// <summary> Backup schedule type. </summary>
        public SqVmBackupScheduleType? BackupScheduleType { get; set; }
        /// <summary> Frequency of full backups. In both cases, full backups begin during the next scheduled time window. </summary>
        public SqlVmFullBackupFrequency? FullBackupFrequency { get; set; }
        /// <summary> Days of the week for the backups when FullBackupFrequency is set to Weekly. </summary>
        public IList<SqlVmAutoBackupDayOfWeek> DaysOfWeek { get; }
        /// <summary> Start time of a given day during which full backups can take place. 0-23 hours. </summary>
        public int? FullBackupStartHour { get; set; }
        /// <summary> Duration of the time window of a given day during which full backups can take place. 1-23 hours. </summary>
        public int? FullBackupWindowHours { get; set; }
        /// <summary> Frequency of log backups. 5-60 minutes. </summary>
        public int? LogBackupFrequency { get; set; }
    }
}
