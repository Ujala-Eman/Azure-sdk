// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary>
    /// Describes a section in the fabric settings of the cluster.
    /// Serialized Name: SettingsSectionDescription
    /// </summary>
    public partial class SettingsSectionDescription
    {
        /// <summary> Initializes a new instance of SettingsSectionDescription. </summary>
        /// <param name="name">
        /// The section name of the fabric settings.
        /// Serialized Name: SettingsSectionDescription.name
        /// </param>
        /// <param name="parameters">
        /// The collection of parameters in the section.
        /// Serialized Name: SettingsSectionDescription.parameters
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="parameters"/> is null. </exception>
        public SettingsSectionDescription(string name, IEnumerable<SettingsParameterDescription> parameters)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            Name = name;
            Parameters = parameters.ToList();
        }

        /// <summary> Initializes a new instance of SettingsSectionDescription. </summary>
        /// <param name="name">
        /// The section name of the fabric settings.
        /// Serialized Name: SettingsSectionDescription.name
        /// </param>
        /// <param name="parameters">
        /// The collection of parameters in the section.
        /// Serialized Name: SettingsSectionDescription.parameters
        /// </param>
        internal SettingsSectionDescription(string name, IList<SettingsParameterDescription> parameters)
        {
            Name = name;
            Parameters = parameters;
        }

        /// <summary>
        /// The section name of the fabric settings.
        /// Serialized Name: SettingsSectionDescription.name
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The collection of parameters in the section.
        /// Serialized Name: SettingsSectionDescription.parameters
        /// </summary>
        public IList<SettingsParameterDescription> Parameters { get; }
    }
}
