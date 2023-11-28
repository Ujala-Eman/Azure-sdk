// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Defines the SAP Gateway Server properties. </summary>
    public partial class GatewayServerProperties
    {
        /// <summary> Initializes a new instance of <see cref="GatewayServerProperties"/>. </summary>
        public GatewayServerProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GatewayServerProperties"/>. </summary>
        /// <param name="port"> Gateway Port. </param>
        /// <param name="health"> Defines the health of SAP Instances. </param>
        internal GatewayServerProperties(long? port, SapHealthState? health)
        {
            Port = port;
            Health = health;
        }

        /// <summary> Gateway Port. </summary>
        public long? Port { get; }
        /// <summary> Defines the health of SAP Instances. </summary>
        public SapHealthState? Health { get; }
    }
}
