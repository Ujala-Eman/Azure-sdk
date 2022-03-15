// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A pipeline activity. </summary>
    public partial class Activity
    {
        /// <summary> Initializes a new instance of Activity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public Activity(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            DependsOn = new ChangeTrackingList<ActivityDependency>();
            UserProperties = new ChangeTrackingList<UserProperty>();
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of Activity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal Activity(string name, string type, string description, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties)
        {
            Name = name;
            Type = type;
            Description = description;
            DependsOn = dependsOn;
            UserProperties = userProperties;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Activity name. </summary>
        public string Name { get; set; }
        /// <summary> Type of activity. </summary>
        internal string Type { get; set; }
        /// <summary> Activity description. </summary>
        public string Description { get; set; }
        /// <summary> Activity depends on condition. </summary>
        public IList<ActivityDependency> DependsOn { get; }
        /// <summary> Activity user properties. </summary>
        public IList<UserProperty> UserProperties { get; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
