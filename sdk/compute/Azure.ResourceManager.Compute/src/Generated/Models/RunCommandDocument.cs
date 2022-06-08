// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the properties of a Run Command. </summary>
    public partial class RunCommandDocument : RunCommandDocumentBase
    {
        /// <summary> Initializes a new instance of <see cref="RunCommandDocument"/>. </summary>
        /// <param name="schema"> The VM run command schema. </param>
        /// <param name="id"> The VM run command id. </param>
        /// <param name="osType"> The Operating System type. </param>
        /// <param name="label"> The VM run command label. </param>
        /// <param name="description"> The VM run command description. </param>
        /// <param name="script"> The script to be executed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="schema"/>, <paramref name="id"/>, <paramref name="label"/>, <paramref name="description"/> or <paramref name="script"/> is null. </exception>
        internal RunCommandDocument(string schema, string id, OperatingSystemTypes osType, string label, string description, IEnumerable<string> script) : base(schema, id, osType, label, description)
        {
            if (schema == null)
            {
                throw new ArgumentNullException(nameof(schema));
            }
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (label == null)
            {
                throw new ArgumentNullException(nameof(label));
            }
            if (description == null)
            {
                throw new ArgumentNullException(nameof(description));
            }
            if (script == null)
            {
                throw new ArgumentNullException(nameof(script));
            }

            Script = script.ToList();
            Parameters = new ChangeTrackingList<RunCommandParameterDefinition>();
        }

        /// <summary> Initializes a new instance of <see cref="RunCommandDocument"/>. </summary>
        /// <param name="schema"> The VM run command schema. </param>
        /// <param name="id"> The VM run command id. </param>
        /// <param name="osType"> The Operating System type. </param>
        /// <param name="label"> The VM run command label. </param>
        /// <param name="description"> The VM run command description. </param>
        /// <param name="script"> The script to be executed. </param>
        /// <param name="parameters"> The parameters used by the script. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="schema"/>, <paramref name="id"/>, <paramref name="label"/> or <paramref name="description"/> is null. </exception>
        internal RunCommandDocument(string schema, string id, OperatingSystemTypes osType, string label, string description, IReadOnlyList<string> script, IReadOnlyList<RunCommandParameterDefinition> parameters) : base(schema, id, osType, label, description)
        {
            if (schema == null)
            {
                throw new ArgumentNullException(nameof(schema));
            }
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (label == null)
            {
                throw new ArgumentNullException(nameof(label));
            }
            if (description == null)
            {
                throw new ArgumentNullException(nameof(description));
            }

            Script = script;
            Parameters = parameters;
        }

        /// <summary> The script to be executed. </summary>
        public IReadOnlyList<string> Script { get; }
        /// <summary> The parameters used by the script. </summary>
        public IReadOnlyList<RunCommandParameterDefinition> Parameters { get; }
    }
}
