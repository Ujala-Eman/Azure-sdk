// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.NetApp.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Active Directory
    /// </summary>
    public partial class ActiveDirectory
    {
        /// <summary>
        /// Initializes a new instance of the ActiveDirectory class.
        /// </summary>
        public ActiveDirectory()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ActiveDirectory class.
        /// </summary>
        /// <param name="activeDirectoryId">Id of the Active Directory</param>
        /// <param name="username">Username of Active Directory domain
        /// administrator</param>
        /// <param name="password">Plain text password of Active Directory
        /// domain administrator</param>
        /// <param name="domain">Name of the Active Directory domain</param>
        /// <param name="dNS">Comma separated list of DNS server IP addresses
        /// for the Active Directory domain</param>
        /// <param name="status">Status of the Active Directory</param>
        /// <param name="sMBServerName">NetBIOS name of the SMB server. This
        /// name will be registered as a computer account in the AD and used to
        /// mount volumes</param>
        /// <param name="organizationalUnit">The Organizational Unit (OU)
        /// within the Windows Active Directory</param>
        public ActiveDirectory(string activeDirectoryId = default(string), string username = default(string), string password = default(string), string domain = default(string), string dNS = default(string), string status = default(string), string sMBServerName = default(string), string organizationalUnit = default(string))
        {
            ActiveDirectoryId = activeDirectoryId;
            Username = username;
            Password = password;
            Domain = domain;
            DNS = dNS;
            Status = status;
            SMBServerName = sMBServerName;
            OrganizationalUnit = organizationalUnit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets id of the Active Directory
        /// </summary>
        [JsonProperty(PropertyName = "activeDirectoryId")]
        public string ActiveDirectoryId { get; set; }

        /// <summary>
        /// Gets or sets username of Active Directory domain administrator
        /// </summary>
        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        /// <summary>
        /// Gets or sets plain text password of Active Directory domain
        /// administrator
        /// </summary>
        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets name of the Active Directory domain
        /// </summary>
        [JsonProperty(PropertyName = "domain")]
        public string Domain { get; set; }

        /// <summary>
        /// Gets or sets comma separated list of DNS server IP addresses for
        /// the Active Directory domain
        /// </summary>
        [JsonProperty(PropertyName = "dNS")]
        public string DNS { get; set; }

        /// <summary>
        /// Gets or sets status of the Active Directory
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets netBIOS name of the SMB server. This name will be
        /// registered as a computer account in the AD and used to mount
        /// volumes
        /// </summary>
        [JsonProperty(PropertyName = "sMBServerName")]
        public string SMBServerName { get; set; }

        /// <summary>
        /// Gets or sets the Organizational Unit (OU) within the Windows Active
        /// Directory
        /// </summary>
        [JsonProperty(PropertyName = "organizationalUnit")]
        public string OrganizationalUnit { get; set; }

    }
}
