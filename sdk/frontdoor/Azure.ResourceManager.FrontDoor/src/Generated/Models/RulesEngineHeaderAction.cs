// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> An action that can manipulate an http header. </summary>
    public partial class RulesEngineHeaderAction
    {
        /// <summary> Initializes a new instance of RulesEngineHeaderAction. </summary>
        /// <param name="headerActionType"> Which type of manipulation to apply to the header. </param>
        /// <param name="headerName"> The name of the header this action will apply to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="headerName"/> is null. </exception>
        public RulesEngineHeaderAction(RulesEngineHeaderActionType headerActionType, string headerName)
        {
            if (headerName == null)
            {
                throw new ArgumentNullException(nameof(headerName));
            }

            HeaderActionType = headerActionType;
            HeaderName = headerName;
        }

        /// <summary> Initializes a new instance of RulesEngineHeaderAction. </summary>
        /// <param name="headerActionType"> Which type of manipulation to apply to the header. </param>
        /// <param name="headerName"> The name of the header this action will apply to. </param>
        /// <param name="value"> The value to update the given header name with. This value is not used if the actionType is Delete. </param>
        internal RulesEngineHeaderAction(RulesEngineHeaderActionType headerActionType, string headerName, string value)
        {
            HeaderActionType = headerActionType;
            HeaderName = headerName;
            Value = value;
        }

        /// <summary> Which type of manipulation to apply to the header. </summary>
        public RulesEngineHeaderActionType HeaderActionType { get; set; }
        /// <summary> The name of the header this action will apply to. </summary>
        public string HeaderName { get; set; }
        /// <summary> The value to update the given header name with. This value is not used if the actionType is Delete. </summary>
        public string Value { get; set; }
    }
}
