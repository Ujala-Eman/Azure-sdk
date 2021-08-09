// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Maintenance.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Input configuration for a patch run
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class InputPatchConfiguration
    {
        /// <summary>
        /// Initializes a new instance of the InputPatchConfiguration class.
        /// </summary>
        public InputPatchConfiguration()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InputPatchConfiguration class.
        /// </summary>
        /// <param name="rebootSetting">Possible reboot preference as defined
        /// by the user based on which it would be decided to reboot the
        /// machine or not after the patch operation is completed. Possible
        /// values include: 'NeverReboot', 'RebootIfRequired',
        /// 'AlwaysReboot'</param>
        /// <param name="windowsParameters">Input parameters specific to
        /// patching a Windows machine. For Linux machines, do not pass this
        /// property.</param>
        /// <param name="linuxParameters">Input parameters specific to patching
        /// Linux machine. For Windows machines, do not pass this
        /// property.</param>
        /// <param name="preTasks">List of pre tasks. e.g. [{'source'
        /// :'runbook', 'taskScope': 'Global', 'parameters': { 'arg1':
        /// 'value1'}}]</param>
        /// <param name="postTasks">List of post tasks. e.g. [{'source'
        /// :'runbook', 'taskScope': 'Resource', 'parameters': { 'arg1':
        /// 'value1'}}]</param>
        public InputPatchConfiguration(string rebootSetting = default(string), InputWindowsParameters windowsParameters = default(InputWindowsParameters), InputLinuxParameters linuxParameters = default(InputLinuxParameters), IList<TaskProperties> preTasks = default(IList<TaskProperties>), IList<TaskProperties> postTasks = default(IList<TaskProperties>))
        {
            RebootSetting = rebootSetting;
            WindowsParameters = windowsParameters;
            LinuxParameters = linuxParameters;
            PreTasks = preTasks;
            PostTasks = postTasks;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible reboot preference as defined by the user
        /// based on which it would be decided to reboot the machine or not
        /// after the patch operation is completed. Possible values include:
        /// 'NeverReboot', 'RebootIfRequired', 'AlwaysReboot'
        /// </summary>
        [JsonProperty(PropertyName = "rebootSetting")]
        public string RebootSetting { get; set; }

        /// <summary>
        /// Gets or sets input parameters specific to patching a Windows
        /// machine. For Linux machines, do not pass this property.
        /// </summary>
        [JsonProperty(PropertyName = "windowsParameters")]
        public InputWindowsParameters WindowsParameters { get; set; }

        /// <summary>
        /// Gets or sets input parameters specific to patching Linux machine.
        /// For Windows machines, do not pass this property.
        /// </summary>
        [JsonProperty(PropertyName = "linuxParameters")]
        public InputLinuxParameters LinuxParameters { get; set; }

        /// <summary>
        /// Gets or sets list of pre tasks. e.g. [{'source' :'runbook',
        /// 'taskScope': 'Global', 'parameters': { 'arg1': 'value1'}}]
        /// </summary>
        [JsonProperty(PropertyName = "tasks.preTasks")]
        public IList<TaskProperties> PreTasks { get; set; }

        /// <summary>
        /// Gets or sets list of post tasks. e.g. [{'source' :'runbook',
        /// 'taskScope': 'Resource', 'parameters': { 'arg1': 'value1'}}]
        /// </summary>
        [JsonProperty(PropertyName = "tasks.postTasks")]
        public IList<TaskProperties> PostTasks { get; set; }

    }
}
