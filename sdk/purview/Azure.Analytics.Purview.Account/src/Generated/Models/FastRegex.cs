// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Purview.Account.Models
{
    /// <summary> The FastRegex. </summary>
    public partial class FastRegex
    {
        /// <summary> Initializes a new instance of FastRegex. </summary>
        public FastRegex()
        {
        }

        /// <summary> Initializes a new instance of FastRegex. </summary>
        /// <param name="maxDigits"></param>
        /// <param name="maxLetters"></param>
        /// <param name="minDashes"></param>
        /// <param name="minDigits"></param>
        /// <param name="minDigitsOrLetters"></param>
        /// <param name="minDots"></param>
        /// <param name="minHex"></param>
        /// <param name="minLetters"></param>
        /// <param name="minUnderscores"></param>
        /// <param name="options"></param>
        /// <param name="regexStr"></param>
        internal FastRegex(int? maxDigits, int? maxLetters, int? minDashes, int? minDigits, int? minDigitsOrLetters, int? minDots, int? minHex, int? minLetters, int? minUnderscores, int? options, string regexStr)
        {
            MaxDigits = maxDigits;
            MaxLetters = maxLetters;
            MinDashes = minDashes;
            MinDigits = minDigits;
            MinDigitsOrLetters = minDigitsOrLetters;
            MinDots = minDots;
            MinHex = minHex;
            MinLetters = minLetters;
            MinUnderscores = minUnderscores;
            Options = options;
            RegexStr = regexStr;
        }

        /// <summary> Gets or sets the max digits. </summary>
        public int? MaxDigits { get; set; }
        /// <summary> Gets or sets the max letters. </summary>
        public int? MaxLetters { get; set; }
        /// <summary> Gets or sets the min dashes. </summary>
        public int? MinDashes { get; set; }
        /// <summary> Gets or sets the min digits. </summary>
        public int? MinDigits { get; set; }
        /// <summary> Gets or sets the min digits or letters. </summary>
        public int? MinDigitsOrLetters { get; set; }
        /// <summary> Gets or sets the min dots. </summary>
        public int? MinDots { get; set; }
        /// <summary> Gets or sets the min hex. </summary>
        public int? MinHex { get; set; }
        /// <summary> Gets or sets the min letters. </summary>
        public int? MinLetters { get; set; }
        /// <summary> Gets or sets the min underscores. </summary>
        public int? MinUnderscores { get; set; }
        /// <summary> Gets or sets the options. </summary>
        public int? Options { get; set; }
        /// <summary> Gets or sets the regex str. </summary>
        public string RegexStr { get; set; }
    }
}
