// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ApiManagement;
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters supplied to the Save Tenant Configuration operation.
    /// </summary>
    public partial class SaveConfigurationParameter
    {
        /// <summary>
        /// Initializes a new instance of the SaveConfigurationParameter class.
        /// </summary>
        public SaveConfigurationParameter()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SaveConfigurationParameter class.
        /// </summary>
        /// <param name="branch">The name of the Git branch in which to commit
        /// the current configuration snapshot.</param>
        /// <param name="force">The value if true, the current configuration
        /// database is committed to the Git repository, even if the Git
        /// repository has newer changes that would be overwritten.</param>
        public SaveConfigurationParameter(string branch, bool? force = default(bool?))
        {
            Branch = branch;
            Force = force;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the Git branch in which to commit the
        /// current configuration snapshot.
        /// </summary>
        [JsonProperty(PropertyName = "branch")]
        public string Branch { get; set; }

        /// <summary>
        /// Gets or sets the value if true, the current configuration database
        /// is committed to the Git repository, even if the Git repository has
        /// newer changes that would be overwritten.
        /// </summary>
        [JsonProperty(PropertyName = "force")]
        public bool? Force { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Branch == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Branch");
            }
        }
    }
}
