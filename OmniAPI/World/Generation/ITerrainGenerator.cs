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
using OmniAPI.World.Generation.Layers;

namespace OmniAPI.World.Generation {
    /// <summary>
    /// Generate terrain.
    /// </summary>
    public interface ITerrainGenerator {
        /// <summary>
        /// Calculates the chunk profile.
        /// 
        /// This is responsible for setting the chunk seed, RNG, chosing a sample point.
        /// </summary>
        /// <returns>The chunk profile.</returns>
        /// <param name="region">Region.</param>
        /// <param name="chunkX">Chunk x.</param>
        /// <param name="chunkY">Chunk y.</param>
        ChunkProfile CalculateChunkProfile(IRegion region, int chunkX, int chunkY);

        /// <summary>
        /// Calculates the coordinate profile.
        /// 
        /// This is responsible for calculating height, temperature, and other noise values.
        /// </summary>
        /// <returns>The coordinate profile.</returns>
        /// <param name="chunkX">Chunk x.</param>
        /// <param name="chunkY">Chunk y.</param>
        CoordinateProfile CalculateCoordinateProfile(int chunkX, int chunkY);

        /// <summary>
        /// Generates the chunk.
        /// 
        /// Applies all feature cache values, finalizes tiles based on neighbors.
        /// </summary>
        /// <returns>The chunk.</returns>
        /// <param name="profile">Profile.</param>
        /// <param name="region">Region.</param>
        ChunkProfile GenerateChunk(ChunkProfile profile, IRegion region);

        /// <summary>
        /// Pregenerates chunks.
        /// 
        /// Pre-generates a region of chunks.
        /// </summary>
        /// <returns>The generate chunks.</returns>
        /// <param name="chunkX">Chunk x.</param>
        /// <param name="chunkY">Chunk y.</param>
        /// <param name="chunkRadiusX">Chunk radius x.</param>
        /// <param name="chunkRadiusY">Chunk radius y.</param>
        IRegion PreGenerateChunks(int chunkX, int chunkY, int chunkRadiusX, int chunkRadiusY);

        /// <summary>
        /// Pregenerates a chunk.
        /// 
        /// Calculates all coordinate profiles, ensures necessary neighbor tiles have been calculated.
        /// </summary>
        /// <returns>The generate chunk.</returns>
        /// <param name="chunkX">Chunk x.</param>
        /// <param name="chunkY">Chunk y.</param>
        /// <param name="region">Region.</param>
        ChunkProfile PreGenerateChunk(int chunkX, int chunkY, IRegion region);

        /// <summary>
        /// Pregenerates a chunk.
        /// </summary>
        /// <returns>The generate chunk.</returns>
        /// <param name="profile">Profile.</param>
        /// <param name="region">Region.</param>
        ChunkProfile PreGenerateChunk(ChunkProfile profile, IRegion region);

        /// <summary>
        /// Register a generation layer.
        /// </summary>
        /// <param name="layer">Layer.</param>
        void RegisterLayer(IGenerationLayer layer);
    }
}
