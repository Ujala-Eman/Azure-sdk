// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.ConnectedVMwarevSphere.Models
{
    /// <summary> Describes the Machine Extension Instance View. </summary>
    public partial class MachineExtensionInstanceView
    {
        /// <summary> Initializes a new instance of MachineExtensionInstanceView. </summary>
        public MachineExtensionInstanceView()
        {
        }

        /// <summary> Initializes a new instance of MachineExtensionInstanceView. </summary>
        /// <param name="name"> The machine extension name. </param>
        /// <param name="machineExtensionInstanceViewType"> Specifies the type of the extension; an example is "CustomScriptExtension". </param>
        /// <param name="typeHandlerVersion"> Specifies the version of the script handler. </param>
        /// <param name="status"> Instance view status. </param>
        internal MachineExtensionInstanceView(string name, string machineExtensionInstanceViewType, string typeHandlerVersion, MachineExtensionInstanceViewStatus status)
        {
            Name = name;
            MachineExtensionInstanceViewType = machineExtensionInstanceViewType;
            TypeHandlerVersion = typeHandlerVersion;
            Status = status;
        }

        /// <summary> The machine extension name. </summary>
        public string Name { get; }
        /// <summary> Specifies the type of the extension; an example is "CustomScriptExtension". </summary>
        public string MachineExtensionInstanceViewType { get; }
        /// <summary> Specifies the version of the script handler. </summary>
        public string TypeHandlerVersion { get; }
        /// <summary> Instance view status. </summary>
        public MachineExtensionInstanceViewStatus Status { get; set; }
    }
}
