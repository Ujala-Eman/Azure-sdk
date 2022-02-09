// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Domain availability check result. </summary>
    public partial class DomainAvailabilityCheckResult
    {
        /// <summary> Initializes a new instance of DomainAvailabilityCheckResult. </summary>
        internal DomainAvailabilityCheckResult()
        {
        }

        /// <summary> Initializes a new instance of DomainAvailabilityCheckResult. </summary>
        /// <param name="name"> Name of the domain. </param>
        /// <param name="available"> &lt;code&gt;true&lt;/code&gt; if domain can be purchased using CreateDomain API; otherwise, &lt;code&gt;false&lt;/code&gt;. </param>
        /// <param name="domainType"> Valid values are Regular domain: Azure will charge the full price of domain registration, SoftDeleted: Purchasing this domain will simply restore it and this operation will not cost anything. </param>
        internal DomainAvailabilityCheckResult(string name, bool? available, DomainType? domainType)
        {
            Name = name;
            Available = available;
            DomainType = domainType;
        }

        /// <summary> Name of the domain. </summary>
        public string Name { get; }
        /// <summary> &lt;code&gt;true&lt;/code&gt; if domain can be purchased using CreateDomain API; otherwise, &lt;code&gt;false&lt;/code&gt;. </summary>
        public bool? Available { get; }
        /// <summary> Valid values are Regular domain: Azure will charge the full price of domain registration, SoftDeleted: Purchasing this domain will simply restore it and this operation will not cost anything. </summary>
        public DomainType? DomainType { get; }
    }
}
