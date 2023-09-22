// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Parameters for Kubernetes Cluster Backup Datasource. </summary>
    public partial class KubernetesClusterBackupDataSourceSettings : BackupDataSourceSettings
    {
        /// <summary> Initializes a new instance of KubernetesClusterBackupDataSourceSettings. </summary>
        /// <param name="isSnapshotVolumesEnabled"> Gets or sets the volume snapshot property. This property if enabled will take volume snapshots during backup. </param>
        /// <param name="isClusterScopeResourcesIncluded"> Gets or sets the include cluster resources property. This property if enabled will include cluster scope resources during backup. </param>
        public KubernetesClusterBackupDataSourceSettings(bool isSnapshotVolumesEnabled, bool isClusterScopeResourcesIncluded)
        {
            IsSnapshotVolumesEnabled = isSnapshotVolumesEnabled;
            IsClusterScopeResourcesIncluded = isClusterScopeResourcesIncluded;
            IncludedNamespaces = new ChangeTrackingList<string>();
            ExcludedNamespaces = new ChangeTrackingList<string>();
            IncludedResourceTypes = new ChangeTrackingList<string>();
            ExcludedResourceTypes = new ChangeTrackingList<string>();
            LabelSelectors = new ChangeTrackingList<string>();
            BackupHookReferences = new ChangeTrackingList<NamespacedName>();
            ObjectType = "KubernetesClusterBackupDatasourceParameters";
        }

        /// <summary> Initializes a new instance of KubernetesClusterBackupDataSourceSettings. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        /// <param name="isSnapshotVolumesEnabled"> Gets or sets the volume snapshot property. This property if enabled will take volume snapshots during backup. </param>
        /// <param name="isClusterScopeResourcesIncluded"> Gets or sets the include cluster resources property. This property if enabled will include cluster scope resources during backup. </param>
        /// <param name="includedNamespaces"> Gets or sets the include namespaces property. This property sets the namespaces to be included during backup. </param>
        /// <param name="excludedNamespaces"> Gets or sets the exclude namespaces property. This property sets the namespaces to be excluded during backup. </param>
        /// <param name="includedResourceTypes"> Gets or sets the include resource types property. This property sets the resource types to be included during backup. </param>
        /// <param name="excludedResourceTypes"> Gets or sets the exclude resource types property. This property sets the resource types to be excluded during backup. </param>
        /// <param name="labelSelectors"> Gets or sets the LabelSelectors property. This property sets the resource with such label selectors to be included during backup. </param>
        /// <param name="backupHookReferences"> Gets or sets the backup hook references. This property sets the hook reference to be executed during backup. </param>
        internal KubernetesClusterBackupDataSourceSettings(string objectType, bool isSnapshotVolumesEnabled, bool isClusterScopeResourcesIncluded, IList<string> includedNamespaces, IList<string> excludedNamespaces, IList<string> includedResourceTypes, IList<string> excludedResourceTypes, IList<string> labelSelectors, IList<NamespacedName> backupHookReferences) : base(objectType)
        {
            IsSnapshotVolumesEnabled = isSnapshotVolumesEnabled;
            IsClusterScopeResourcesIncluded = isClusterScopeResourcesIncluded;
            IncludedNamespaces = includedNamespaces;
            ExcludedNamespaces = excludedNamespaces;
            IncludedResourceTypes = includedResourceTypes;
            ExcludedResourceTypes = excludedResourceTypes;
            LabelSelectors = labelSelectors;
            BackupHookReferences = backupHookReferences;
            ObjectType = objectType ?? "KubernetesClusterBackupDatasourceParameters";
        }

        /// <summary> Gets or sets the volume snapshot property. This property if enabled will take volume snapshots during backup. </summary>
        public bool IsSnapshotVolumesEnabled { get; set; }
        /// <summary> Gets or sets the include cluster resources property. This property if enabled will include cluster scope resources during backup. </summary>
        public bool IsClusterScopeResourcesIncluded { get; set; }
        /// <summary> Gets or sets the include namespaces property. This property sets the namespaces to be included during backup. </summary>
        public IList<string> IncludedNamespaces { get; }
        /// <summary> Gets or sets the exclude namespaces property. This property sets the namespaces to be excluded during backup. </summary>
        public IList<string> ExcludedNamespaces { get; }
        /// <summary> Gets or sets the include resource types property. This property sets the resource types to be included during backup. </summary>
        public IList<string> IncludedResourceTypes { get; }
        /// <summary> Gets or sets the exclude resource types property. This property sets the resource types to be excluded during backup. </summary>
        public IList<string> ExcludedResourceTypes { get; }
        /// <summary> Gets or sets the LabelSelectors property. This property sets the resource with such label selectors to be included during backup. </summary>
        public IList<string> LabelSelectors { get; }
        /// <summary> Gets or sets the backup hook references. This property sets the hook reference to be executed during backup. </summary>
        public IList<NamespacedName> BackupHookReferences { get; }
    }
}
