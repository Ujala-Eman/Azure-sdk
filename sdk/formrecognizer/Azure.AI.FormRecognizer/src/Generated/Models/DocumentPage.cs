// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> Content and layout elements extracted from a page from the input. </summary>
    public partial class DocumentPage
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DocumentPage"/>. </summary>
        /// <param name="pageNumber"> 1-based page number in the input document. </param>
        /// <param name="spans"> Location of the page in the reading order concatenated content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="spans"/> is null. </exception>
        internal DocumentPage(int pageNumber, IEnumerable<DocumentSpan> spans)
        {
            Argument.AssertNotNull(spans, nameof(spans));

            PageNumber = pageNumber;
            Spans = spans.ToList();
            Words = new ChangeTrackingList<DocumentWord>();
            SelectionMarks = new ChangeTrackingList<DocumentSelectionMark>();
            Lines = new ChangeTrackingList<DocumentLine>();
            Barcodes = new ChangeTrackingList<DocumentBarcode>();
            Formulas = new ChangeTrackingList<DocumentFormula>();
        }

        /// <summary> Initializes a new instance of <see cref="DocumentPage"/>. </summary>
        /// <param name="pageNumber"> 1-based page number in the input document. </param>
        /// <param name="angle"> The general orientation of the content in clockwise direction, measured in degrees between (-180, 180]. </param>
        /// <param name="width"> The width of the image/PDF in pixels/inches, respectively. </param>
        /// <param name="height"> The height of the image/PDF in pixels/inches, respectively. </param>
        /// <param name="unitPrivate"> The unit used by the width, height, and polygon properties. For images, the unit is "pixel". For PDF, the unit is "inch". </param>
        /// <param name="spans"> Location of the page in the reading order concatenated content. </param>
        /// <param name="words"> Extracted words from the page. </param>
        /// <param name="selectionMarks"> Extracted selection marks from the page. </param>
        /// <param name="lines"> Extracted lines from the page, potentially containing both textual and visual elements. </param>
        /// <param name="barcodes"> Extracted barcodes from the page. </param>
        /// <param name="formulas"> Extracted formulas from the page. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DocumentPage(int pageNumber, float? angle, float? width, float? height, V3LengthUnit? unitPrivate, IReadOnlyList<DocumentSpan> spans, IReadOnlyList<DocumentWord> words, IReadOnlyList<DocumentSelectionMark> selectionMarks, IReadOnlyList<DocumentLine> lines, IReadOnlyList<DocumentBarcode> barcodes, IReadOnlyList<DocumentFormula> formulas, Dictionary<string, BinaryData> rawData)
        {
            PageNumber = pageNumber;
            Angle = angle;
            Width = width;
            Height = height;
            UnitPrivate = unitPrivate;
            Spans = spans;
            Words = words;
            SelectionMarks = selectionMarks;
            Lines = lines;
            Barcodes = barcodes;
            Formulas = formulas;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DocumentPage"/> for deserialization. </summary>
        internal DocumentPage()
        {
        }

        /// <summary> 1-based page number in the input document. </summary>
        public int PageNumber { get; }
        /// <summary> The general orientation of the content in clockwise direction, measured in degrees between (-180, 180]. </summary>
        public float? Angle { get; }
        /// <summary> The width of the image/PDF in pixels/inches, respectively. </summary>
        public float? Width { get; }
        /// <summary> The height of the image/PDF in pixels/inches, respectively. </summary>
        public float? Height { get; }
        /// <summary> Location of the page in the reading order concatenated content. </summary>
        public IReadOnlyList<DocumentSpan> Spans { get; }
        /// <summary> Extracted words from the page. </summary>
        public IReadOnlyList<DocumentWord> Words { get; }
        /// <summary> Extracted selection marks from the page. </summary>
        public IReadOnlyList<DocumentSelectionMark> SelectionMarks { get; }
        /// <summary> Extracted lines from the page, potentially containing both textual and visual elements. </summary>
        public IReadOnlyList<DocumentLine> Lines { get; }
        /// <summary> Extracted barcodes from the page. </summary>
        public IReadOnlyList<DocumentBarcode> Barcodes { get; }
        /// <summary> Extracted formulas from the page. </summary>
        public IReadOnlyList<DocumentFormula> Formulas { get; }
    }
}
