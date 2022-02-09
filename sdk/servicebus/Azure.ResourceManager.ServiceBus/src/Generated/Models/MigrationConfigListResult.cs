// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ServiceBus;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> The result of the List migrationConfigurations operation. </summary>
    internal partial class MigrationConfigListResult
    {
        /// <summary> Initializes a new instance of MigrationConfigListResult. </summary>
        internal MigrationConfigListResult()
        {
            Value = new ChangeTrackingList<MigrationConfigPropertiesData>();
        }

        /// <summary> Initializes a new instance of MigrationConfigListResult. </summary>
        /// <param name="value"> List of Migration Configs. </param>
        /// <param name="nextLink"> Link to the next set of results. Not empty if Value contains incomplete list of migrationConfigurations. </param>
        internal MigrationConfigListResult(IReadOnlyList<MigrationConfigPropertiesData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of Migration Configs. </summary>
        public IReadOnlyList<MigrationConfigPropertiesData> Value { get; }
        /// <summary> Link to the next set of results. Not empty if Value contains incomplete list of migrationConfigurations. </summary>
        public string NextLink { get; }
    }
}
