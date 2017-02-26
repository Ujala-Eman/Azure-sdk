// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// Definition of Dsc Compilation job properties.
    /// </summary>
    public partial class DscCompilationJobProperties : JobPropertiesBase
    {
        private DscConfigurationAssociationProperty _configuration;
        
        /// <summary>
        /// Optional. Gets or sets the configuration.
        /// </summary>
        public DscConfigurationAssociationProperty Configuration
        {
            get { return this._configuration; }
            set { this._configuration = value; }
        }
        
        private string _startedBy;
        
        /// <summary>
        /// Optional. Gets or sets the compilation job started by.
        /// </summary>
        public string StartedBy
        {
            get { return this._startedBy; }
            set { this._startedBy = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the DscCompilationJobProperties class.
        /// </summary>
        public DscCompilationJobProperties()
        {
        }
    }
}
