// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> Dto for tenant domain registration. </summary>
    public partial class DataShareEmailRegistration
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataShareEmailRegistration"/>. </summary>
        public DataShareEmailRegistration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataShareEmailRegistration"/>. </summary>
        /// <param name="activationCode"> Activation code for the registration. </param>
        /// <param name="activationExpireOn"> Date of the activation expiration. </param>
        /// <param name="email"> The email to register. </param>
        /// <param name="registrationStatus"> Registration status. </param>
        /// <param name="tenantId"> The tenant to register. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataShareEmailRegistration(string activationCode, DateTimeOffset? activationExpireOn, string email, DataShareEmailRegistrationStatus? registrationStatus, Guid? tenantId, Dictionary<string, BinaryData> rawData)
        {
            ActivationCode = activationCode;
            ActivationExpireOn = activationExpireOn;
            Email = email;
            RegistrationStatus = registrationStatus;
            TenantId = tenantId;
            _rawData = rawData;
        }

        /// <summary> Activation code for the registration. </summary>
        public string ActivationCode { get; set; }
        /// <summary> Date of the activation expiration. </summary>
        public DateTimeOffset? ActivationExpireOn { get; }
        /// <summary> The email to register. </summary>
        public string Email { get; }
        /// <summary> Registration status. </summary>
        public DataShareEmailRegistrationStatus? RegistrationStatus { get; }
        /// <summary> The tenant to register. </summary>
        public Guid? TenantId { get; }
    }
}
