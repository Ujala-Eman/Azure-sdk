// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Unencrypted credentials for accessing device. </summary>
    public partial class UnencryptedCredentials
    {
        /// <summary> Initializes a new instance of UnencryptedCredentials. </summary>
        internal UnencryptedCredentials()
        {
        }

        /// <summary> Initializes a new instance of UnencryptedCredentials. </summary>
        /// <param name="jobName"> Name of the job. </param>
        /// <param name="jobSecrets">
        /// Secrets related to this job.
        /// Please note <see cref="Models.JobSecrets"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataboxJobSecrets"/>, <see cref="CustomerDiskJobSecrets"/>, <see cref="DataBoxDiskJobSecrets"/> and <see cref="DataBoxHeavyJobSecrets"/>.
        /// </param>
        internal UnencryptedCredentials(string jobName, JobSecrets jobSecrets)
        {
            JobName = jobName;
            JobSecrets = jobSecrets;
        }

        /// <summary> Name of the job. </summary>
        public string JobName { get; }
        /// <summary>
        /// Secrets related to this job.
        /// Please note <see cref="Models.JobSecrets"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataboxJobSecrets"/>, <see cref="CustomerDiskJobSecrets"/>, <see cref="DataBoxDiskJobSecrets"/> and <see cref="DataBoxHeavyJobSecrets"/>.
        /// </summary>
        public JobSecrets JobSecrets { get; }
    }
}
