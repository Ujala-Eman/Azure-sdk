// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Linked service for AppFigures. </summary>
    public partial class AppFiguresLinkedService : LinkedService
    {
        /// <summary> Initializes a new instance of AppFiguresLinkedService. </summary>
        /// <param name="userName"> The username of the Appfigures source. </param>
        /// <param name="password"> The password of the AppFigures source. </param>
        /// <param name="clientKey"> The client key for the AppFigures source. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="userName"/>, <paramref name="password"/> or <paramref name="clientKey"/> is null. </exception>
        public AppFiguresLinkedService(object userName, SecretBase password, SecretBase clientKey)
        {
            if (userName == null)
            {
                throw new ArgumentNullException(nameof(userName));
            }
            if (password == null)
            {
                throw new ArgumentNullException(nameof(password));
            }
            if (clientKey == null)
            {
                throw new ArgumentNullException(nameof(clientKey));
            }

            UserName = userName;
            Password = password;
            ClientKey = clientKey;
            Type = "AppFigures";
        }

        /// <summary> Initializes a new instance of AppFiguresLinkedService. </summary>
        /// <param name="type"> Type of linked service. </param>
        /// <param name="connectVia"> The integration runtime reference. </param>
        /// <param name="description"> Linked service description. </param>
        /// <param name="parameters"> Parameters for linked service. </param>
        /// <param name="annotations"> List of tags that can be used for describing the linked service. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="userName"> The username of the Appfigures source. </param>
        /// <param name="password"> The password of the AppFigures source. </param>
        /// <param name="clientKey"> The client key for the AppFigures source. </param>
        internal AppFiguresLinkedService(string type, IntegrationRuntimeReference connectVia, string description, IDictionary<string, ParameterSpecification> parameters, IList<object> annotations, IDictionary<string, object> additionalProperties, object userName, SecretBase password, SecretBase clientKey) : base(type, connectVia, description, parameters, annotations, additionalProperties)
        {
            UserName = userName;
            Password = password;
            ClientKey = clientKey;
            Type = type ?? "AppFigures";
        }

        /// <summary> The username of the Appfigures source. </summary>
        public object UserName { get; set; }
        /// <summary> The password of the AppFigures source. </summary>
        public SecretBase Password { get; set; }
        /// <summary> The client key for the AppFigures source. </summary>
        public SecretBase ClientKey { get; set; }
    }
}
