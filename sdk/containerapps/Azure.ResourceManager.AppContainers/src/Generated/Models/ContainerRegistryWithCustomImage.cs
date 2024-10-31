// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Container registry that the final image will be uploaded to. </summary>
    public partial class ContainerRegistryWithCustomImage
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryWithCustomImage"/>. </summary>
        /// <param name="server"> Login server of the container registry that the final image should be uploaded to. Builder resource needs to have this container registry defined along with an identity to use to access it. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="server"/> is null. </exception>
        public ContainerRegistryWithCustomImage(string server)
        {
            Argument.AssertNotNull(server, nameof(server));

            Server = server;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryWithCustomImage"/>. </summary>
        /// <param name="server"> Login server of the container registry that the final image should be uploaded to. Builder resource needs to have this container registry defined along with an identity to use to access it. </param>
        /// <param name="image"> Full name that the final image should be uploaded as, including both image name and tag. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ContainerRegistryWithCustomImage(string server, string image, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Server = server;
            Image = image;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ContainerRegistryWithCustomImage"/> for deserialization. </summary>
        internal ContainerRegistryWithCustomImage()
        {
        }

        /// <summary> Login server of the container registry that the final image should be uploaded to. Builder resource needs to have this container registry defined along with an identity to use to access it. </summary>
        [WirePath("server")]
        public string Server { get; set; }
        /// <summary> Full name that the final image should be uploaded as, including both image name and tag. </summary>
        [WirePath("image")]
        public string Image { get; set; }
    }
}
