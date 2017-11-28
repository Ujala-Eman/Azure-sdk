// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Statistics related to pool usage data.
    /// </summary>
    public partial class UsageStatistics : IPropertyMetadata
    {
        #region Constructors

        internal UsageStatistics(Models.UsageStatistics protocolObject)
        {
            this.DedicatedCoreTime = protocolObject.DedicatedCoreTime;
            this.LastUpdateTime = protocolObject.LastUpdateTime;
            this.StartTime = protocolObject.StartTime;
        }

        #endregion Constructors

        #region UsageStatistics

        /// <summary>
        /// Gets the aggregated wall-clock time of the dedicated compute nodes being part of the pool.
        /// </summary>
        public TimeSpan DedicatedCoreTime { get; }

        /// <summary>
        /// Gets the time at which the statistics were last updated. All statistics are limited to the range between <see 
        /// cref="StartTime"/> and this value.
        /// </summary>
        public DateTime LastUpdateTime { get; }

        /// <summary>
        /// Gets the start time of the time range covered by the statistics.
        /// </summary>
        public DateTime StartTime { get; }

        #endregion // UsageStatistics

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}