// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Dns.Fluent
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.CollectionActions;
    using ResourceManager.Fluent.Core;

    /// <summary>
    /// Entry point to PTR record sets in a DNS zone.
    /// </summary>
    public interface IPtrRecordSets  :
        ISupportsListing<Microsoft.Azure.Management.Dns.Fluent.IPtrRecordSet>,
        ISupportsGettingByName<Microsoft.Azure.Management.Dns.Fluent.IPtrRecordSet>,
        IHasParent<IDnsZone>
    {
    }
}