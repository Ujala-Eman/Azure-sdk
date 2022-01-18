// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AppPlatform.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Custom container payload
    /// </summary>
    public partial class CustomContainer
    {
        /// <summary>
        /// Initializes a new instance of the CustomContainer class.
        /// </summary>
        public CustomContainer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomContainer class.
        /// </summary>
        /// <param name="server">The name of the registry that contains the
        /// container image</param>
        /// <param name="containerImage">Container image of the custom
        /// container. This should be in the form of
        /// &lt;repository&gt;:&lt;tag&gt; without the server name of the
        /// registry</param>
        /// <param name="command">Entrypoint array. Not executed within a
        /// shell. The docker image's ENTRYPOINT is used if this is not
        /// provided.</param>
        /// <param name="args">Arguments to the entrypoint. The docker image's
        /// CMD is used if this is not provided.</param>
        /// <param name="imageRegistryCredential">Credential of the image
        /// registry</param>
        public CustomContainer(string server = default(string), string containerImage = default(string), IList<string> command = default(IList<string>), IList<string> args = default(IList<string>), ImageRegistryCredential imageRegistryCredential = default(ImageRegistryCredential))
        {
            Server = server;
            ContainerImage = containerImage;
            Command = command;
            Args = args;
            ImageRegistryCredential = imageRegistryCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the registry that contains the container
        /// image
        /// </summary>
        [JsonProperty(PropertyName = "server")]
        public string Server { get; set; }

        /// <summary>
        /// Gets or sets container image of the custom container. This should
        /// be in the form of &amp;lt;repository&amp;gt;:&amp;lt;tag&amp;gt;
        /// without the server name of the registry
        /// </summary>
        [JsonProperty(PropertyName = "containerImage")]
        public string ContainerImage { get; set; }

        /// <summary>
        /// Gets or sets entrypoint array. Not executed within a shell. The
        /// docker image's ENTRYPOINT is used if this is not provided.
        /// </summary>
        [JsonProperty(PropertyName = "command")]
        public IList<string> Command { get; set; }

        /// <summary>
        /// Gets or sets arguments to the entrypoint. The docker image's CMD is
        /// used if this is not provided.
        /// </summary>
        [JsonProperty(PropertyName = "args")]
        public IList<string> Args { get; set; }

        /// <summary>
        /// Gets or sets credential of the image registry
        /// </summary>
        [JsonProperty(PropertyName = "imageRegistryCredential")]
        public ImageRegistryCredential ImageRegistryCredential { get; set; }

    }
}
