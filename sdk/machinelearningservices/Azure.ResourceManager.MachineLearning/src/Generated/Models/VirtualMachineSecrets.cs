// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Secrets related to a Machine Learning compute based on AKS. </summary>
    public partial class VirtualMachineSecrets : ComputeSecrets
    {
        /// <summary> Initializes a new instance of VirtualMachineSecrets. </summary>
        internal VirtualMachineSecrets()
        {
            ComputeType = ComputeType.VirtualMachine;
        }

        /// <summary> Initializes a new instance of VirtualMachineSecrets. </summary>
        /// <param name="computeType"> The type of compute. </param>
        /// <param name="administratorAccount"> Admin credentials for virtual machine. </param>
        internal VirtualMachineSecrets(ComputeType computeType, VirtualMachineSshCredentials administratorAccount) : base(computeType)
        {
            AdministratorAccount = administratorAccount;
            ComputeType = computeType;
        }

        /// <summary> Admin credentials for virtual machine. </summary>
        public VirtualMachineSshCredentials AdministratorAccount { get; }
    }
}
