﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Microsoft.Azure.Management.Storage.Fluent.Models;
using Microsoft.Azure.Management.ResourceManager.Fluent.Core;

namespace Microsoft.Azure.Management.Storage.Fluent
{
    internal class UsageImpl : Wrapper<Usage>, IStorageUsage
    {
        internal UsageImpl(Usage innerObject) : base(innerObject)
        {}

        public int CurrentValue
        {
            get
            {
                return Inner.CurrentValue.HasValue ? 
                    Inner.CurrentValue.Value :
                    default(int);
            }
        }

        public int Limit
        {
            get
            {
                return Inner.Limit.HasValue ? 
                    Inner.Limit.Value :
                    default(int);
            }
        }

        public UsageName Name
        {
            get
            {
                return Inner.Name;
            }
        }

        public UsageUnit Unit
        {
            get
            {
                return Inner.Unit.HasValue ? 
                    Inner.Unit.Value : 
                    default(UsageUnit);
            }
        }
    }
}
