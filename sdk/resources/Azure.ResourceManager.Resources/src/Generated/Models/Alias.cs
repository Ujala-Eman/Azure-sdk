// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> The alias type. </summary>
    public partial class Alias
    {
        /// <summary> Initializes a new instance of Alias. </summary>
        internal Alias()
        {
            Paths = new ChangeTrackingList<AliasPath>();
        }

        /// <summary> Initializes a new instance of Alias. </summary>
        /// <param name="name"> The alias name. </param>
        /// <param name="paths"> The paths for an alias. </param>
        /// <param name="type"> The type of the alias. </param>
        /// <param name="defaultPath"> The default path for an alias. </param>
        /// <param name="defaultPattern"> The default pattern for an alias. </param>
        internal Alias(string name, IReadOnlyList<AliasPath> paths, AliasType? type, string defaultPath, AliasPattern defaultPattern)
        {
            Name = name;
            Paths = paths;
            Type = type;
            DefaultPath = defaultPath;
            DefaultPattern = defaultPattern;
        }

        /// <summary> The alias name. </summary>
        public string Name { get; }
        /// <summary> The paths for an alias. </summary>
        public IReadOnlyList<AliasPath> Paths { get; }
        /// <summary> The type of the alias. </summary>
        public AliasType? Type { get; }
        /// <summary> The default path for an alias. </summary>
        public string DefaultPath { get; }
        /// <summary> The default pattern for an alias. </summary>
        public AliasPattern DefaultPattern { get; }
    }
}
