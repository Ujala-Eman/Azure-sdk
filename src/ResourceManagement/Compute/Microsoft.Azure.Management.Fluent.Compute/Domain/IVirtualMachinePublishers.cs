// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Fluent.Compute
{

    using Microsoft.Azure.Management.Fluent.Resource.Core.CollectionActions;
    /// <summary>
    /// Entry point to virtual machine image publishers.
    /// </summary>
    public interface IVirtualMachinePublishers  :
        ISupportsListingByRegion<Microsoft.Azure.Management.Fluent.Compute.IVirtualMachinePublisher>
    {
    }
}