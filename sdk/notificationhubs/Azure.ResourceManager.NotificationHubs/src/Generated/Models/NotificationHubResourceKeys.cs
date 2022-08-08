// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NotificationHubs.Models
{
    /// <summary> Namespace/NotificationHub Connection String. </summary>
    public partial class NotificationHubResourceKeys
    {
        /// <summary> Initializes a new instance of NotificationHubResourceKeys. </summary>
        internal NotificationHubResourceKeys()
        {
        }

        /// <summary> Initializes a new instance of NotificationHubResourceKeys. </summary>
        /// <param name="primaryConnectionString"> PrimaryConnectionString of the AuthorizationRule. </param>
        /// <param name="secondaryConnectionString"> SecondaryConnectionString of the created AuthorizationRule. </param>
        /// <param name="primaryKey"> PrimaryKey of the created AuthorizationRule. </param>
        /// <param name="secondaryKey"> SecondaryKey of the created AuthorizationRule. </param>
        /// <param name="keyName"> KeyName of the created AuthorizationRule. </param>
        internal NotificationHubResourceKeys(string primaryConnectionString, string secondaryConnectionString, string primaryKey, string secondaryKey, string keyName)
        {
            PrimaryConnectionString = primaryConnectionString;
            SecondaryConnectionString = secondaryConnectionString;
            PrimaryKey = primaryKey;
            SecondaryKey = secondaryKey;
            KeyName = keyName;
        }

        /// <summary> PrimaryConnectionString of the AuthorizationRule. </summary>
        public string PrimaryConnectionString { get; }
        /// <summary> SecondaryConnectionString of the created AuthorizationRule. </summary>
        public string SecondaryConnectionString { get; }
        /// <summary> PrimaryKey of the created AuthorizationRule. </summary>
        public string PrimaryKey { get; }
        /// <summary> SecondaryKey of the created AuthorizationRule. </summary>
        public string SecondaryKey { get; }
        /// <summary> KeyName of the created AuthorizationRule. </summary>
        public string KeyName { get; }
    }
}
