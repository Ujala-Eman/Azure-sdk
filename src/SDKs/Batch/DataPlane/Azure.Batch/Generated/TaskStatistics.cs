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
    /// Resource usage statistics for the task.
    /// </summary>
    public partial class TaskStatistics : IPropertyMetadata
    {
        #region Constructors

        internal TaskStatistics(Models.TaskStatistics protocolObject)
        {
            this.KernelCpuTime = protocolObject.KernelCPUTime;
            this.LastUpdateTime = protocolObject.LastUpdateTime;
            this.ReadIOGiB = protocolObject.ReadIOGiB;
            this.ReadIOps = protocolObject.ReadIOps;
            this.StartTime = protocolObject.StartTime;
            this.Url = protocolObject.Url;
            this.UserCpuTime = protocolObject.UserCPUTime;
            this.WaitTime = protocolObject.WaitTime;
            this.WallClockTime = protocolObject.WallClockTime;
            this.WriteIOGiB = protocolObject.WriteIOGiB;
            this.WriteIOps = protocolObject.WriteIOps;
        }

        #endregion Constructors

        #region TaskStatistics

        /// <summary>
        /// Gets the total kernel mode CPU time (per core) consumed by the task.
        /// </summary>
        public TimeSpan KernelCpuTime { get; }

        /// <summary>
        /// Gets the time at which the statistics were last updated. All statistics are limited to the range between <see 
        /// cref="StartTime"/> and this value.
        /// </summary>
        public DateTime LastUpdateTime { get; }

        /// <summary>
        /// Gets the total gibibytes of I/O read from disk by the task.
        /// </summary>
        public double ReadIOGiB { get; }

        /// <summary>
        /// Gets the total number of disk read operations made by the task.
        /// </summary>
        public long ReadIOps { get; }

        /// <summary>
        /// Gets the start time of the time range covered by the statistics.
        /// </summary>
        public DateTime StartTime { get; }

        /// <summary>
        /// Gets the URL of the task statistics.
        /// </summary>
        public string Url { get; }

        /// <summary>
        /// Gets the total user mode CPU time (per core) consumed by the task.
        /// </summary>
        public TimeSpan UserCpuTime { get; }

        /// <summary>
        /// Gets the total wait time of the task. The wait time for a task is defined as the elapsed time between the creation 
        /// of the task and the start of task execution. (If the task is retried due to failures, the wait time is the time 
        /// to the most recent task execution.)
        /// </summary>
        public TimeSpan WaitTime { get; }

        /// <summary>
        /// Gets the wall clock time of the task execution.
        /// </summary>
        public TimeSpan WallClockTime { get; }

        /// <summary>
        /// Gets the total gibibytes of I/O written to disk by the task.
        /// </summary>
        public double WriteIOGiB { get; }

        /// <summary>
        /// Gets the total number of disk write operations made by the task.
        /// </summary>
        public long WriteIOps { get; }

        #endregion // TaskStatistics

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