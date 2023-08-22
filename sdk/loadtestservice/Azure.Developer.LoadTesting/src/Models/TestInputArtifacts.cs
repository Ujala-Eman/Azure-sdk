// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Json;

namespace Azure.Developer.LoadTesting.Models
{
    /// <summary> The input artifacts for the test. </summary>
    public partial class TestInputArtifacts
    {
        private MutableJsonElement _element;

        /// <summary> Initializes a new instance of TestInputArtifacts. </summary>
        internal TestInputArtifacts()
        {
            _element = MutableJsonDocument.Parse(MutableJsonDocument.EmptyJson).RootElement;

            AdditionalFileInfo = new MutableJsonReadOnlyList<FileInfo>(_element.GetProperty("additionalFileInfo"));
        }

        internal TestInputArtifacts(MutableJsonElement element)
        {
            _element = element;

            // TODO: TryGetProperty

            ConfigFileInfo = new FileInfo(_element.GetProperty("configFileInfo"));
            TestScriptFileInfo = new FileInfo(_element.GetProperty("testScriptFileInfo"));
            UserPropFileInfo = new FileInfo(_element.GetProperty("userPropFileInfo"));
            InputArtifactsZipFileInfo = new FileInfo(_element.GetProperty("inputArtifactsZipFileInfo"));

            AdditionalFileInfo = new MutableJsonReadOnlyList<FileInfo>(_element.GetProperty("additionalFileInfo"));
        }

        /// <summary> File info. </summary>
        public FileInfo ConfigFileInfo { get; }

        /// <summary> File info. </summary>
        public FileInfo TestScriptFileInfo { get; }

        /// <summary> File info. </summary>
        public FileInfo UserPropFileInfo { get; }

        /// <summary> File info. </summary>
        public FileInfo InputArtifactsZipFileInfo { get; }

        /// <summary> Additional supported files for the test run. </summary>
        public IReadOnlyList<FileInfo> AdditionalFileInfo { get; }
    }
}
