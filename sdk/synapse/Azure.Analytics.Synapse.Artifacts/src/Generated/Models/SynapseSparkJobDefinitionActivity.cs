// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Execute spark job activity. </summary>
    public partial class SynapseSparkJobDefinitionActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of SynapseSparkJobDefinitionActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="sparkJob"> Synapse spark job reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="sparkJob"/> is null. </exception>
        public SynapseSparkJobDefinitionActivity(string name, SynapseSparkJobReference sparkJob) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (sparkJob == null)
            {
                throw new ArgumentNullException(nameof(sparkJob));
            }

            SparkJob = sparkJob;
            Arguments = new ChangeTrackingList<object>();
            Type = "SparkJob";
        }

        /// <summary> Initializes a new instance of SynapseSparkJobDefinitionActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> . </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="sparkJob"> Synapse spark job reference. </param>
        /// <param name="arguments"> User specified arguments to SynapseSparkJobDefinitionActivity. </param>
        internal SynapseSparkJobDefinitionActivity(string name, string type, string description, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, SynapseSparkJobReference sparkJob, IList<object> arguments) : base(name, type, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            SparkJob = sparkJob;
            Arguments = arguments;
            Type = type ?? "SparkJob";
        }

        /// <summary> Synapse spark job reference. </summary>
        public SynapseSparkJobReference SparkJob { get; set; }
        /// <summary> User specified arguments to SynapseSparkJobDefinitionActivity. </summary>
        public IList<object> Arguments { get; }
    }
}
