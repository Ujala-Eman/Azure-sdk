// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Azure Data Factory secure string definition. The string value will be masked with asterisks &apos;*&apos; during Get or List API calls. </summary>
    public partial class FactorySecretString : FactorySecretBaseDefinition
    {
        /// <summary> Initializes a new instance of FactorySecretString. </summary>
        /// <param name="value"> Value of secure string. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FactorySecretString(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value;
            SecretBaseType = "SecureString";
        }

        /// <summary> Initializes a new instance of FactorySecretString. </summary>
        /// <param name="secretBaseType"> Type of the secret. </param>
        /// <param name="value"> Value of secure string. </param>
        internal FactorySecretString(string secretBaseType, string value) : base(secretBaseType)
        {
            Value = value;
            SecretBaseType = secretBaseType ?? "SecureString";
        }

        /// <summary> Value of secure string. </summary>
        public string Value { get; set; }
    }
}
