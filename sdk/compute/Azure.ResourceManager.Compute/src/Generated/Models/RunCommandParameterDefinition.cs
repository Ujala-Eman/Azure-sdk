// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the properties of a run command parameter. </summary>
    public partial class RunCommandParameterDefinition
    {
        /// <summary> Initializes a new instance of <see cref="RunCommandParameterDefinition"/>. </summary>
        /// <param name="name"> The run command parameter name. </param>
        /// <param name="runCommandParameterDefinitionType"> The run command parameter type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="runCommandParameterDefinitionType"/> is null. </exception>
        internal RunCommandParameterDefinition(string name, string runCommandParameterDefinitionType)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (runCommandParameterDefinitionType == null)
            {
                throw new ArgumentNullException(nameof(runCommandParameterDefinitionType));
            }

            Name = name;
            RunCommandParameterDefinitionType = runCommandParameterDefinitionType;
        }

        /// <summary> Initializes a new instance of <see cref="RunCommandParameterDefinition"/>. </summary>
        /// <param name="name"> The run command parameter name. </param>
        /// <param name="runCommandParameterDefinitionType"> The run command parameter type. </param>
        /// <param name="defaultValue"> The run command parameter default value. </param>
        /// <param name="required"> The run command parameter required. </param>
        internal RunCommandParameterDefinition(string name, string runCommandParameterDefinitionType, string defaultValue, bool? required)
        {
            Name = name;
            RunCommandParameterDefinitionType = runCommandParameterDefinitionType;
            DefaultValue = defaultValue;
            Required = required;
        }

        /// <summary> The run command parameter name. </summary>
        public string Name { get; }
        /// <summary> The run command parameter type. </summary>
        public string RunCommandParameterDefinitionType { get; }
        /// <summary> The run command parameter default value. </summary>
        public string DefaultValue { get; }
        /// <summary> The run command parameter required. </summary>
        public bool? Required { get; }
    }
}
