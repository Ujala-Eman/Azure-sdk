// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The KqlScriptContent. </summary>
    public partial class KqlScriptContent
    {
        /// <summary> Initializes a new instance of KqlScriptContent. </summary>
        public KqlScriptContent()
        {
        }

        /// <summary> Initializes a new instance of KqlScriptContent. </summary>
        /// <param name="query"></param>
        /// <param name="metadata"></param>
        /// <param name="currentConnection"></param>
        internal KqlScriptContent(string query, KqlScriptContentMetadata metadata, KqlScriptContentCurrentConnection currentConnection)
        {
            Query = query;
            Metadata = metadata;
            CurrentConnection = currentConnection;
        }

        /// <summary> Gets or sets the query. </summary>
        public string Query { get; set; }
        /// <summary> Gets or sets the metadata. </summary>
        public KqlScriptContentMetadata Metadata { get; set; }
        /// <summary> Gets or sets the current connection. </summary>
        public KqlScriptContentCurrentConnection CurrentConnection { get; set; }
    }
}
