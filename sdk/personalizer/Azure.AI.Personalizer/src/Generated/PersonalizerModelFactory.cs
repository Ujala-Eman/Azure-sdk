// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.Personalizer.Models
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class PersonalizerModelFactory
    {
        /// <summary> Initializes a new instance of PersonalizerEvaluation. </summary>
        /// <param name="id"> The ID of the evaluation. </param>
        /// <param name="name"> The name of the evaluation. </param>
        /// <param name="startTime"> The start time of the evaluation. </param>
        /// <param name="endTime"> The end time of the evaluation. </param>
        /// <param name="jobId"> The ID of the job processing the evaluation. </param>
        /// <param name="status"> The status of the job processing the evaluation. </param>
        /// <param name="policyResults"> The results of the evaluation. </param>
        /// <param name="featureImportance"> Feature Importance. </param>
        /// <param name="evaluationType"> Evaluation type (manual or through Automatic Optimization). </param>
        /// <param name="optimalPolicy"> Thr optimal policy. </param>
        /// <param name="creationTime"> Creation time. </param>
        /// <returns> A new <see cref="Models.PersonalizerEvaluation"/> instance for mocking. </returns>
        public static PersonalizerEvaluation PersonalizerEvaluation(string id = null, string name = null, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null, string jobId = null, EvaluationJobStatus? status = null, IEnumerable<PersonalizerPolicyResult> policyResults = null, IEnumerable<IList<string>> featureImportance = null, EvaluationType? evaluationType = null, string optimalPolicy = null, DateTimeOffset? creationTime = null)
        {
            policyResults ??= new List<PersonalizerPolicyResult>();
            featureImportance ??= new List<IList<string>>();

            return new PersonalizerEvaluation(id, name, startTime, endTime, jobId, status, policyResults?.ToList(), featureImportance?.ToList(), evaluationType, optimalPolicy, creationTime);
        }

        /// <summary> Initializes a new instance of PersonalizerPolicyResult. </summary>
        /// <param name="name"> The name of the Learning Settings. </param>
        /// <param name="arguments"> The arguments of the Learning Settings. </param>
        /// <param name="policySource"> The source of the Learning Settings. </param>
        /// <param name="summary"> The aggregate results of the Offline Evaluation. </param>
        /// <param name="totalSummary"> The aggregate total of the Offline Evaluation. </param>
        /// <returns> A new <see cref="Models.PersonalizerPolicyResult"/> instance for mocking. </returns>
        public static PersonalizerPolicyResult PersonalizerPolicyResult(string name = null, string arguments = null, PersonalizerPolicySource? policySource = null, IEnumerable<PersonalizerPolicyResultSummary> summary = null, PersonalizerPolicyResultTotalSummary totalSummary = null)
        {
            summary ??= new List<PersonalizerPolicyResultSummary>();

            return new PersonalizerPolicyResult(name, arguments, policySource, summary?.ToList(), totalSummary);
        }

        /// <summary> Initializes a new instance of PersonalizerPolicyResultSummary. </summary>
        /// <param name="timeStamp"> Timestamp of the aggregation. </param>
        /// <param name="ipsEstimatorNumerator"> Numerator for IPS estimator. </param>
        /// <param name="ipsEstimatorDenominator"> Denominator for IPS estimator. </param>
        /// <param name="snipsEstimatorDenominator"> Denominator for SNIPS estimator. </param>
        /// <param name="aggregateTimeWindow">
        /// Time window for aggregation.
        /// For example, PT5M (5 mins). For information about the time format,
        /// see http://en.wikipedia.org/wiki/ISO_8601#Durations
        /// </param>
        /// <param name="nonZeroProbability"> Probability of non-zero values for the Policy evaluation. </param>
        /// <param name="sumOfSquares"> Sum of Squares for the Policy evaluation results. </param>
        /// <param name="confidenceInterval"> Gaussian confidence interval for the Policy evaluation. </param>
        /// <param name="averageReward"> Average reward. </param>
        /// <returns> A new <see cref="Models.PersonalizerPolicyResultSummary"/> instance for mocking. </returns>
        public static PersonalizerPolicyResultSummary PersonalizerPolicyResultSummary(DateTimeOffset? timeStamp = null, float? ipsEstimatorNumerator = null, float? ipsEstimatorDenominator = null, float? snipsEstimatorDenominator = null, TimeSpan? aggregateTimeWindow = null, float? nonZeroProbability = null, float? sumOfSquares = null, float? confidenceInterval = null, float? averageReward = null)
        {
            return new PersonalizerPolicyResultSummary(timeStamp, ipsEstimatorNumerator, ipsEstimatorDenominator, snipsEstimatorDenominator, aggregateTimeWindow, nonZeroProbability, sumOfSquares, confidenceInterval, averageReward);
        }

        /// <summary> Initializes a new instance of PersonalizerLogProperties. </summary>
        /// <param name="dateRange"> Date range. </param>
        /// <returns> A new <see cref="Models.PersonalizerLogProperties"/> instance for mocking. </returns>
        public static PersonalizerLogProperties PersonalizerLogProperties(LogsPropertiesDateRange dateRange = null)
        {
            return new PersonalizerLogProperties(dateRange);
        }

        /// <summary> Initializes a new instance of DateRange. </summary>
        /// <param name="from"> Start date for the range. </param>
        /// <param name="to"> End date for the range. </param>
        /// <returns> A new <see cref="Models.DateRange"/> instance for mocking. </returns>
        public static DateRange DateRange(DateTimeOffset? @from = null, DateTimeOffset? to = null)
        {
            return new DateRange(@from, to);
        }

        /// <summary> Initializes a new instance of PersonalizerModelProperties. </summary>
        /// <param name="creationTime"> Creation time of the model. </param>
        /// <param name="lastModifiedTime"> Last time the model was modified. </param>
        /// <returns> A new <see cref="Models.PersonalizerModelProperties"/> instance for mocking. </returns>
        public static PersonalizerModelProperties PersonalizerModelProperties(DateTimeOffset? creationTime = null, DateTimeOffset? lastModifiedTime = null)
        {
            return new PersonalizerModelProperties(creationTime, lastModifiedTime);
        }

        /// <summary> Initializes a new instance of PersonalizerMultiSlotRankResult. </summary>
        /// <param name="slots"> Each slot has a corresponding rewardActionID which is the action ID recommended by Personalizer. </param>
        /// <param name="eventId"> The eventId for the round trip from request to response. </param>
        /// <returns> A new <see cref="Models.PersonalizerMultiSlotRankResult"/> instance for mocking. </returns>
        public static PersonalizerMultiSlotRankResult PersonalizerMultiSlotRankResult(IEnumerable<PersonalizerSlotResult> slots = null, string eventId = null)
        {
            slots ??= new List<PersonalizerSlotResult>();

            return new PersonalizerMultiSlotRankResult(slots?.ToList(), eventId);
        }

        /// <summary> Initializes a new instance of PersonalizerSlotResult. </summary>
        /// <param name="id"> Id is the slot ID. </param>
        /// <param name="rewardActionId"> RewardActionID is the action ID recommended by Personalizer. </param>
        /// <returns> A new <see cref="Models.PersonalizerSlotResult"/> instance for mocking. </returns>
        public static PersonalizerSlotResult PersonalizerSlotResult(string id = null, string rewardActionId = null)
        {
            return new PersonalizerSlotResult(id, rewardActionId);
        }

        /// <summary> Initializes a new instance of PersonalizerRankResult. </summary>
        /// <param name="ranking"> The calculated ranking for the current request. </param>
        /// <param name="eventId"> The eventId for the round trip from request to response. </param>
        /// <param name="rewardActionId">
        /// The action chosen by the Personalizer service.
        /// This is the action your application should display, and for which to report the reward.
        /// This might not be the first found in &apos;ranking&apos;.
        /// </param>
        /// <returns> A new <see cref="Models.PersonalizerRankResult"/> instance for mocking. </returns>
        public static PersonalizerRankResult PersonalizerRankResult(IEnumerable<PersonalizerRankedAction> ranking = null, string eventId = null, string rewardActionId = null)
        {
            ranking ??= new List<PersonalizerRankedAction>();

            return new PersonalizerRankResult(ranking?.ToList(), eventId, rewardActionId);
        }

        /// <summary> Initializes a new instance of PersonalizerRankedAction. </summary>
        /// <param name="id"> Id of the action. </param>
        /// <param name="probability"> Probability of the action. </param>
        /// <returns> A new <see cref="Models.PersonalizerRankedAction"/> instance for mocking. </returns>
        public static PersonalizerRankedAction PersonalizerRankedAction(string id = null, float? probability = null)
        {
            return new PersonalizerRankedAction(id, probability);
        }
    }
}
