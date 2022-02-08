// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.StackHCI
{
    /// <summary> A class to add extension methods to ArmClient. </summary>
    public static partial class ArmClientExtensions
    {
        #region ArcSetting
        /// <summary> Gets an object representing a ArcSetting along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ArcSetting" /> object. </returns>
        public static ArcSetting GetArcSetting(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ArcSetting(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region HCICluster
        /// <summary> Gets an object representing a HCICluster along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HCICluster" /> object. </returns>
        public static HCICluster GetHCICluster(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new HCICluster(clientOptions, credential, uri, pipeline, id));
        }
        #endregion

        #region ArcExtension
        /// <summary> Gets an object representing a ArcExtension along with the instance operations that can be performed on it but with no data. </summary>
        /// <param name="armClient"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="ArcExtension" /> object. </returns>
        public static ArcExtension GetArcExtension(this ArmClient armClient, ResourceIdentifier id)
        {
            return armClient.UseClientContext((uri, credential, clientOptions, pipeline) => new ArcExtension(clientOptions, credential, uri, pipeline, id));
        }
        #endregion
    }
}
