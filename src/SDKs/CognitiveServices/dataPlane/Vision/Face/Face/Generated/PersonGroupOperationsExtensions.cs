// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.Face
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PersonGroupOperations.
    /// </summary>
    public static partial class PersonGroupOperationsExtensions
    {
            /// <summary>
            /// Create a new person group with specified personGroupId, name, user-provided
            /// userData and recognitionModel.
            /// &lt;br /&gt; A person group is the container of the uploaded person data,
            /// including face images and face recognition features.
            /// &lt;br /&gt; After creation, use [PersonGroup Person -
            /// Create](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f3039523c)
            /// to add persons into the group, and then call [PersonGroup -
            /// Train](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395249)
            /// to get this group ready for [Face -
            /// Identify](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395239).
            /// &lt;br /&gt; The person's face, image, and userData will be stored on
            /// server until [PersonGroup Person -
            /// Delete](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f3039523d)
            /// or [PersonGroup -
            /// Delete](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395245)
            /// is called.
            /// &lt;br /&gt;
            /// * Free-tier subscription quota: 1,000 person groups. Each holds up to 1,000
            /// persons.
            /// * S0-tier subscription quota: 1,000,000 person groups. Each holds up to
            /// 10,000 persons.
            /// * to handle larger scale face identification problem, please consider using
            /// [LargePersonGroup](/docs/services/563879b61984550e40cbbe8d/operations/599acdee6ac60f11b48b5a9d).
            /// &lt;br /&gt;
            /// 'recognitionModel' should be specified to associate with this person group.
            /// The default value for 'recognitionModel' is 'recognition_01', if the latest
            /// model needed, please explicitly specify the model you need in this
            /// parameter. New faces that are added to an existing person group will use
            /// the recognition model that's already associated with the collection.
            /// Existing face features in a person group can't be updated to features
            /// extracted by another version of recognition model.
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='personGroupId'>
            /// Id referencing a particular person group.
            /// </param>
            /// <param name='name'>
            /// User defined name, maximum length is 128.
            /// </param>
            /// <param name='userData'>
            /// User specified data. Length should not exceed 16KB.
            /// </param>
            /// <param name='recognitionModel'>
            /// Possible values include: 'recognition_01', 'recognition_02'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CreateAsync(this IPersonGroupOperations operations, string personGroupId, string name = default(string), string userData = default(string), string recognitionModel = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.CreateWithHttpMessagesAsync(personGroupId, name, userData, recognitionModel, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Delete an existing person group. Persisted face features of all people in
            /// the person group will also be deleted.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='personGroupId'>
            /// Id referencing a particular person group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPersonGroupOperations operations, string personGroupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(personGroupId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieve person group name, userData and recognitionModel. To get person
            /// information under this personGroup, use [PersonGroup Person -
            /// List](/docs/services/563879b61984550e40cbbe8d/operations/563879b61984550f30395241).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='personGroupId'>
            /// Id referencing a particular person group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PersonGroup> GetAsync(this IPersonGroupOperations operations, string personGroupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(personGroupId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update an existing person group's display name and userData. The properties
            /// which does not appear in request body will not be updated.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='personGroupId'>
            /// Id referencing a particular person group.
            /// </param>
            /// <param name='name'>
            /// User defined name, maximum length is 128.
            /// </param>
            /// <param name='userData'>
            /// User specified data. Length should not exceed 16KB.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task UpdateAsync(this IPersonGroupOperations operations, string personGroupId, string name = default(string), string userData = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.UpdateWithHttpMessagesAsync(personGroupId, name, userData, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieve the training status of a person group (completed or ongoing).
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='personGroupId'>
            /// Id referencing a particular person group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TrainingStatus> GetTrainingStatusAsync(this IPersonGroupOperations operations, string personGroupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetTrainingStatusWithHttpMessagesAsync(personGroupId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List person groups’s personGroupId, name, userData and
            /// recognitionModel.&lt;br /&gt;
            /// * Person groups are stored in alphabetical order of personGroupId.
            /// * "start" parameter (string, optional) is a user-provided personGroupId
            /// value that returned entries have larger ids by string comparison. "start"
            /// set to empty to indicate return from the first item.
            /// * "top" parameter (int, optional) specifies the number of entries to
            /// return. A maximal of 1000 entries can be returned in one call. To fetch
            /// more, you can specify "start" with the last retuned entry’s Id of the
            /// current call.
            /// &lt;br /&gt;
            /// For example, total 5 person groups: "group1", ..., "group5".
            /// &lt;br /&gt; "start=&amp;top=" will return all 5 groups.
            /// &lt;br /&gt; "start=&amp;top=2" will return "group1", "group2".
            /// &lt;br /&gt; "start=group2&amp;top=3" will return "group3", "group4",
            /// "group5".
            ///
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='start'>
            /// List person groups from the least personGroupId greater than the "start".
            /// </param>
            /// <param name='top'>
            /// The number of person groups to list.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<PersonGroup>> ListAsync(this IPersonGroupOperations operations, string start = default(string), int? top = 1000, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(start, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Queue a person group training task, the training task may not be started
            /// immediately.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='personGroupId'>
            /// Id referencing a particular person group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task TrainAsync(this IPersonGroupOperations operations, string personGroupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.TrainWithHttpMessagesAsync(personGroupId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
