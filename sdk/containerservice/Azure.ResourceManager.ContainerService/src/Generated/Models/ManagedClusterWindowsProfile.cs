// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Profile for Windows VMs in the managed cluster. </summary>
    public partial class ManagedClusterWindowsProfile
    {
        /// <summary> Initializes a new instance of ManagedClusterWindowsProfile. </summary>
        /// <param name="adminUsername"> Specifies the name of the administrator account. &lt;br&gt;&lt;br&gt; **Restriction:** Cannot end in &quot;.&quot; &lt;br&gt;&lt;br&gt; **Disallowed values:** &quot;administrator&quot;, &quot;admin&quot;, &quot;user&quot;, &quot;user1&quot;, &quot;test&quot;, &quot;user2&quot;, &quot;test1&quot;, &quot;user3&quot;, &quot;admin1&quot;, &quot;1&quot;, &quot;123&quot;, &quot;a&quot;, &quot;actuser&quot;, &quot;adm&quot;, &quot;admin2&quot;, &quot;aspnet&quot;, &quot;backup&quot;, &quot;console&quot;, &quot;david&quot;, &quot;guest&quot;, &quot;john&quot;, &quot;owner&quot;, &quot;root&quot;, &quot;server&quot;, &quot;sql&quot;, &quot;support&quot;, &quot;support_388945a0&quot;, &quot;sys&quot;, &quot;test2&quot;, &quot;test3&quot;, &quot;user4&quot;, &quot;user5&quot;. &lt;br&gt;&lt;br&gt; **Minimum-length:** 1 character &lt;br&gt;&lt;br&gt; **Max-length:** 20 characters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="adminUsername"/> is null. </exception>
        public ManagedClusterWindowsProfile(string adminUsername)
        {
            if (adminUsername == null)
            {
                throw new ArgumentNullException(nameof(adminUsername));
            }

            AdminUsername = adminUsername;
        }

        /// <summary> Initializes a new instance of ManagedClusterWindowsProfile. </summary>
        /// <param name="adminUsername"> Specifies the name of the administrator account. &lt;br&gt;&lt;br&gt; **Restriction:** Cannot end in &quot;.&quot; &lt;br&gt;&lt;br&gt; **Disallowed values:** &quot;administrator&quot;, &quot;admin&quot;, &quot;user&quot;, &quot;user1&quot;, &quot;test&quot;, &quot;user2&quot;, &quot;test1&quot;, &quot;user3&quot;, &quot;admin1&quot;, &quot;1&quot;, &quot;123&quot;, &quot;a&quot;, &quot;actuser&quot;, &quot;adm&quot;, &quot;admin2&quot;, &quot;aspnet&quot;, &quot;backup&quot;, &quot;console&quot;, &quot;david&quot;, &quot;guest&quot;, &quot;john&quot;, &quot;owner&quot;, &quot;root&quot;, &quot;server&quot;, &quot;sql&quot;, &quot;support&quot;, &quot;support_388945a0&quot;, &quot;sys&quot;, &quot;test2&quot;, &quot;test3&quot;, &quot;user4&quot;, &quot;user5&quot;. &lt;br&gt;&lt;br&gt; **Minimum-length:** 1 character &lt;br&gt;&lt;br&gt; **Max-length:** 20 characters. </param>
        /// <param name="adminPassword"> Specifies the password of the administrator account. &lt;br&gt;&lt;br&gt; **Minimum-length:** 8 characters &lt;br&gt;&lt;br&gt; **Max-length:** 123 characters &lt;br&gt;&lt;br&gt; **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled &lt;br&gt; Has lower characters &lt;br&gt;Has upper characters &lt;br&gt; Has a digit &lt;br&gt; Has a special character (Regex match [\W_]) &lt;br&gt;&lt;br&gt; **Disallowed values:** &quot;abc@123&quot;, &quot;P@$$w0rd&quot;, &quot;P@ssw0rd&quot;, &quot;P@ssword123&quot;, &quot;Pa$$word&quot;, &quot;pass@word1&quot;, &quot;Password!&quot;, &quot;Password1&quot;, &quot;Password22&quot;, &quot;iloveyou!&quot;. </param>
        /// <param name="licenseType"> The license type to use for Windows VMs. See [Azure Hybrid User Benefits](https://azure.microsoft.com/pricing/hybrid-benefit/faq/) for more details. </param>
        /// <param name="enableCSIProxy"> For more details on CSI proxy, see the [CSI proxy GitHub repo](https://github.com/kubernetes-csi/csi-proxy). </param>
        /// <param name="gmsaProfile"> The Windows gMSA Profile in the Managed Cluster. </param>
        internal ManagedClusterWindowsProfile(string adminUsername, string adminPassword, LicenseType? licenseType, bool? enableCSIProxy, WindowsGmsaProfile gmsaProfile)
        {
            AdminUsername = adminUsername;
            AdminPassword = adminPassword;
            LicenseType = licenseType;
            EnableCSIProxy = enableCSIProxy;
            GmsaProfile = gmsaProfile;
        }

        /// <summary> Specifies the name of the administrator account. &lt;br&gt;&lt;br&gt; **Restriction:** Cannot end in &quot;.&quot; &lt;br&gt;&lt;br&gt; **Disallowed values:** &quot;administrator&quot;, &quot;admin&quot;, &quot;user&quot;, &quot;user1&quot;, &quot;test&quot;, &quot;user2&quot;, &quot;test1&quot;, &quot;user3&quot;, &quot;admin1&quot;, &quot;1&quot;, &quot;123&quot;, &quot;a&quot;, &quot;actuser&quot;, &quot;adm&quot;, &quot;admin2&quot;, &quot;aspnet&quot;, &quot;backup&quot;, &quot;console&quot;, &quot;david&quot;, &quot;guest&quot;, &quot;john&quot;, &quot;owner&quot;, &quot;root&quot;, &quot;server&quot;, &quot;sql&quot;, &quot;support&quot;, &quot;support_388945a0&quot;, &quot;sys&quot;, &quot;test2&quot;, &quot;test3&quot;, &quot;user4&quot;, &quot;user5&quot;. &lt;br&gt;&lt;br&gt; **Minimum-length:** 1 character &lt;br&gt;&lt;br&gt; **Max-length:** 20 characters. </summary>
        public string AdminUsername { get; set; }
        /// <summary> Specifies the password of the administrator account. &lt;br&gt;&lt;br&gt; **Minimum-length:** 8 characters &lt;br&gt;&lt;br&gt; **Max-length:** 123 characters &lt;br&gt;&lt;br&gt; **Complexity requirements:** 3 out of 4 conditions below need to be fulfilled &lt;br&gt; Has lower characters &lt;br&gt;Has upper characters &lt;br&gt; Has a digit &lt;br&gt; Has a special character (Regex match [\W_]) &lt;br&gt;&lt;br&gt; **Disallowed values:** &quot;abc@123&quot;, &quot;P@$$w0rd&quot;, &quot;P@ssw0rd&quot;, &quot;P@ssword123&quot;, &quot;Pa$$word&quot;, &quot;pass@word1&quot;, &quot;Password!&quot;, &quot;Password1&quot;, &quot;Password22&quot;, &quot;iloveyou!&quot;. </summary>
        public string AdminPassword { get; set; }
        /// <summary> The license type to use for Windows VMs. See [Azure Hybrid User Benefits](https://azure.microsoft.com/pricing/hybrid-benefit/faq/) for more details. </summary>
        public LicenseType? LicenseType { get; set; }
        /// <summary> For more details on CSI proxy, see the [CSI proxy GitHub repo](https://github.com/kubernetes-csi/csi-proxy). </summary>
        public bool? EnableCSIProxy { get; set; }
        /// <summary> The Windows gMSA Profile in the Managed Cluster. </summary>
        public WindowsGmsaProfile GmsaProfile { get; set; }
    }
}
