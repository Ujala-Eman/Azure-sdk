// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Describes the status of a service of a HDInsight on aks cluster. </summary>
    public partial class HDInsightServiceStatus
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HDInsightServiceStatus"/>. </summary>
        /// <param name="kind"> Kind of the service. E.g. "Zookeeper". </param>
        /// <param name="ready"> Indicates if the service is ready / healthy. Values can be "true", "false", "unknown" or anything else. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="kind"/> or <paramref name="ready"/> is null. </exception>
        internal HDInsightServiceStatus(string kind, string ready)
        {
            Argument.AssertNotNull(kind, nameof(kind));
            Argument.AssertNotNull(ready, nameof(ready));

            Kind = kind;
            Ready = ready;
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightServiceStatus"/>. </summary>
        /// <param name="kind"> Kind of the service. E.g. "Zookeeper". </param>
        /// <param name="ready"> Indicates if the service is ready / healthy. Values can be "true", "false", "unknown" or anything else. </param>
        /// <param name="message"> A message describing the error if any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightServiceStatus(string kind, string ready, string message, Dictionary<string, BinaryData> rawData)
        {
            Kind = kind;
            Ready = ready;
            Message = message;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightServiceStatus"/> for deserialization. </summary>
        internal HDInsightServiceStatus()
        {
        }

        /// <summary> Kind of the service. E.g. "Zookeeper". </summary>
        public string Kind { get; }
        /// <summary> Indicates if the service is ready / healthy. Values can be "true", "false", "unknown" or anything else. </summary>
        public string Ready { get; }
        /// <summary> A message describing the error if any. </summary>
        public string Message { get; }
    }
}
