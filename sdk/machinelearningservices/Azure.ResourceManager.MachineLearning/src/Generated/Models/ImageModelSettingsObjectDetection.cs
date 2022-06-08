// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Settings used for training the model.
    /// For more information on the available settings please visit the official documentation:
    /// https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
    /// </summary>
    public partial class ImageModelSettingsObjectDetection : ImageModelSettings
    {
        /// <summary> Initializes a new instance of <see cref="ImageModelSettingsObjectDetection"/>. </summary>
        public ImageModelSettingsObjectDetection()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ImageModelSettingsObjectDetection"/>. </summary>
        /// <param name="advancedSettings"> Settings for advanced scenarios. </param>
        /// <param name="amsGradient"> Enable AMSGrad when optimizer is &apos;adam&apos; or &apos;adamw&apos;. </param>
        /// <param name="augmentations"> Settings for using Augmentations. </param>
        /// <param name="beta1"> Value of &apos;beta1&apos; when optimizer is &apos;adam&apos; or &apos;adamw&apos;. Must be a float in the range [0, 1]. </param>
        /// <param name="beta2"> Value of &apos;beta2&apos; when optimizer is &apos;adam&apos; or &apos;adamw&apos;. Must be a float in the range [0, 1]. </param>
        /// <param name="checkpointDatasetId">
        /// FileDataset id for pretrained checkpoint(s) for incremental training.
        /// Make sure to pass CheckpointFilename along with CheckpointDatasetId.
        /// </param>
        /// <param name="checkpointFilename">
        /// The pretrained checkpoint filename in FileDataset for incremental training.
        /// Make sure to pass CheckpointDatasetId along with CheckpointFilename.
        /// </param>
        /// <param name="checkpointFrequency"> Frequency to store model checkpoints. Must be a positive integer. </param>
        /// <param name="checkpointRunId"> The id of a previous run that has a pretrained checkpoint for incremental training. </param>
        /// <param name="distributed"> Whether to use distributed training. </param>
        /// <param name="earlyStopping"> Enable early stopping logic during training. </param>
        /// <param name="earlyStoppingDelay">
        /// Minimum number of epochs or validation evaluations to wait before primary metric improvement
        /// is tracked for early stopping. Must be a positive integer.
        /// </param>
        /// <param name="earlyStoppingPatience">
        /// Minimum number of epochs or validation evaluations with no primary metric improvement before
        /// the run is stopped. Must be a positive integer.
        /// </param>
        /// <param name="enableOnnxNormalization"> Enable normalization when exporting ONNX model. </param>
        /// <param name="evaluationFrequency"> Frequency to evaluate validation dataset to get metric scores. Must be a positive integer. </param>
        /// <param name="gradientAccumulationStep">
        /// Gradient accumulation means running a configured number of &quot;GradAccumulationStep&quot; steps without
        /// updating the model weights while accumulating the gradients of those steps, and then using
        /// the accumulated gradients to compute the weight updates. Must be a positive integer.
        /// </param>
        /// <param name="layersToFreeze">
        /// Number of layers to freeze for the model. Must be a positive integer.
        /// For instance, passing 2 as value for &apos;seresnext&apos; means
        /// freezing layer0 and layer1. For a full list of models supported and details on layer freeze, please
        /// see: https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
        /// </param>
        /// <param name="learningRate"> Initial learning rate. Must be a float in the range [0, 1]. </param>
        /// <param name="learningRateScheduler"> Type of learning rate scheduler. Must be &apos;warmup_cosine&apos; or &apos;step&apos;. </param>
        /// <param name="modelName">
        /// Name of the model to use for training.
        /// For more information on the available models please visit the official documentation:
        /// https://docs.microsoft.com/en-us/azure/machine-learning/how-to-auto-train-image-models.
        /// </param>
        /// <param name="momentum"> Value of momentum when optimizer is &apos;sgd&apos;. Must be a float in the range [0, 1]. </param>
        /// <param name="nesterov"> Enable nesterov when optimizer is &apos;sgd&apos;. </param>
        /// <param name="numberOfEpochs"> Number of training epochs. Must be a positive integer. </param>
        /// <param name="numberOfWorkers"> Number of data loader workers. Must be a non-negative integer. </param>
        /// <param name="optimizer"> Type of optimizer. </param>
        /// <param name="randomSeed"> Random seed to be used when using deterministic training. </param>
        /// <param name="splitRatio">
        /// If validation data is not defined, this specifies the split ratio for splitting
        /// train data into random train and validation subsets. Must be a float in the range [0, 1].
        /// </param>
        /// <param name="stepLRGamma"> Value of gamma when learning rate scheduler is &apos;step&apos;. Must be a float in the range [0, 1]. </param>
        /// <param name="stepLRStepSize"> Value of step size when learning rate scheduler is &apos;step&apos;. Must be a positive integer. </param>
        /// <param name="trainingBatchSize"> Training batch size. Must be a positive integer. </param>
        /// <param name="validationBatchSize"> Validation batch size. Must be a positive integer. </param>
        /// <param name="warmupCosineLRCycles"> Value of cosine cycle when learning rate scheduler is &apos;warmup_cosine&apos;. Must be a float in the range [0, 1]. </param>
        /// <param name="warmupCosineLRWarmupEpochs"> Value of warmup epochs when learning rate scheduler is &apos;warmup_cosine&apos;. Must be a positive integer. </param>
        /// <param name="weightDecay"> Value of weight decay when optimizer is &apos;sgd&apos;, &apos;adam&apos;, or &apos;adamw&apos;. Must be a float in the range[0, 1]. </param>
        /// <param name="boxDetectionsPerImage">
        /// Maximum number of detections per image, for all classes. Must be a positive integer.
        /// Note: This settings is not supported for the &apos;yolov5&apos; algorithm.
        /// </param>
        /// <param name="boxScoreThreshold">
        /// During inference, only return proposals with a classification score greater than
        /// BoxScoreThreshold. Must be a float in the range[0, 1].
        /// </param>
        /// <param name="imageSize">
        /// Image size for train and validation. Must be a positive integer.
        /// Note: The training run may get into CUDA OOM if the size is too big.
        /// Note: This settings is only supported for the &apos;yolov5&apos; algorithm.
        /// </param>
        /// <param name="maxSize">
        /// Maximum size of the image to be rescaled before feeding it to the backbone.
        /// Must be a positive integer. Note: training run may get into CUDA OOM if the size is too big.
        /// Note: This settings is not supported for the &apos;yolov5&apos; algorithm.
        /// </param>
        /// <param name="minSize">
        /// Minimum size of the image to be rescaled before feeding it to the backbone.
        /// Must be a positive integer. Note: training run may get into CUDA OOM if the size is too big.
        /// Note: This settings is not supported for the &apos;yolov5&apos; algorithm.
        /// </param>
        /// <param name="modelSize">
        /// Model size. Must be &apos;small&apos;, &apos;medium&apos;, &apos;large&apos;, or &apos;xlarge&apos;.
        /// Note: training run may get into CUDA OOM if the model size is too big.
        /// Note: This settings is only supported for the &apos;yolov5&apos; algorithm.
        /// </param>
        /// <param name="multiScale">
        /// Enable multi-scale image by varying image size by +/- 50%.
        /// Note: training run may get into CUDA OOM if no sufficient GPU memory.
        /// Note: This settings is only supported for the &apos;yolov5&apos; algorithm.
        /// </param>
        /// <param name="nmsIouThreshold"> IOU threshold used during inference in NMS post processing. Must be a float in the range [0, 1]. </param>
        /// <param name="tileGridSize">
        /// The grid size to use for tiling each image. Note: TileGridSize must not be
        /// None to enable small object detection logic. A string containing two integers in mxn format.
        /// Note: This settings is not supported for the &apos;yolov5&apos; algorithm.
        /// </param>
        /// <param name="tileOverlapRatio">
        /// Overlap ratio between adjacent tiles in each dimension. Must be float in the range [0, 1).
        /// Note: This settings is not supported for the &apos;yolov5&apos; algorithm.
        /// </param>
        /// <param name="tilePredictionsNmsThreshold">
        /// The IOU threshold to use to perform NMS while merging predictions from tiles and image.
        /// Used in validation/ inference. Must be float in the range [0, 1].
        /// Note: This settings is not supported for the &apos;yolov5&apos; algorithm.
        /// </param>
        /// <param name="validationIouThreshold"> IOU threshold to use when computing validation metric. Must be float in the range [0, 1]. </param>
        /// <param name="validationMetricType"> Metric computation method to use for validation metrics. </param>
        internal ImageModelSettingsObjectDetection(string advancedSettings, bool? amsGradient, string augmentations, float? beta1, float? beta2, string checkpointDatasetId, string checkpointFilename, int? checkpointFrequency, string checkpointRunId, bool? distributed, bool? earlyStopping, int? earlyStoppingDelay, int? earlyStoppingPatience, bool? enableOnnxNormalization, int? evaluationFrequency, int? gradientAccumulationStep, int? layersToFreeze, float? learningRate, LearningRateScheduler? learningRateScheduler, string modelName, float? momentum, bool? nesterov, int? numberOfEpochs, int? numberOfWorkers, StochasticOptimizer? optimizer, int? randomSeed, float? splitRatio, float? stepLRGamma, int? stepLRStepSize, int? trainingBatchSize, int? validationBatchSize, float? warmupCosineLRCycles, int? warmupCosineLRWarmupEpochs, float? weightDecay, int? boxDetectionsPerImage, float? boxScoreThreshold, int? imageSize, int? maxSize, int? minSize, ModelSize? modelSize, bool? multiScale, float? nmsIouThreshold, string tileGridSize, float? tileOverlapRatio, float? tilePredictionsNmsThreshold, float? validationIouThreshold, ValidationMetricType? validationMetricType) : base(advancedSettings, amsGradient, augmentations, beta1, beta2, checkpointDatasetId, checkpointFilename, checkpointFrequency, checkpointRunId, distributed, earlyStopping, earlyStoppingDelay, earlyStoppingPatience, enableOnnxNormalization, evaluationFrequency, gradientAccumulationStep, layersToFreeze, learningRate, learningRateScheduler, modelName, momentum, nesterov, numberOfEpochs, numberOfWorkers, optimizer, randomSeed, splitRatio, stepLRGamma, stepLRStepSize, trainingBatchSize, validationBatchSize, warmupCosineLRCycles, warmupCosineLRWarmupEpochs, weightDecay)
        {
            BoxDetectionsPerImage = boxDetectionsPerImage;
            BoxScoreThreshold = boxScoreThreshold;
            ImageSize = imageSize;
            MaxSize = maxSize;
            MinSize = minSize;
            ModelSize = modelSize;
            MultiScale = multiScale;
            NmsIouThreshold = nmsIouThreshold;
            TileGridSize = tileGridSize;
            TileOverlapRatio = tileOverlapRatio;
            TilePredictionsNmsThreshold = tilePredictionsNmsThreshold;
            ValidationIouThreshold = validationIouThreshold;
            ValidationMetricType = validationMetricType;
        }

        /// <summary>
        /// Maximum number of detections per image, for all classes. Must be a positive integer.
        /// Note: This settings is not supported for the &apos;yolov5&apos; algorithm.
        /// </summary>
        public int? BoxDetectionsPerImage { get; set; }
        /// <summary>
        /// During inference, only return proposals with a classification score greater than
        /// BoxScoreThreshold. Must be a float in the range[0, 1].
        /// </summary>
        public float? BoxScoreThreshold { get; set; }
        /// <summary>
        /// Image size for train and validation. Must be a positive integer.
        /// Note: The training run may get into CUDA OOM if the size is too big.
        /// Note: This settings is only supported for the &apos;yolov5&apos; algorithm.
        /// </summary>
        public int? ImageSize { get; set; }
        /// <summary>
        /// Maximum size of the image to be rescaled before feeding it to the backbone.
        /// Must be a positive integer. Note: training run may get into CUDA OOM if the size is too big.
        /// Note: This settings is not supported for the &apos;yolov5&apos; algorithm.
        /// </summary>
        public int? MaxSize { get; set; }
        /// <summary>
        /// Minimum size of the image to be rescaled before feeding it to the backbone.
        /// Must be a positive integer. Note: training run may get into CUDA OOM if the size is too big.
        /// Note: This settings is not supported for the &apos;yolov5&apos; algorithm.
        /// </summary>
        public int? MinSize { get; set; }
        /// <summary>
        /// Model size. Must be &apos;small&apos;, &apos;medium&apos;, &apos;large&apos;, or &apos;xlarge&apos;.
        /// Note: training run may get into CUDA OOM if the model size is too big.
        /// Note: This settings is only supported for the &apos;yolov5&apos; algorithm.
        /// </summary>
        public ModelSize? ModelSize { get; set; }
        /// <summary>
        /// Enable multi-scale image by varying image size by +/- 50%.
        /// Note: training run may get into CUDA OOM if no sufficient GPU memory.
        /// Note: This settings is only supported for the &apos;yolov5&apos; algorithm.
        /// </summary>
        public bool? MultiScale { get; set; }
        /// <summary> IOU threshold used during inference in NMS post processing. Must be a float in the range [0, 1]. </summary>
        public float? NmsIouThreshold { get; set; }
        /// <summary>
        /// The grid size to use for tiling each image. Note: TileGridSize must not be
        /// None to enable small object detection logic. A string containing two integers in mxn format.
        /// Note: This settings is not supported for the &apos;yolov5&apos; algorithm.
        /// </summary>
        public string TileGridSize { get; set; }
        /// <summary>
        /// Overlap ratio between adjacent tiles in each dimension. Must be float in the range [0, 1).
        /// Note: This settings is not supported for the &apos;yolov5&apos; algorithm.
        /// </summary>
        public float? TileOverlapRatio { get; set; }
        /// <summary>
        /// The IOU threshold to use to perform NMS while merging predictions from tiles and image.
        /// Used in validation/ inference. Must be float in the range [0, 1].
        /// Note: This settings is not supported for the &apos;yolov5&apos; algorithm.
        /// </summary>
        public float? TilePredictionsNmsThreshold { get; set; }
        /// <summary> IOU threshold to use when computing validation metric. Must be float in the range [0, 1]. </summary>
        public float? ValidationIouThreshold { get; set; }
        /// <summary> Metric computation method to use for validation metrics. </summary>
        public ValidationMetricType? ValidationMetricType { get; set; }
    }
}
