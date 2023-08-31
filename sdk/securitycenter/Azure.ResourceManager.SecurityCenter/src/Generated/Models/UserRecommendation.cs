// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Represents a user that is recommended to be allowed for a certain rule. </summary>
    public partial class UserRecommendation
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="UserRecommendation"/>. </summary>
        public UserRecommendation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="UserRecommendation"/>. </summary>
        /// <param name="username"> Represents a user that is recommended to be allowed for a certain rule. </param>
        /// <param name="recommendationAction"> The recommendation action of the machine or rule. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UserRecommendation(string username, RecommendationAction? recommendationAction, Dictionary<string, BinaryData> rawData)
        {
            Username = username;
            RecommendationAction = recommendationAction;
            _rawData = rawData;
        }

        /// <summary> Represents a user that is recommended to be allowed for a certain rule. </summary>
        public string Username { get; set; }
        /// <summary> The recommendation action of the machine or rule. </summary>
        public RecommendationAction? RecommendationAction { get; set; }
    }
}
