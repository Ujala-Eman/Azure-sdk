// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Management.Models
{
    /// <summary> Required if nameAvailable == false. Invalid indicates the name provided does not match the resource provider&apos;s naming requirements (incorrect length, unsupported characters, etc.) AlreadyExists indicates that the name is already in use and is therefore unavailable. </summary>
    public enum Reason
    {
        /// <summary> Invalid. </summary>
        Invalid,
        /// <summary> AlreadyExists. </summary>
        AlreadyExists
    }
}
