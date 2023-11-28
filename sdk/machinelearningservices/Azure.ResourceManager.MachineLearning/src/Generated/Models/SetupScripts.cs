// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Details of customized scripts to execute for setting up the cluster. </summary>
    internal partial class SetupScripts
    {
        /// <summary> Initializes a new instance of <see cref="SetupScripts"/>. </summary>
        public SetupScripts()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SetupScripts"/>. </summary>
        /// <param name="scripts"> Customized setup scripts. </param>
        internal SetupScripts(MachineLearningScriptsToExecute scripts)
        {
            Scripts = scripts;
        }

        /// <summary> Customized setup scripts. </summary>
        public MachineLearningScriptsToExecute Scripts { get; set; }
    }
}
