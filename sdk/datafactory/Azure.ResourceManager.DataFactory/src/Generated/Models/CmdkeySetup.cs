// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The custom setup of running cmdkey commands. </summary>
    public partial class CmdkeySetup : CustomSetupBase
    {
        /// <summary> Initializes a new instance of CmdkeySetup. </summary>
        /// <param name="targetName"> The server name of data source access. </param>
        /// <param name="userName"> The user name of data source access. </param>
        /// <param name="password">
        /// The password of data source access.
        /// Please note <see cref="FactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetName"/>, <paramref name="userName"/> or <paramref name="password"/> is null. </exception>
        public CmdkeySetup(BinaryData targetName, BinaryData userName, FactorySecretBaseDefinition password)
        {
            if (targetName == null)
            {
                throw new ArgumentNullException(nameof(targetName));
            }
            if (userName == null)
            {
                throw new ArgumentNullException(nameof(userName));
            }
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }

            TargetName = targetName;
            UserName = userName;
            Password = password;
            CustomSetupBaseType = "CmdkeySetup";
        }

        /// <summary> Initializes a new instance of CmdkeySetup. </summary>
        /// <param name="customSetupBaseType"> The type of custom setup. </param>
        /// <param name="targetName"> The server name of data source access. </param>
        /// <param name="userName"> The user name of data source access. </param>
        /// <param name="password">
        /// The password of data source access.
        /// Please note <see cref="FactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </param>
        internal CmdkeySetup(string customSetupBaseType, BinaryData targetName, BinaryData userName, FactorySecretBaseDefinition password) : base(customSetupBaseType)
        {
            TargetName = targetName;
            UserName = userName;
            Password = password;
            CustomSetupBaseType = customSetupBaseType ?? "CmdkeySetup";
        }

        /// <summary> The server name of data source access. </summary>
        public BinaryData TargetName { get; set; }
        /// <summary> The user name of data source access. </summary>
        public BinaryData UserName { get; set; }
        /// <summary>
        /// The password of data source access.
        /// Please note <see cref="FactorySecretBaseDefinition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="FactorySecretString"/> and <see cref="AzureKeyVaultSecretReference"/>.
        /// </summary>
        public FactorySecretBaseDefinition Password { get; set; }
    }
}
