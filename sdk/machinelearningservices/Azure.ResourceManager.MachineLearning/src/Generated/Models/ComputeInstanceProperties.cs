// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Compute Instance properties. </summary>
    public partial class ComputeInstanceProperties
    {
        /// <summary> Initializes a new instance of ComputeInstanceProperties. </summary>
        public ComputeInstanceProperties()
        {
            Applications = new ChangeTrackingList<ComputeInstanceApplication>();
            Errors = new ChangeTrackingList<ErrorResponse>();
            Containers = new ChangeTrackingList<ComputeInstanceContainer>();
            DataDisks = new ChangeTrackingList<ComputeInstanceDataDisk>();
            DataMounts = new ChangeTrackingList<ComputeInstanceDataMount>();
        }

        /// <summary> Initializes a new instance of ComputeInstanceProperties. </summary>
        /// <param name="vmSize"> Virtual Machine Size. </param>
        /// <param name="subnet"> Virtual network subnet resource ID the compute nodes belong to. </param>
        /// <param name="applicationSharingPolicy"> Policy for sharing applications on this compute instance among users of parent workspace. If Personal, only the creator can access applications on this compute instance. When Shared, any workspace user can access applications on this instance depending on his/her assigned role. </param>
        /// <param name="sshSettings"> Specifies policy and settings for SSH access. </param>
        /// <param name="connectivityEndpoints"> Describes all connectivity endpoints available for this ComputeInstance. </param>
        /// <param name="applications"> Describes available applications and their endpoints on this ComputeInstance. </param>
        /// <param name="createdBy"> Describes information on user who created this ComputeInstance. </param>
        /// <param name="errors"> Collection of errors encountered on this ComputeInstance. </param>
        /// <param name="state"> The current state of this ComputeInstance. </param>
        /// <param name="computeInstanceAuthorizationType"> The Compute Instance Authorization type. Available values are personal (default). </param>
        /// <param name="personalComputeInstanceSettings"> Settings for a personal compute instance. </param>
        /// <param name="setupScriptsSettings"> Details of customized scripts to execute for setting up the cluster. </param>
        /// <param name="lastOperation"> The last operation on ComputeInstance. </param>
        /// <param name="schedules"> The list of schedules to be applied on the computes. </param>
        /// <param name="enableNodePublicIp"> Enable or disable node public IP address provisioning. Possible values are: Possible values are: true - Indicates that the compute nodes will have public IPs provisioned. false - Indicates that the compute nodes will have a private endpoint and no public IPs. </param>
        /// <param name="containers"> Describes informations of containers on this ComputeInstance. </param>
        /// <param name="dataDisks"> Describes informations of dataDisks on this ComputeInstance. </param>
        /// <param name="dataMounts"> Describes informations of dataMounts on this ComputeInstance. </param>
        /// <param name="versions"> ComputeInstance version. </param>
        internal ComputeInstanceProperties(string vmSize, ResourceId subnet, ApplicationSharingPolicy? applicationSharingPolicy, ComputeInstanceSshSettings sshSettings, ComputeInstanceConnectivityEndpoints connectivityEndpoints, IReadOnlyList<ComputeInstanceApplication> applications, ComputeInstanceCreatedBy createdBy, IReadOnlyList<ErrorResponse> errors, ComputeInstanceState? state, ComputeInstanceAuthorizationType? computeInstanceAuthorizationType, PersonalComputeInstanceSettings personalComputeInstanceSettings, SetupScripts setupScriptsSettings, ComputeInstanceLastOperation lastOperation, ComputeSchedules schedules, bool? enableNodePublicIp, IReadOnlyList<ComputeInstanceContainer> containers, IReadOnlyList<ComputeInstanceDataDisk> dataDisks, IReadOnlyList<ComputeInstanceDataMount> dataMounts, ComputeInstanceVersion versions)
        {
            VmSize = vmSize;
            Subnet = subnet;
            ApplicationSharingPolicy = applicationSharingPolicy;
            SshSettings = sshSettings;
            ConnectivityEndpoints = connectivityEndpoints;
            Applications = applications;
            CreatedBy = createdBy;
            Errors = errors;
            State = state;
            ComputeInstanceAuthorizationType = computeInstanceAuthorizationType;
            PersonalComputeInstanceSettings = personalComputeInstanceSettings;
            SetupScriptsSettings = setupScriptsSettings;
            LastOperation = lastOperation;
            Schedules = schedules;
            EnableNodePublicIp = enableNodePublicIp;
            Containers = containers;
            DataDisks = dataDisks;
            DataMounts = dataMounts;
            Versions = versions;
        }

        /// <summary> Virtual Machine Size. </summary>
        public string VmSize { get; set; }
        /// <summary> Virtual network subnet resource ID the compute nodes belong to. </summary>
        internal ResourceId Subnet { get; set; }
        /// <summary> The ID of the resource. </summary>
        public string SubnetId
        {
            get => Subnet is null ? default : Subnet.Id;
            set => Subnet = new ResourceId(value);
        }

        /// <summary> Policy for sharing applications on this compute instance among users of parent workspace. If Personal, only the creator can access applications on this compute instance. When Shared, any workspace user can access applications on this instance depending on his/her assigned role. </summary>
        public ApplicationSharingPolicy? ApplicationSharingPolicy { get; set; }
        /// <summary> Specifies policy and settings for SSH access. </summary>
        public ComputeInstanceSshSettings SshSettings { get; set; }
        /// <summary> Describes all connectivity endpoints available for this ComputeInstance. </summary>
        public ComputeInstanceConnectivityEndpoints ConnectivityEndpoints { get; }
        /// <summary> Describes available applications and their endpoints on this ComputeInstance. </summary>
        public IReadOnlyList<ComputeInstanceApplication> Applications { get; }
        /// <summary> Describes information on user who created this ComputeInstance. </summary>
        public ComputeInstanceCreatedBy CreatedBy { get; }
        /// <summary> Collection of errors encountered on this ComputeInstance. </summary>
        public IReadOnlyList<ErrorResponse> Errors { get; }
        /// <summary> The current state of this ComputeInstance. </summary>
        public ComputeInstanceState? State { get; }
        /// <summary> The Compute Instance Authorization type. Available values are personal (default). </summary>
        public ComputeInstanceAuthorizationType? ComputeInstanceAuthorizationType { get; set; }
        /// <summary> Settings for a personal compute instance. </summary>
        internal PersonalComputeInstanceSettings PersonalComputeInstanceSettings { get; set; }
        /// <summary> A user explicitly assigned to a personal compute instance. </summary>
        public AssignedUser PersonalComputeInstanceAssignedUser
        {
            get => PersonalComputeInstanceSettings is null ? default : PersonalComputeInstanceSettings.AssignedUser;
            set
            {
                if (PersonalComputeInstanceSettings is null)
                    PersonalComputeInstanceSettings = new PersonalComputeInstanceSettings();
                PersonalComputeInstanceSettings.AssignedUser = value;
            }
        }

        /// <summary> Details of customized scripts to execute for setting up the cluster. </summary>
        internal SetupScripts SetupScriptsSettings { get; set; }
        /// <summary> Customized setup scripts. </summary>
        public ScriptsToExecute Scripts
        {
            get => SetupScriptsSettings is null ? default : SetupScriptsSettings.Scripts;
            set
            {
                if (SetupScriptsSettings is null)
                    SetupScriptsSettings = new SetupScripts();
                SetupScriptsSettings.Scripts = value;
            }
        }

        /// <summary> The last operation on ComputeInstance. </summary>
        public ComputeInstanceLastOperation LastOperation { get; }
        /// <summary> The list of schedules to be applied on the computes. </summary>
        internal ComputeSchedules Schedules { get; }
        /// <summary> The list of compute start stop schedules to be applied. </summary>
        public IReadOnlyList<ComputeStartStopSchedule> SchedulesComputeStartStop
        {
            get => Schedules?.ComputeStartStop;
        }

        /// <summary> Enable or disable node public IP address provisioning. Possible values are: Possible values are: true - Indicates that the compute nodes will have public IPs provisioned. false - Indicates that the compute nodes will have a private endpoint and no public IPs. </summary>
        public bool? EnableNodePublicIp { get; set; }
        /// <summary> Describes informations of containers on this ComputeInstance. </summary>
        public IReadOnlyList<ComputeInstanceContainer> Containers { get; }
        /// <summary> Describes informations of dataDisks on this ComputeInstance. </summary>
        public IReadOnlyList<ComputeInstanceDataDisk> DataDisks { get; }
        /// <summary> Describes informations of dataMounts on this ComputeInstance. </summary>
        public IReadOnlyList<ComputeInstanceDataMount> DataMounts { get; }
        /// <summary> ComputeInstance version. </summary>
        internal ComputeInstanceVersion Versions { get; }
        /// <summary> Runtime of compute instance. </summary>
        public string VersionsRuntime
        {
            get => Versions?.Runtime;
        }
    }
}
