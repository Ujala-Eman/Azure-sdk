// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Dns.Models
{
    /// <summary> An NS record. </summary>
    public partial class NsRecord
    {
        /// <summary> Initializes a new instance of NsRecord. </summary>
        public NsRecord()
        {
        }

        /// <summary> Initializes a new instance of NsRecord. </summary>
        /// <param name="nsdname"> The name server name for this NS record. </param>
        internal NsRecord(string nsdname)
        {
            Nsdname = nsdname;
        }

        /// <summary> The name server name for this NS record. </summary>
        public string Nsdname { get; set; }
    }
}
