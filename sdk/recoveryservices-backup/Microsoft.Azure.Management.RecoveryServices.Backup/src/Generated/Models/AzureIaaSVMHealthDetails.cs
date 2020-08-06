// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure IaaS VM workload-specific Health Details.
    /// </summary>
    public partial class AzureIaaSVMHealthDetails : ResourceHealthDetails
    {
        /// <summary>
        /// Initializes a new instance of the AzureIaaSVMHealthDetails class.
        /// </summary>
        public AzureIaaSVMHealthDetails()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureIaaSVMHealthDetails class.
        /// </summary>
        /// <param name="code">Health Code</param>
        /// <param name="title">Health Title</param>
        /// <param name="message">Health Message</param>
        /// <param name="recommendations">Health Recommended Actions</param>
        public AzureIaaSVMHealthDetails(int? code = default(int?), string title = default(string), string message = default(string), IList<string> recommendations = default(IList<string>))
            : base(code, title, message, recommendations)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
