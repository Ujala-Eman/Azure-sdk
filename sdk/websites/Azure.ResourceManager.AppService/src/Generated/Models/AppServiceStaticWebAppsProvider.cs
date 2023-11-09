// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> The configuration settings of the Azure Static Web Apps provider. </summary>
    public partial class AppServiceStaticWebAppsProvider
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AppServiceStaticWebAppsProvider"/>. </summary>
        public AppServiceStaticWebAppsProvider()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AppServiceStaticWebAppsProvider"/>. </summary>
        /// <param name="isEnabled"> &lt;code&gt;false&lt;/code&gt; if the Azure Static Web Apps provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </param>
        /// <param name="registration"> The configuration settings of the Azure Static Web Apps registration. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppServiceStaticWebAppsProvider(bool? isEnabled, AppServiceStaticWebAppsRegistration registration, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            IsEnabled = isEnabled;
            Registration = registration;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> &lt;code&gt;false&lt;/code&gt; if the Azure Static Web Apps provider should not be enabled despite the set registration; otherwise, &lt;code&gt;true&lt;/code&gt;. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The configuration settings of the Azure Static Web Apps registration. </summary>
        internal AppServiceStaticWebAppsRegistration Registration { get; set; }
        /// <summary> The Client ID of the app used for login. </summary>
        public string RegistrationClientId
        {
            get => Registration is null ? default : Registration.ClientId;
            set
            {
                if (Registration is null)
                    Registration = new AppServiceStaticWebAppsRegistration();
                Registration.ClientId = value;
            }
        }
    }
}
