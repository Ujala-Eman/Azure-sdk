﻿using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Tests
{
    public class TestTrackedResource : TrackedResource
    {
        public TestTrackedResource(ResourceIdentifier id) : this(id, Location.WestUS2)
        {
        }

        public TestTrackedResource(ResourceIdentifier id, string location)
            :base(id, id.Name, id.ResourceType, location, null)
        {
        }
    }
}
