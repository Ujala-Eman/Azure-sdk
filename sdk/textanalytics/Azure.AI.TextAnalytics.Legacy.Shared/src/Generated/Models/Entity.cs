// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Legacy
{
    /// <summary> The Entity. </summary>
    internal partial class Entity
    {
        /// <summary> Initializes a new instance of <see cref="Entity"/>. </summary>
        /// <param name="text"> Entity text as appears in the request. </param>
        /// <param name="category"> Entity type. </param>
        /// <param name="offset"> Start position for the entity text. Use of different 'stringIndexType' values can affect the offset returned. </param>
        /// <param name="length"> Length for the entity text. Use of different 'stringIndexType' values can affect the length returned. </param>
        /// <param name="confidenceScore"> Confidence score between 0 and 1 of the extracted entity. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> or <paramref name="category"/> is null. </exception>
        internal Entity(string text, string category, int offset, int length, double confidenceScore)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }
            if (category == null)
            {
                throw new ArgumentNullException(nameof(category));
            }

            Text = text;
            Category = category;
            Offset = offset;
            Length = length;
            ConfidenceScore = confidenceScore;
        }

        /// <summary> Initializes a new instance of <see cref="Entity"/>. </summary>
        /// <param name="text"> Entity text as appears in the request. </param>
        /// <param name="category"> Entity type. </param>
        /// <param name="subcategory"> (Optional) Entity sub type. </param>
        /// <param name="offset"> Start position for the entity text. Use of different 'stringIndexType' values can affect the offset returned. </param>
        /// <param name="length"> Length for the entity text. Use of different 'stringIndexType' values can affect the length returned. </param>
        /// <param name="confidenceScore"> Confidence score between 0 and 1 of the extracted entity. </param>
        internal Entity(string text, string category, string subcategory, int offset, int length, double confidenceScore)
        {
            Text = text;
            Category = category;
            Subcategory = subcategory;
            Offset = offset;
            Length = length;
            ConfidenceScore = confidenceScore;
        }

        /// <summary> Entity text as appears in the request. </summary>
        public string Text { get; }
        /// <summary> Entity type. </summary>
        public string Category { get; }
        /// <summary> (Optional) Entity sub type. </summary>
        public string Subcategory { get; }
        /// <summary> Start position for the entity text. Use of different 'stringIndexType' values can affect the offset returned. </summary>
        public int Offset { get; }
        /// <summary> Length for the entity text. Use of different 'stringIndexType' values can affect the length returned. </summary>
        public int Length { get; }
        /// <summary> Confidence score between 0 and 1 of the extracted entity. </summary>
        public double ConfidenceScore { get; }
    }
}
