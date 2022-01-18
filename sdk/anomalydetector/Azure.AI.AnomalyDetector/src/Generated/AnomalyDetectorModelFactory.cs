// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.AI.AnomalyDetector.Models
{
    /// <summary> Model factory for read-only models. </summary>
    public static partial class AnomalyDetectorModelFactory
    {
        /// <summary> Initializes a new instance of EntireDetectResponse. </summary>
        /// <param name="period"> Frequency extracted from the series, zero means no recurrent pattern has been found. </param>
        /// <param name="expectedValues"> ExpectedValues contain expected value for each input point. The index of the array is consistent with the input series. </param>
        /// <param name="upperMargins"> UpperMargins contain upper margin of each input point. UpperMargin is used to calculate upperBoundary, which equals to expectedValue + (100 - marginScale)*upperMargin. Anomalies in response can be filtered by upperBoundary and lowerBoundary. By adjusting marginScale value, less significant anomalies can be filtered in client side. The index of the array is consistent with the input series. </param>
        /// <param name="lowerMargins"> LowerMargins contain lower margin of each input point. LowerMargin is used to calculate lowerBoundary, which equals to expectedValue - (100 - marginScale)*lowerMargin. Points between the boundary can be marked as normal ones in client side. The index of the array is consistent with the input series. </param>
        /// <param name="isAnomaly"> IsAnomaly contains anomaly properties for each input point. True means an anomaly either negative or positive has been detected. The index of the array is consistent with the input series. </param>
        /// <param name="isNegativeAnomaly"> IsNegativeAnomaly contains anomaly status in negative direction for each input point. True means a negative anomaly has been detected. A negative anomaly means the point is detected as an anomaly and its real value is smaller than the expected one. The index of the array is consistent with the input series. </param>
        /// <param name="isPositiveAnomaly"> IsPositiveAnomaly contain anomaly status in positive direction for each input point. True means a positive anomaly has been detected. A positive anomaly means the point is detected as an anomaly and its real value is larger than the expected one. The index of the array is consistent with the input series. </param>
        /// <param name="severity"> The severity score for each input point. The larger the value is, the more sever the anomaly is. For normal points, the &quot;severity&quot; is always 0. </param>
        /// <returns> A new <see cref="Models.EntireDetectResponse"/> instance for mocking. </returns>
        public static EntireDetectResponse EntireDetectResponse(int period = default, IEnumerable<float> expectedValues = null, IEnumerable<float> upperMargins = null, IEnumerable<float> lowerMargins = null, IEnumerable<bool> isAnomaly = null, IEnumerable<bool> isNegativeAnomaly = null, IEnumerable<bool> isPositiveAnomaly = null, IEnumerable<float> severity = null)
        {
            expectedValues ??= new List<float>();
            upperMargins ??= new List<float>();
            lowerMargins ??= new List<float>();
            isAnomaly ??= new List<bool>();
            isNegativeAnomaly ??= new List<bool>();
            isPositiveAnomaly ??= new List<bool>();
            severity ??= new List<float>();

            return new EntireDetectResponse(period, expectedValues?.ToList(), upperMargins?.ToList(), lowerMargins?.ToList(), isAnomaly?.ToList(), isNegativeAnomaly?.ToList(), isPositiveAnomaly?.ToList(), severity?.ToList());
        }

        /// <summary> Initializes a new instance of LastDetectResponse. </summary>
        /// <param name="period"> Frequency extracted from the series, zero means no recurrent pattern has been found. </param>
        /// <param name="suggestedWindow"> Suggested input series points needed for detecting the latest point. </param>
        /// <param name="expectedValue"> Expected value of the latest point. </param>
        /// <param name="upperMargin"> Upper margin of the latest point. UpperMargin is used to calculate upperBoundary, which equals to expectedValue + (100 - marginScale)*upperMargin. If the value of latest point is between upperBoundary and lowerBoundary, it should be treated as normal value. By adjusting marginScale value, anomaly status of latest point can be changed. </param>
        /// <param name="lowerMargin"> Lower margin of the latest point. LowerMargin is used to calculate lowerBoundary, which equals to expectedValue - (100 - marginScale)*lowerMargin. </param>
        /// <param name="isAnomaly"> Anomaly status of the latest point, true means the latest point is an anomaly either in negative direction or positive direction. </param>
        /// <param name="isNegativeAnomaly"> Anomaly status in negative direction of the latest point. True means the latest point is an anomaly and its real value is smaller than the expected one. </param>
        /// <param name="isPositiveAnomaly"> Anomaly status in positive direction of the latest point. True means the latest point is an anomaly and its real value is larger than the expected one. </param>
        /// <param name="severity"> The severity score for the last input point. The larger the value is, the more sever the anomaly is. For normal points, the &quot;severity&quot; is always 0. </param>
        /// <returns> A new <see cref="Models.LastDetectResponse"/> instance for mocking. </returns>
        public static LastDetectResponse LastDetectResponse(int period = default, int suggestedWindow = default, float expectedValue = default, float upperMargin = default, float lowerMargin = default, bool isAnomaly = default, bool isNegativeAnomaly = default, bool isPositiveAnomaly = default, float? severity = null)
        {
            return new LastDetectResponse(period, suggestedWindow, expectedValue, upperMargin, lowerMargin, isAnomaly, isNegativeAnomaly, isPositiveAnomaly, severity);
        }

        /// <summary> Initializes a new instance of ChangePointDetectResponse. </summary>
        /// <param name="period"> Frequency extracted from the series, zero means no recurrent pattern has been found. </param>
        /// <param name="isChangePoint"> isChangePoint contains change point properties for each input point. True means an anomaly either negative or positive has been detected. The index of the array is consistent with the input series. </param>
        /// <param name="confidenceScores"> the change point confidence of each point. </param>
        /// <returns> A new <see cref="Models.ChangePointDetectResponse"/> instance for mocking. </returns>
        public static ChangePointDetectResponse ChangePointDetectResponse(int? period = null, IEnumerable<bool> isChangePoint = null, IEnumerable<float> confidenceScores = null)
        {
            isChangePoint ??= new List<bool>();
            confidenceScores ??= new List<float>();

            return new ChangePointDetectResponse(period, isChangePoint?.ToList(), confidenceScores?.ToList());
        }

        /// <summary> Initializes a new instance of ModelInfo. </summary>
        /// <param name="slidingWindow"> An optional field, indicating how many previous points will be used to compute the anomaly score of the subsequent point. </param>
        /// <param name="alignPolicy"></param>
        /// <param name="source"> Source link to the input variables. Each variable should be a csv file with two columns, `timestamp` and `value`. By default, the file name of the variable will be used as its variable name. </param>
        /// <param name="startTime"> A required field, indicating the start time of training data. Should be date-time. </param>
        /// <param name="endTime"> A required field, indicating the end time of training data. Should be date-time. </param>
        /// <param name="displayName"> An optional field. The name of the model whose maximum length is 24. </param>
        /// <param name="status"> Model training status. </param>
        /// <param name="errors"> Error messages when failed to create a model. </param>
        /// <param name="diagnosticsInfo"></param>
        /// <returns> A new <see cref="Models.ModelInfo"/> instance for mocking. </returns>
        public static ModelInfo ModelInfo(int? slidingWindow = null, AlignPolicy alignPolicy = null, string source = null, DateTimeOffset startTime = default, DateTimeOffset endTime = default, string displayName = null, ModelStatus? status = null, IEnumerable<ErrorResponse> errors = null, DiagnosticsInfo diagnosticsInfo = null)
        {
            errors ??= new List<ErrorResponse>();

            return new ModelInfo(slidingWindow, alignPolicy, source, startTime, endTime, displayName, status, errors?.ToList(), diagnosticsInfo);
        }

        /// <summary> Initializes a new instance of ErrorResponse. </summary>
        /// <param name="code"> The error code. </param>
        /// <param name="message"> The message explaining the error reported by the service. </param>
        /// <returns> A new <see cref="Models.ErrorResponse"/> instance for mocking. </returns>
        public static ErrorResponse ErrorResponse(string code = null, string message = null)
        {
            return new ErrorResponse(code, message);
        }

        /// <summary> Initializes a new instance of DiagnosticsInfo. </summary>
        /// <param name="modelState"></param>
        /// <param name="variableStates"></param>
        /// <returns> A new <see cref="Models.DiagnosticsInfo"/> instance for mocking. </returns>
        public static DiagnosticsInfo DiagnosticsInfo(ModelState modelState = null, IEnumerable<VariableState> variableStates = null)
        {
            variableStates ??= new List<VariableState>();

            return new DiagnosticsInfo(modelState, variableStates?.ToList());
        }

        /// <summary> Initializes a new instance of ModelState. </summary>
        /// <param name="epochIds"> Epoch id. </param>
        /// <param name="trainLosses"></param>
        /// <param name="validationLosses"></param>
        /// <param name="latenciesInSeconds"></param>
        /// <returns> A new <see cref="Models.ModelState"/> instance for mocking. </returns>
        public static ModelState ModelState(IEnumerable<int> epochIds = null, IEnumerable<float> trainLosses = null, IEnumerable<float> validationLosses = null, IEnumerable<float> latenciesInSeconds = null)
        {
            epochIds ??= new List<int>();
            trainLosses ??= new List<float>();
            validationLosses ??= new List<float>();
            latenciesInSeconds ??= new List<float>();

            return new ModelState(epochIds?.ToList(), trainLosses?.ToList(), validationLosses?.ToList(), latenciesInSeconds?.ToList());
        }

        /// <summary> Initializes a new instance of VariableState. </summary>
        /// <param name="variable"> Variable name. </param>
        /// <param name="filledNARatio"> Proportion of NaN values filled of the variable. </param>
        /// <param name="effectiveCount"> Number of effective points counted. </param>
        /// <param name="startTime"> Start time of the variable. </param>
        /// <param name="endTime"> End time of the variable. </param>
        /// <returns> A new <see cref="Models.VariableState"/> instance for mocking. </returns>
        public static VariableState VariableState(string variable = null, float? filledNARatio = null, int? effectiveCount = null, DateTimeOffset? startTime = null, DateTimeOffset? endTime = null)
        {
            return new VariableState(variable, filledNARatio, effectiveCount, startTime, endTime);
        }

        /// <summary> Initializes a new instance of ModelSnapshot. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="createdTime"> Date and time (UTC) when the model was created. </param>
        /// <param name="lastUpdatedTime"> Date and time (UTC) when the model was last updated. </param>
        /// <param name="status"> Model training status. </param>
        /// <param name="displayName"></param>
        /// <param name="variablesCount"> Total number of variables. </param>
        /// <returns> A new <see cref="Models.ModelSnapshot"/> instance for mocking. </returns>
        public static ModelSnapshot ModelSnapshot(Guid modelId = default, DateTimeOffset createdTime = default, DateTimeOffset lastUpdatedTime = default, ModelStatus status = default, string displayName = null, int variablesCount = default)
        {
            return new ModelSnapshot(modelId, createdTime, lastUpdatedTime, status, displayName, variablesCount);
        }

        /// <summary> Initializes a new instance of Model. </summary>
        /// <param name="modelId"> Model identifier. </param>
        /// <param name="createdTime"> Date and time (UTC) when the model was created. </param>
        /// <param name="lastUpdatedTime"> Date and time (UTC) when the model was last updated. </param>
        /// <param name="modelInfo"> Train result of a model including status, errors and diagnose info for model and variables. </param>
        /// <returns> A new <see cref="Models.Model"/> instance for mocking. </returns>
        public static Model Model(Guid modelId = default, DateTimeOffset createdTime = default, DateTimeOffset lastUpdatedTime = default, ModelInfo modelInfo = null)
        {
            return new Model(modelId, createdTime, lastUpdatedTime, modelInfo);
        }

        /// <summary> Initializes a new instance of DetectionResult. </summary>
        /// <param name="resultId"></param>
        /// <param name="summary"></param>
        /// <param name="results"> Detection result for each timestamp. </param>
        /// <returns> A new <see cref="Models.DetectionResult"/> instance for mocking. </returns>
        public static DetectionResult DetectionResult(Guid resultId = default, DetectionResultSummary summary = null, IEnumerable<AnomalyState> results = null)
        {
            results ??= new List<AnomalyState>();

            return new DetectionResult(resultId, summary, results?.ToList());
        }

        /// <summary> Initializes a new instance of DetectionResultSummary. </summary>
        /// <param name="status"> Status of detection results. One of CREATED, RUNNING, READY, and FAILED. </param>
        /// <param name="errors"> Error message when detection is failed. </param>
        /// <param name="variableStates"></param>
        /// <param name="setupInfo"> Detection request. </param>
        /// <returns> A new <see cref="Models.DetectionResultSummary"/> instance for mocking. </returns>
        public static DetectionResultSummary DetectionResultSummary(DetectionStatus status = default, IEnumerable<ErrorResponse> errors = null, IEnumerable<VariableState> variableStates = null, DetectionRequest setupInfo = null)
        {
            errors ??= new List<ErrorResponse>();
            variableStates ??= new List<VariableState>();

            return new DetectionResultSummary(status, errors?.ToList(), variableStates?.ToList(), setupInfo);
        }

        /// <summary> Initializes a new instance of AnomalyState. </summary>
        /// <param name="timestamp"> timestamp. </param>
        /// <param name="value"></param>
        /// <param name="errors"> Error message for the current timestamp. </param>
        /// <returns> A new <see cref="Models.AnomalyState"/> instance for mocking. </returns>
        public static AnomalyState AnomalyState(DateTimeOffset timestamp = default, AnomalyValue value = null, IEnumerable<ErrorResponse> errors = null)
        {
            errors ??= new List<ErrorResponse>();

            return new AnomalyState(timestamp, value, errors?.ToList());
        }

        /// <summary> Initializes a new instance of AnomalyValue. </summary>
        /// <param name="isAnomaly"> True if an anomaly is detected at the current timestamp. </param>
        /// <param name="severity"> Indicates the significance of the anomaly. The higher the severity, the more significant the anomaly. </param>
        /// <param name="score"> Raw score from the model. </param>
        /// <param name="interpretation"></param>
        /// <returns> A new <see cref="Models.AnomalyValue"/> instance for mocking. </returns>
        public static AnomalyValue AnomalyValue(bool isAnomaly = default, float severity = default, float score = default, IEnumerable<AnomalyInterpretation> interpretation = null)
        {
            interpretation ??= new List<AnomalyInterpretation>();

            return new AnomalyValue(isAnomaly, severity, score, interpretation?.ToList());
        }

        /// <summary> Initializes a new instance of AnomalyInterpretation. </summary>
        /// <param name="variable"></param>
        /// <param name="contributionScore"></param>
        /// <param name="correlationChanges"></param>
        /// <returns> A new <see cref="Models.AnomalyInterpretation"/> instance for mocking. </returns>
        public static AnomalyInterpretation AnomalyInterpretation(string variable = null, float? contributionScore = null, CorrelationChanges correlationChanges = null)
        {
            return new AnomalyInterpretation(variable, contributionScore, correlationChanges);
        }

        /// <summary> Initializes a new instance of CorrelationChanges. </summary>
        /// <param name="changedVariables"> correlated variables. </param>
        /// <param name="changedValues"> changes in correlation. </param>
        /// <returns> A new <see cref="Models.CorrelationChanges"/> instance for mocking. </returns>
        public static CorrelationChanges CorrelationChanges(IEnumerable<string> changedVariables = null, IEnumerable<float> changedValues = null)
        {
            changedVariables ??= new List<string>();
            changedValues ??= new List<float>();

            return new CorrelationChanges(changedVariables?.ToList(), changedValues?.ToList());
        }

        /// <summary> Initializes a new instance of LastDetectionResult. </summary>
        /// <param name="variableStates"></param>
        /// <param name="results"></param>
        /// <returns> A new <see cref="Models.LastDetectionResult"/> instance for mocking. </returns>
        public static LastDetectionResult LastDetectionResult(IEnumerable<VariableState> variableStates = null, IEnumerable<AnomalyState> results = null)
        {
            variableStates ??= new List<VariableState>();
            results ??= new List<AnomalyState>();

            return new LastDetectionResult(variableStates?.ToList(), results?.ToList());
        }
    }
}
