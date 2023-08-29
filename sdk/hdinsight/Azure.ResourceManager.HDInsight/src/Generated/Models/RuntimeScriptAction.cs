// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> Describes a script action on a running cluster. </summary>
    public partial class RuntimeScriptAction
    {
        protected internal Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RuntimeScriptAction"/>. </summary>
        /// <param name="name"> The name of the script action. </param>
        /// <param name="uri"> The URI to the script. </param>
        /// <param name="roles"> The list of roles where script will be executed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="uri"/> or <paramref name="roles"/> is null. </exception>
        public RuntimeScriptAction(string name, Uri uri, IEnumerable<string> roles)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(uri, nameof(uri));
            Argument.AssertNotNull(roles, nameof(roles));

            Name = name;
            Uri = uri;
            Roles = roles.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="RuntimeScriptAction"/>. </summary>
        /// <param name="name"> The name of the script action. </param>
        /// <param name="uri"> The URI to the script. </param>
        /// <param name="parameters"> The parameters for the script. </param>
        /// <param name="roles"> The list of roles where script will be executed. </param>
        /// <param name="applicationName"> The application name of the script action, if any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RuntimeScriptAction(string name, Uri uri, string parameters, IList<string> roles, string applicationName, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Uri = uri;
            Parameters = parameters;
            Roles = roles;
            ApplicationName = applicationName;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="RuntimeScriptAction"/> for deserialization. </summary>
        internal RuntimeScriptAction()
        {
        }

        /// <summary> The name of the script action. </summary>
        public string Name { get; set; }
        /// <summary> The URI to the script. </summary>
        public Uri Uri { get; set; }
        /// <summary> The parameters for the script. </summary>
        public string Parameters { get; set; }
        /// <summary> The list of roles where script will be executed. </summary>
        public IList<string> Roles { get; }
        /// <summary> The application name of the script action, if any. </summary>
        public string ApplicationName { get; }
    }
}
