// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement.Models
{

    /// <summary>
    /// Defines values for PortalSettingsCspMode.
    /// </summary>
    public static class PortalSettingsCspMode
    {
        /// <summary>
        /// The browser will block requests not matching allowed origins.
        /// </summary>
        public const string Enabled = "enabled";
        /// <summary>
        /// The browser will not apply the origin restrictions.
        /// </summary>
        public const string Disabled = "disabled";
        /// <summary>
        /// The browser will report requests not matching allowed origins
        /// without blocking them.
        /// </summary>
        public const string ReportOnly = "reportOnly";
    }
}
