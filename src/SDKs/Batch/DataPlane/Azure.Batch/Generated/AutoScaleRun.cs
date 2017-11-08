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
    /// The results and errors from an evaluation or execution of a pool autoscale formula.
    /// </summary>
    public partial class AutoScaleRun : IPropertyMetadata
    {
        #region Constructors

        internal AutoScaleRun(Models.AutoScaleRun protocolObject)
        {
            this.Error = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.Error, o => new AutoScaleRunError(o).Freeze());
            this.Results = protocolObject.Results;
            this.Timestamp = protocolObject.Timestamp;
        }

        #endregion Constructors

        #region AutoScaleRun

        /// <summary>
        /// Gets details of the error encountered evaluating the autoscale formula on the pool, if the evaluation was unsuccessful.
        /// </summary>
        public AutoScaleRunError Error { get; }

        /// <summary>
        /// Gets the final values of all variables used in the evaluation of the autoscale formula. Each variable value is 
        /// returned in the form $variable=value, and variables are separated by semicolons.
        /// </summary>
        public string Results { get; }

        /// <summary>
        /// Gets the time at which the autoscale formula was last evaluated.
        /// </summary>
        public DateTime Timestamp { get; }

        #endregion // AutoScaleRun

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