// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Information about an issue encountered in the process of checking for connectivity. </summary>
    public partial class ConnectivityIssue
    {
        /// <summary> Initializes a new instance of <see cref="ConnectivityIssue"/>. </summary>
        internal ConnectivityIssue()
        {
            Context = new ChangeTrackingList<IDictionary<string, string>>();
        }

        /// <summary> Initializes a new instance of <see cref="ConnectivityIssue"/>. </summary>
        /// <param name="origin"> The origin of the issue. </param>
        /// <param name="severity"> The severity of the issue. </param>
        /// <param name="issueType"> The type of issue. </param>
        /// <param name="context"> Provides additional context on the issue. </param>
        internal ConnectivityIssue(Origin? origin, Severity? severity, IssueType? issueType, IReadOnlyList<IDictionary<string, string>> context)
        {
            Origin = origin;
            Severity = severity;
            IssueType = issueType;
            Context = context;
        }

        /// <summary> The origin of the issue. </summary>
        public Origin? Origin { get; }
        /// <summary> The severity of the issue. </summary>
        public Severity? Severity { get; }
        /// <summary> The type of issue. </summary>
        public IssueType? IssueType { get; }
        /// <summary> Provides additional context on the issue. </summary>
        public IReadOnlyList<IDictionary<string, string>> Context { get; }
    }
}
