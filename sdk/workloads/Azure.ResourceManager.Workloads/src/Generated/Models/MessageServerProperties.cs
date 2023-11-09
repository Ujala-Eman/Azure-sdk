// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Defines the SAP Message Server properties. </summary>
    public partial class MessageServerProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MessageServerProperties"/>. </summary>
        public MessageServerProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="MessageServerProperties"/>. </summary>
        /// <param name="msPort"> Message Server port. </param>
        /// <param name="internalMsPort"> Message Server internal MS port. </param>
        /// <param name="httpPort"> Message Server HTTP Port. </param>
        /// <param name="httpsPort"> Message Server HTTPS Port. </param>
        /// <param name="hostname"> Message Server SAP Hostname. </param>
        /// <param name="ipAddress"> Message server IP Address. </param>
        /// <param name="health"> Defines the health of SAP Instances. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MessageServerProperties(long? msPort, long? internalMsPort, long? httpPort, long? httpsPort, string hostname, string ipAddress, SapHealthState? health, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            MsPort = msPort;
            InternalMsPort = internalMsPort;
            HttpPort = httpPort;
            HttpsPort = httpsPort;
            Hostname = hostname;
            IPAddress = ipAddress;
            Health = health;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Message Server port. </summary>
        public long? MsPort { get; }
        /// <summary> Message Server internal MS port. </summary>
        public long? InternalMsPort { get; }
        /// <summary> Message Server HTTP Port. </summary>
        public long? HttpPort { get; }
        /// <summary> Message Server HTTPS Port. </summary>
        public long? HttpsPort { get; }
        /// <summary> Message Server SAP Hostname. </summary>
        public string Hostname { get; }
        /// <summary> Message server IP Address. </summary>
        public string IPAddress { get; }
        /// <summary> Defines the health of SAP Instances. </summary>
        public SapHealthState? Health { get; }
    }
}
