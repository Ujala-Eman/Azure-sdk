// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The KerberosPasswordSecrets. </summary>
    public partial class KerberosPasswordSecrets : DatastoreSecrets
    {
        /// <summary> Initializes a new instance of <see cref="KerberosPasswordSecrets"/>. </summary>
        public KerberosPasswordSecrets()
        {
            SecretsType = SecretsType.KerberosPassword;
        }

        /// <summary> Initializes a new instance of <see cref="KerberosPasswordSecrets"/>. </summary>
        /// <param name="secretsType"> [Required] Credential type used to authentication with storage. </param>
        /// <param name="kerberosPassword"> Kerberos password secret. </param>
        internal KerberosPasswordSecrets(SecretsType secretsType, string kerberosPassword) : base(secretsType)
        {
            KerberosPassword = kerberosPassword;
            SecretsType = secretsType;
        }

        /// <summary> Kerberos password secret. </summary>
        public string KerberosPassword { get; set; }
    }
}
