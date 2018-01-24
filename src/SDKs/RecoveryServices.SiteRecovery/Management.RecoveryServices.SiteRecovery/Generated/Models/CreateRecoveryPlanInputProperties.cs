// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Recovery plan creation properties.
    /// </summary>
    public partial class CreateRecoveryPlanInputProperties
    {
        /// <summary>
        /// Initializes a new instance of the CreateRecoveryPlanInputProperties
        /// class.
        /// </summary>
        public CreateRecoveryPlanInputProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateRecoveryPlanInputProperties
        /// class.
        /// </summary>
        /// <param name="primaryFabricId">The primary fabric Id.</param>
        /// <param name="recoveryFabricId">The recovery fabric Id.</param>
        /// <param name="groups">The recovery plan groups.</param>
        /// <param name="failoverDeploymentModel">The failover deployment
        /// model. Possible values include: 'NotApplicable', 'Classic',
        /// 'ResourceManager'</param>
        public CreateRecoveryPlanInputProperties(string primaryFabricId, string recoveryFabricId, IList<RecoveryPlanGroup> groups, FailoverDeploymentModel? failoverDeploymentModel = default(FailoverDeploymentModel?))
        {
            PrimaryFabricId = primaryFabricId;
            RecoveryFabricId = recoveryFabricId;
            FailoverDeploymentModel = failoverDeploymentModel;
            Groups = groups;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the primary fabric Id.
        /// </summary>
        [JsonProperty(PropertyName = "primaryFabricId")]
        public string PrimaryFabricId { get; set; }

        /// <summary>
        /// Gets or sets the recovery fabric Id.
        /// </summary>
        [JsonProperty(PropertyName = "recoveryFabricId")]
        public string RecoveryFabricId { get; set; }

        /// <summary>
        /// Gets or sets the failover deployment model. Possible values
        /// include: 'NotApplicable', 'Classic', 'ResourceManager'
        /// </summary>
        [JsonProperty(PropertyName = "failoverDeploymentModel")]
        public FailoverDeploymentModel? FailoverDeploymentModel { get; set; }

        /// <summary>
        /// Gets or sets the recovery plan groups.
        /// </summary>
        [JsonProperty(PropertyName = "groups")]
        public IList<RecoveryPlanGroup> Groups { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (PrimaryFabricId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "PrimaryFabricId");
            }
            if (RecoveryFabricId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RecoveryFabricId");
            }
            if (Groups == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Groups");
            }
            if (Groups != null)
            {
                foreach (var element in Groups)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
