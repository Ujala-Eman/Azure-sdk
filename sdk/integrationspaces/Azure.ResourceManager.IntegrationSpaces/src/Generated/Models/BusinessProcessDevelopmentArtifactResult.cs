// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.IntegrationSpaces.Models
{
    /// <summary> The business process development artifact save or get response. </summary>
    public partial class BusinessProcessDevelopmentArtifactResult
    {
        /// <summary> Initializes a new instance of BusinessProcessDevelopmentArtifactResult. </summary>
        /// <param name="name"> The name of the business process development artifact. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal BusinessProcessDevelopmentArtifactResult(string name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Initializes a new instance of BusinessProcessDevelopmentArtifactResult. </summary>
        /// <param name="name"> The name of the business process development artifact. </param>
        /// <param name="systemData"> The system data of the business process development artifact. </param>
        /// <param name="properties"> The properties of the business process development artifact. </param>
        internal BusinessProcessDevelopmentArtifactResult(string name, SystemData systemData, BusinessProcessDevelopmentArtifactProperties properties)
        {
            Name = name;
            SystemData = systemData;
            Properties = properties;
        }

        /// <summary> The name of the business process development artifact. </summary>
        public string Name { get; }
        /// <summary> The system data of the business process development artifact. </summary>
        public SystemData SystemData { get; }
        /// <summary> The properties of the business process development artifact. </summary>
        public BusinessProcessDevelopmentArtifactProperties Properties { get; }
    }
}
