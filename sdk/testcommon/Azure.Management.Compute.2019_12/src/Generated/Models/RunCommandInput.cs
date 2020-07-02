// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    /// <summary> Capture Virtual Machine parameters. </summary>
    public partial class RunCommandInput
    {
        /// <summary> Initializes a new instance of RunCommandInput. </summary>
        /// <param name="commandId"> The run command id. </param>
        public RunCommandInput(string commandId)
        {
            if (commandId == null)
            {
                throw new ArgumentNullException(nameof(commandId));
            }

            CommandId = commandId;
            Script = new ChangeTrackingList<string>();
            Parameters = new ChangeTrackingList<RunCommandInputParameter>();
        }

        /// <summary> Initializes a new instance of RunCommandInput. </summary>
        /// <param name="commandId"> The run command id. </param>
        /// <param name="script"> Optional. The script to be executed.  When this value is given, the given script will override the default script of the command. </param>
        /// <param name="parameters"> The run command parameters. </param>
        internal RunCommandInput(string commandId, IList<string> script, IList<RunCommandInputParameter> parameters)
        {
            CommandId = commandId;
            Script = script;
            Parameters = parameters;
        }

        /// <summary> The run command id. </summary>
        public string CommandId { get; }
        /// <summary> Optional. The script to be executed.  When this value is given, the given script will override the default script of the command. </summary>
        public IList<string> Script { get; }
        /// <summary> The run command parameters. </summary>
        public IList<RunCommandInputParameter> Parameters { get; }
    }
}
