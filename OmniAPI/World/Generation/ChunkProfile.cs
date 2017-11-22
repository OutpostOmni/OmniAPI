/**
 * This file is part of OmniAPI, licensed under the MIT License (MIT).
 *
 * Copyright (c) 2017 Helion3 http://helion3.com/
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 *
 * The above copyright notice and this permission notice shall be included in
 * all copies or substantial portions of the Software.
 *
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
 * THE SOFTWARE.
 */
using UnityEngine;

namespace OmniAPI.World.Generation {
    /// <summary>
    /// Chunk generation state
    /// </summary>
    public enum GenerationState {
        /// <summary>
        /// Chunk has been profiled but no coordinates generated.
        /// </summary>
        NEW,

        /// <summary>
        /// Chunk features/coordinates have been calculated/generated.
        /// </summary>
        GENERATED,

        /// <summary>
        /// The chunk has finished and has likely been rendered.
        /// 
        /// This will be the state used for chunks loaded from disk.
        /// </summary>
        FINISHED
    }

    public class ChunkProfile {
        /// <summary>
        /// The chunk coordinate.
        /// </summary>
        public readonly Vector2 Coordinate;

        /// <summary>
        /// The chunk seed.
        /// </summary>
        public readonly int Seed;

        /// <summary>
        /// A random number generator, initialized with the chunk seed.
        /// </summary>
        public readonly System.Random RNG;

        /// <summary>
        /// Randonmly chosen points (currently one per chunk) for sampling uses.
        /// </summary>
        public CoordinateProfile[] Points;

        /// <summary>
        /// Coordinate profiles for this chunk. 
        /// </summary>
        public readonly CoordinateProfile[] Coordinates;

        /// <summary>
        /// The current generation state.
        /// </summary>
        public GenerationState GenerationState = GenerationState.NEW;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:OmniAPI.World.Generation.ChunkProfile"/> class.
        /// </summary>
        /// <param name="coordinateSize">Coordinate size.</param>
        /// <param name="coordinate">Coordinate.</param>
        /// <param name="seed">Seed.</param>
        /// <param name="rng">Rng.</param>
        public ChunkProfile(int coordinateSize, Vector2 coordinate, int seed, System.Random rng) {
            this.Coordinate = coordinate;
            this.Coordinates = new CoordinateProfile[coordinateSize];
            this.Seed = seed;
            this.RNG = rng;
        }
    }
}
