// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> The ListStorageAccountKeysResult. </summary>
    public partial class ListStorageAccountKeysResult
    {
        /// <summary> Initializes a new instance of ListStorageAccountKeysResult. </summary>
        internal ListStorageAccountKeysResult()
        {
        }

        /// <summary> Initializes a new instance of ListStorageAccountKeysResult. </summary>
        /// <param name="userStorageKey"> . </param>
        internal ListStorageAccountKeysResult(string userStorageKey)
        {
            UserStorageKey = userStorageKey;
        }

        public string UserStorageKey { get; }
    }
}
