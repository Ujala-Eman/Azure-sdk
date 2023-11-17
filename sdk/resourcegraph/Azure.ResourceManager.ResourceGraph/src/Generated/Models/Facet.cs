// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceGraph.Models
{
    /// <summary>
    /// A facet containing additional statistics on the response of a query. Can be either FacetResult or FacetError.
    /// Please note <see cref="Facet"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="FacetError"/> and <see cref="FacetResult"/>.
    /// </summary>
    public abstract partial class Facet
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
        protected internal IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="Facet"/>. </summary>
        /// <param name="expression"> Facet expression, same as in the corresponding facet request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="expression"/> is null. </exception>
        protected Facet(string expression)
        {
            Argument.AssertNotNull(expression, nameof(expression));

            Expression = expression;
        }

        /// <summary> Initializes a new instance of <see cref="Facet"/>. </summary>
        /// <param name="expression"> Facet expression, same as in the corresponding facet request. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal Facet(string expression, string resultType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Expression = expression;
            ResultType = resultType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="Facet"/> for deserialization. </summary>
        internal Facet()
        {
        }

        /// <summary> Facet expression, same as in the corresponding facet request. </summary>
        public string Expression { get; }
        /// <summary> Result type. </summary>
        internal string ResultType { get; set; }
    }
}
