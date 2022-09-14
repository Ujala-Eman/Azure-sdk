// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Custom script action to run on HDI ondemand cluster once it&apos;s up. </summary>
    public partial class ScriptAction
    {
        /// <summary> Initializes a new instance of ScriptAction. </summary>
        /// <param name="name"> The user provided name of the script action. </param>
        /// <param name="uri"> The URI for the script action. </param>
        /// <param name="roles"> The node types on which the script action should be executed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="uri"/> or <paramref name="roles"/> is null. </exception>
        public ScriptAction(string name, Uri uri, BinaryData roles)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (uri == null)
            {
                throw new ArgumentNullException(nameof(uri));
            }
            if (roles == null)
            {
                throw new ArgumentNullException(nameof(roles));
            }

            Name = name;
            Uri = uri;
            Roles = roles;
        }

        /// <summary> Initializes a new instance of ScriptAction. </summary>
        /// <param name="name"> The user provided name of the script action. </param>
        /// <param name="uri"> The URI for the script action. </param>
        /// <param name="roles"> The node types on which the script action should be executed. </param>
        /// <param name="parameters"> The parameters for the script action. </param>
        internal ScriptAction(string name, Uri uri, BinaryData roles, string parameters)
        {
            Name = name;
            Uri = uri;
            Roles = roles;
            Parameters = parameters;
        }

        /// <summary> The user provided name of the script action. </summary>
        public string Name { get; set; }
        /// <summary> The URI for the script action. </summary>
        public Uri Uri { get; set; }
        /// <summary>
        /// The node types on which the script action should be executed.
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
        public BinaryData Roles { get; set; }
        /// <summary> The parameters for the script action. </summary>
        public string Parameters { get; set; }
    }
}
