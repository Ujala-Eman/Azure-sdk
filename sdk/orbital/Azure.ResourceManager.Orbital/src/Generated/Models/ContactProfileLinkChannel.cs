// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Orbital.Models
{
    /// <summary> Contact Profile Link Channel. </summary>
    public partial class ContactProfileLinkChannel
    {
        /// <summary> Initializes a new instance of ContactProfileLinkChannel. </summary>
        /// <param name="name"> Channel name. </param>
        /// <param name="centerFrequencyMHz"> Center Frequency in MHz. </param>
        /// <param name="bandwidthMHz"> Bandwidth in MHz. </param>
        /// <param name="endPoint"> Customer End point to store/retrieve data during a contact. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="endPoint"/> is null. </exception>
        public ContactProfileLinkChannel(string name, float centerFrequencyMHz, float bandwidthMHz, EndPoint endPoint)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (endPoint == null)
            {
                throw new ArgumentNullException(nameof(endPoint));
            }

            Name = name;
            CenterFrequencyMHz = centerFrequencyMHz;
            BandwidthMHz = bandwidthMHz;
            EndPoint = endPoint;
        }

        /// <summary> Initializes a new instance of ContactProfileLinkChannel. </summary>
        /// <param name="name"> Channel name. </param>
        /// <param name="centerFrequencyMHz"> Center Frequency in MHz. </param>
        /// <param name="bandwidthMHz"> Bandwidth in MHz. </param>
        /// <param name="endPoint"> Customer End point to store/retrieve data during a contact. </param>
        /// <param name="modulationConfiguration"> Copy of the modem configuration file such as Kratos QRadio. Only valid for uplink directions. If provided, the modem connects to the customer endpoint and accepts commands from the customer instead of a VITA.49 stream. </param>
        /// <param name="demodulationConfiguration"> Copy of the modem configuration file such as Kratos QRadio or Kratos QuantumRx. Only valid for downlink directions. If provided, the modem connects to the customer endpoint and sends demodulated data instead of a VITA.49 stream. </param>
        /// <param name="encodingConfiguration"> Currently unused. </param>
        /// <param name="decodingConfiguration"> Currently unused. </param>
        internal ContactProfileLinkChannel(string name, float centerFrequencyMHz, float bandwidthMHz, EndPoint endPoint, string modulationConfiguration, string demodulationConfiguration, string encodingConfiguration, string decodingConfiguration)
        {
            Name = name;
            CenterFrequencyMHz = centerFrequencyMHz;
            BandwidthMHz = bandwidthMHz;
            EndPoint = endPoint;
            ModulationConfiguration = modulationConfiguration;
            DemodulationConfiguration = demodulationConfiguration;
            EncodingConfiguration = encodingConfiguration;
            DecodingConfiguration = decodingConfiguration;
        }

        /// <summary> Channel name. </summary>
        public string Name { get; set; }
        /// <summary> Center Frequency in MHz. </summary>
        public float CenterFrequencyMHz { get; set; }
        /// <summary> Bandwidth in MHz. </summary>
        public float BandwidthMHz { get; set; }
        /// <summary> Customer End point to store/retrieve data during a contact. </summary>
        public EndPoint EndPoint { get; set; }
        /// <summary> Copy of the modem configuration file such as Kratos QRadio. Only valid for uplink directions. If provided, the modem connects to the customer endpoint and accepts commands from the customer instead of a VITA.49 stream. </summary>
        public string ModulationConfiguration { get; set; }
        /// <summary> Copy of the modem configuration file such as Kratos QRadio or Kratos QuantumRx. Only valid for downlink directions. If provided, the modem connects to the customer endpoint and sends demodulated data instead of a VITA.49 stream. </summary>
        public string DemodulationConfiguration { get; set; }
        /// <summary> Currently unused. </summary>
        public string EncodingConfiguration { get; set; }
        /// <summary> Currently unused. </summary>
        public string DecodingConfiguration { get; set; }
    }
}
