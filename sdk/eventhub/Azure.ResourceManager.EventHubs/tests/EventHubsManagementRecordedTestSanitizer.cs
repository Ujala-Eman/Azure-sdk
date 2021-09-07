﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;
using Castle.Core.Internal;

namespace Azure.ResourceManager.EventHubs.Tests
{
    public class EventHubsManagementRecordedTestSanitizer : RecordedTestSanitizer
    {
        public EventHubsManagementRecordedTestSanitizer() : base()
        {
            // Lazy sanitize fields in the request and response bodies
            AddJsonPathSanitizer("$..UpdatePrimaryKey");
            AddJsonPathSanitizer("$..CreatePrimaryKey");
        }

        public override void Sanitize(RecordSession session)
        {
            base.Sanitize(session);
        }
    }
}
