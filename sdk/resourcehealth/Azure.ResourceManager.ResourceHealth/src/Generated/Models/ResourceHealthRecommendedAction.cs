// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> Lists actions the user can take based on the current availabilityState of the resource. </summary>
    public partial class ResourceHealthRecommendedAction
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ResourceHealthRecommendedAction"/>. </summary>
        internal ResourceHealthRecommendedAction()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ResourceHealthRecommendedAction"/>. </summary>
        /// <param name="action"> Recommended action. </param>
        /// <param name="actionUri"> Link to the action. </param>
        /// <param name="actionUriComment"> the comment for the Action. </param>
        /// <param name="actionUriText"> Substring of action, it describes which text should host the action URL. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ResourceHealthRecommendedAction(string action, Uri actionUri, string actionUriComment, string actionUriText, Dictionary<string, BinaryData> rawData)
        {
            Action = action;
            ActionUri = actionUri;
            ActionUriComment = actionUriComment;
            ActionUriText = actionUriText;
            _rawData = rawData;
        }

        /// <summary> Recommended action. </summary>
        public string Action { get; }
        /// <summary> Link to the action. </summary>
        public Uri ActionUri { get; }
        /// <summary> the comment for the Action. </summary>
        public string ActionUriComment { get; }
        /// <summary> Substring of action, it describes which text should host the action URL. </summary>
        public string ActionUriText { get; }
    }
}
