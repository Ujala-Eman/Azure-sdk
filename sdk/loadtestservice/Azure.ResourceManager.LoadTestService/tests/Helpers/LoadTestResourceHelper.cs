﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.LoadTestService.Tests.Helpers
{
    public class LoadTestResourceHelper
    {
        public class EnvironmentVariables
        {
            public static string RESOURCE_GROUP_NAME = "LOADTESTSERVICE_RESOURCE_GROUP";
        }

        public const string RESOURCE_LOCATION = "westus2";
        public const string LOADTESTS_RESOURCE_TYPE = "Microsoft.LoadTestService/loadtests";

        public static async Task TryRegisterResourceGroupAsync(ResourceGroupCollection resourceGroupsOperations, string location, string resourceGroupName)
        {
            await resourceGroupsOperations.CreateOrUpdateAsync(WaitUntil.Completed, resourceGroupName, new ResourceGroupData(location));
        }
    }
}
