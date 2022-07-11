// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    internal static partial class ContainerWorkingDirectoryExtensions
    {
        public static string ToSerialString(this ContainerWorkingDirectory value) => value switch
        {
            ContainerWorkingDirectory.TaskWorkingDirectory => "TaskWorkingDirectory",
            ContainerWorkingDirectory.ContainerImageDefault => "ContainerImageDefault",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ContainerWorkingDirectory value.")
        };

        public static ContainerWorkingDirectory ToContainerWorkingDirectory(this string value)
        {
            if (string.Equals(value, "TaskWorkingDirectory", StringComparison.InvariantCultureIgnoreCase)) return ContainerWorkingDirectory.TaskWorkingDirectory;
            if (string.Equals(value, "ContainerImageDefault", StringComparison.InvariantCultureIgnoreCase)) return ContainerWorkingDirectory.ContainerImageDefault;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ContainerWorkingDirectory value.");
        }
    }
}
