// Copyright (c) Six Labors.
// Licensed under the Apache License, Version 2.0.

namespace SixLabors.ImageSharp.Processing.Processors.Convolution
{
    /// <summary>
    /// Defines edge detection processing using the Laplacian 5x5 operator filter.
    /// <see href="http://en.wikipedia.org/wiki/Discrete_Laplace_operator"/>.
    /// </summary>
    public sealed class Laplacian5x5Processor : EdgeDetectorProcessor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Laplacian5x5Processor"/> class.
        /// </summary>
        /// <param name="grayscale">Whether to convert the image to grayscale before performing edge detection.</param>
        public Laplacian5x5Processor(bool grayscale)
            : base(grayscale)
        {
        }

        /// <inheritdoc />
        public override IImageProcessor<TPixel> CreatePixelSpecificProcessor<TPixel>(Configuration configuration, Image<TPixel> source, Rectangle sourceRectangle)
            => new EdgeDetectorProcessor<TPixel>(configuration, LaplacianKernels.Laplacian5x5, this.Grayscale, source, sourceRectangle);
    }
}
