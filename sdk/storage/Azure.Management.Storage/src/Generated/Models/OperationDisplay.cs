// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Management.Storage.Models
{
    /// <summary> Display metadata associated with the operation. </summary>
    public partial class OperationDisplay
    {
        /// <summary> Initializes a new instance of OperationDisplay. </summary>
        internal OperationDisplay()
        {
        }

        /// <summary> Initializes a new instance of OperationDisplay. </summary>
        /// <param name="provider"> Service provider: Microsoft Storage. </param>
        /// <param name="resource"> Resource on which the operation is performed etc. </param>
        /// <param name="operation"> Type of operation: get, read, delete, etc. </param>
        /// <param name="description"> Description of the operation. </param>
        internal OperationDisplay(string provider, string resource, string operation, string description)
        {
            Provider = provider;
            Resource = resource;
            Operation = operation;
            Description = description;
        }

        /// <summary> Service provider: Microsoft Storage. </summary>
        public string Provider { get; internal set; }
        /// <summary> Resource on which the operation is performed etc. </summary>
        public string Resource { get; internal set; }
        /// <summary> Type of operation: get, read, delete, etc. </summary>
        public string Operation { get; internal set; }
        /// <summary> Description of the operation. </summary>
        public string Description { get; internal set; }
    }
}
