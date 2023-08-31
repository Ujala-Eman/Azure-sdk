// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary> Information about the extracted cell in a table. </summary>
    internal partial class DataTableCell
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataTableCell"/>. </summary>
        /// <param name="rowIndex"> Row index of the cell. </param>
        /// <param name="columnIndex"> Column index of the cell. </param>
        /// <param name="text"> Text content of the cell. </param>
        /// <param name="boundingBox"> Bounding box of the cell. </param>
        /// <param name="confidence"> Confidence value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="text"/> or <paramref name="boundingBox"/> is null. </exception>
        internal DataTableCell(int rowIndex, int columnIndex, string text, IEnumerable<float> boundingBox, float confidence)
        {
            Argument.AssertNotNull(text, nameof(text));
            Argument.AssertNotNull(boundingBox, nameof(boundingBox));

            RowIndex = rowIndex;
            ColumnIndex = columnIndex;
            Text = text;
            BoundingBox = boundingBox.ToList();
            Confidence = confidence;
            Elements = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DataTableCell"/>. </summary>
        /// <param name="rowIndex"> Row index of the cell. </param>
        /// <param name="columnIndex"> Column index of the cell. </param>
        /// <param name="rowSpan"> Number of rows spanned by this cell. </param>
        /// <param name="columnSpan"> Number of columns spanned by this cell. </param>
        /// <param name="text"> Text content of the cell. </param>
        /// <param name="boundingBox"> Bounding box of the cell. </param>
        /// <param name="confidence"> Confidence value. </param>
        /// <param name="elements"> When includeTextDetails is set to true, a list of references to the text elements constituting this table cell. </param>
        /// <param name="isHeader"> Is the current cell a header cell?. </param>
        /// <param name="isFooter"> Is the current cell a footer cell?. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataTableCell(int rowIndex, int columnIndex, int? rowSpan, int? columnSpan, string text, IReadOnlyList<float> boundingBox, float confidence, IReadOnlyList<string> elements, bool? isHeader, bool? isFooter, Dictionary<string, BinaryData> rawData)
        {
            RowIndex = rowIndex;
            ColumnIndex = columnIndex;
            RowSpan = rowSpan;
            ColumnSpan = columnSpan;
            Text = text;
            BoundingBox = boundingBox;
            Confidence = confidence;
            Elements = elements;
            IsHeader = isHeader;
            IsFooter = isFooter;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataTableCell"/> for deserialization. </summary>
        internal DataTableCell()
        {
        }

        /// <summary> Row index of the cell. </summary>
        public int RowIndex { get; }
        /// <summary> Column index of the cell. </summary>
        public int ColumnIndex { get; }
        /// <summary> Number of rows spanned by this cell. </summary>
        public int? RowSpan { get; }
        /// <summary> Number of columns spanned by this cell. </summary>
        public int? ColumnSpan { get; }
        /// <summary> Text content of the cell. </summary>
        public string Text { get; }
        /// <summary> Bounding box of the cell. </summary>
        public IReadOnlyList<float> BoundingBox { get; }
        /// <summary> Confidence value. </summary>
        public float Confidence { get; }
        /// <summary> When includeTextDetails is set to true, a list of references to the text elements constituting this table cell. </summary>
        public IReadOnlyList<string> Elements { get; }
        /// <summary> Is the current cell a header cell?. </summary>
        public bool? IsHeader { get; }
        /// <summary> Is the current cell a footer cell?. </summary>
        public bool? IsFooter { get; }
    }
}
