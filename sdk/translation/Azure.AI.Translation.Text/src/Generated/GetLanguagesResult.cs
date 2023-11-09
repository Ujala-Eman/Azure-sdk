// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    /// <summary> Response for the languages API. </summary>
    public partial class GetLanguagesResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="GetLanguagesResult"/>. </summary>
        internal GetLanguagesResult()
        {
            Translation = new ChangeTrackingDictionary<string, TranslationLanguage>();
            Transliteration = new ChangeTrackingDictionary<string, TransliterationLanguage>();
            Dictionary = new ChangeTrackingDictionary<string, SourceDictionaryLanguage>();
            _serializedAdditionalRawData = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="GetLanguagesResult"/>. </summary>
        /// <param name="translation"> Languages that support translate API. </param>
        /// <param name="transliteration"> Languages that support transliteration API. </param>
        /// <param name="dictionary"> Languages that support dictionary API. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal GetLanguagesResult(IReadOnlyDictionary<string, TranslationLanguage> translation, IReadOnlyDictionary<string, TransliterationLanguage> transliteration, IReadOnlyDictionary<string, SourceDictionaryLanguage> dictionary, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Translation = translation;
            Transliteration = transliteration;
            Dictionary = dictionary;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Languages that support translate API. </summary>
        public IReadOnlyDictionary<string, TranslationLanguage> Translation { get; }
        /// <summary> Languages that support transliteration API. </summary>
        public IReadOnlyDictionary<string, TransliterationLanguage> Transliteration { get; }
        /// <summary> Languages that support dictionary API. </summary>
        public IReadOnlyDictionary<string, SourceDictionaryLanguage> Dictionary { get; }
    }
}
