// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the regenerate keys operation. </summary>
    public partial class AgentRegistrationRegenerateKeyContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AgentRegistrationRegenerateKeyContent"/>. </summary>
        /// <param name="keyName"> Gets or sets the agent registration key name - primary or secondary. </param>
        public AgentRegistrationRegenerateKeyContent(AgentRegistrationKeyName keyName)
        {
            KeyName = keyName;
        }

        /// <summary> Initializes a new instance of <see cref="AgentRegistrationRegenerateKeyContent"/>. </summary>
        /// <param name="keyName"> Gets or sets the agent registration key name - primary or secondary. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AgentRegistrationRegenerateKeyContent(AgentRegistrationKeyName keyName, Dictionary<string, BinaryData> rawData)
        {
            KeyName = keyName;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="AgentRegistrationRegenerateKeyContent"/> for deserialization. </summary>
        internal AgentRegistrationRegenerateKeyContent()
        {
        }

        /// <summary> Gets or sets the agent registration key name - primary or secondary. </summary>
        public AgentRegistrationKeyName KeyName { get; }
    }
}
