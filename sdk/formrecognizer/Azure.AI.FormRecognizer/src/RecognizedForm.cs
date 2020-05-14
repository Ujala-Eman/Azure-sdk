﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Azure.AI.FormRecognizer.Models
{
    /// <summary>
    /// Represents a form that has been recognized by a trained model.
    /// </summary>
    public class RecognizedForm
    {
        internal RecognizedForm(IReadOnlyList<PageResult_internal> pageResults, IReadOnlyList<ReadResult_internal> readResults, int pageIndex)
        {
            PageResult_internal pageResult = pageResults[pageIndex];

            // Recognized form from a model trained without labels.
            FormType = $"form-{pageResult.ClusterId}";
            PageRange = new FormPageRange(pageResult.Page, pageResult.Page);
            Fields = ConvertUnsupervisedFields(pageResult.Page, pageResult.KeyValuePairs, readResults);
            Pages = ConvertUnsupervisedPages(pageResult, readResults, pageIndex);
        }

        internal RecognizedForm(DocumentResult_internal documentResult, IReadOnlyList<PageResult_internal> pageResults, IReadOnlyList<ReadResult_internal> readResults)
        {
            // Recognized form from a model trained with labels.
            FormType = documentResult.DocType;

            // TODO: validate that PageRange.Length == 2.
            // https://github.com/Azure/azure-sdk-for-net/issues/10547

            PageRange = new FormPageRange(documentResult.PageRange[0], documentResult.PageRange[1]);
            Fields = ConvertSupervisedFields(documentResult.Fields, readResults);
            Pages = ConvertSupervisedPages(pageResults, readResults);
        }

        /// <summary>
        /// The type of form the model identified the submitted form to be.
        /// </summary>
        // Convert clusterId to a string (ex. "FormType1").
        public string FormType { get; }

        /// <summary>
        /// The range of pages this form spans.
        /// </summary>
        public FormPageRange PageRange { get; }

        /// <summary>
        /// A dictionary of the fields recognized from the input document. The key is
        /// the <see cref="FormField.Name"/> of the field. For models trained with labels,
        /// this is the training-time label of the field. For models trained with forms
        /// only, a unique name is generated for each field.
        /// </summary>
        public IReadOnlyDictionary<string, FormField> Fields { get; }

        /// <summary>
        /// A list of pages describing the recognized form content elements present in the input
        /// document.
        /// </summary>
        public IReadOnlyList<FormPage> Pages { get; }

        private static IReadOnlyDictionary<string, FormField> ConvertUnsupervisedFields(int pageNumber, IReadOnlyList<KeyValuePair_internal> keyValuePairs, IReadOnlyList<ReadResult_internal> readResults)
        {
            Dictionary<string, FormField> fieldDictionary = new Dictionary<string, FormField>();

            int i = 0;
            foreach (var keyValuePair in keyValuePairs)
            {
                var fieldName = keyValuePair.Label ?? $"field-{i++}";
                fieldDictionary[fieldName] = new FormField(fieldName, pageNumber, keyValuePair, readResults);
            }

            return fieldDictionary;
        }

        private static IReadOnlyDictionary<string, FormField> ConvertSupervisedFields(IReadOnlyDictionary<string, FieldValue_internal> fields, IReadOnlyList<ReadResult_internal> readResults)
        {
            Dictionary<string, FormField> fieldDictionary = new Dictionary<string, FormField>();

            foreach (var field in fields)
            {
                fieldDictionary[field.Key] = new FormField(field.Key, field.Value, readResults);
            }

            return fieldDictionary;
        }

        private static IReadOnlyList<FormPage> ConvertUnsupervisedPages(PageResult_internal pageResult, IReadOnlyList<ReadResult_internal> readResults, int pageIndex)
            => new List<FormPage> { new FormPage(pageResult, readResults, pageIndex) };

        private IReadOnlyList<FormPage> ConvertSupervisedPages(IReadOnlyList<PageResult_internal> pageResults, IReadOnlyList<ReadResult_internal> readResults)
        {
            List<FormPage> pages = new List<FormPage>();

            for (int i = 0; i < readResults.Count; i++)
            {
                var pageNumber = readResults[i].Page;

                if (pageNumber >= PageRange.FirstPageNumber && pageNumber <= PageRange.LastPageNumber)
                {
                    pages.Add(new FormPage(pageResults != null ? pageResults[i] : null, readResults, i));
                }
            }

            return pages;
        }
    }
}
