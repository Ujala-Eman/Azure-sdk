// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The Api reference. </summary>
    public partial class LogicApiReference : LogicResourceReference
    {
        /// <summary> Initializes a new instance of LogicApiReference. </summary>
        public LogicApiReference()
        {
        }

        /// <summary> Initializes a new instance of LogicApiReference. </summary>
        /// <param name="id"> The resource id. </param>
        /// <param name="name"> Gets the resource name. </param>
        /// <param name="resourceType"> Gets the resource type. </param>
        /// <param name="displayName"> The display name of the api. </param>
        /// <param name="description"> The description of the api. </param>
        /// <param name="iconUri"> The icon uri of the api. </param>
        /// <param name="swagger"> The swagger of the api. </param>
        /// <param name="brandColor"> The brand color of the api. </param>
        /// <param name="category"> The tier. </param>
        /// <param name="integrationServiceEnvironment"> The integration service environment reference. </param>
        internal LogicApiReference(ResourceIdentifier id, string name, ResourceType? resourceType, string displayName, string description, Uri iconUri, BinaryData swagger, string brandColor, LogicApiTier? category, LogicResourceReference integrationServiceEnvironment) : base(id, name, resourceType)
        {
            DisplayName = displayName;
            Description = description;
            IconUri = iconUri;
            Swagger = swagger;
            BrandColor = brandColor;
            Category = category;
            IntegrationServiceEnvironment = integrationServiceEnvironment;
        }

        /// <summary> The display name of the api. </summary>
        public string DisplayName { get; set; }
        /// <summary> The description of the api. </summary>
        public string Description { get; set; }
        /// <summary> The icon uri of the api. </summary>
        public Uri IconUri { get; set; }
        /// <summary>
        /// The swagger of the api.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Swagger { get; set; }
        /// <summary> The brand color of the api. </summary>
        public string BrandColor { get; set; }
        /// <summary> The tier. </summary>
        public LogicApiTier? Category { get; set; }
        /// <summary> The integration service environment reference. </summary>
        public LogicResourceReference IntegrationServiceEnvironment { get; set; }
    }
}
