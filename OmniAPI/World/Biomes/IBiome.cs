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
using OmniAPI.Util;
using OmniAPI.World.Generation;
using UnityEngine;

namespace OmniAPI.World.Biomes {
    /// <summary>
    /// Represents a biome.
    /// </summary>
    public interface IBiome {
        /// <summary>
        /// Gets the color to be used with mapping.
        /// </summary>
        /// <value>The map color.</value>
        Color MapColor { get; }

        /// <summary>
        /// Biome priority ranks it above or below others when multiple biomes apply.
        /// </summary>
        /// <value>The priority.</value>
        int Priority { get; set; }

        /// <summary>
        /// Indicates this biome accepts a coordinate profile (terrain gen).
        /// </summary>
        /// <returns>The accepts.</returns>
        /// <param name="profile">Profile.</param>
        bool Accepts(CoordinateProfile profile);

        /// <summary>
        /// Determine a tile type for the given coordinate.
        /// </summary>
        /// <param name="chunkProfile">Chunk profile.</param>
        /// <param name="profile">Profile.</param>
        void GenerateCoordinateTile(ChunkProfile chunkProfile, CoordinateProfile profile);

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <returns>The identifier.</returns>
        string GetId();

        /// <summary>
        /// Get populator catalogues.
        /// </summary>
        /// <returns>The populator catalogues.</returns>
        IPopulatorCatalogues GetPopulatorCatalogues();

        /// <summary>
        /// Populates the chunk.
        /// </summary>
        /// <param name="chunk">Chunk.</param>
        /// <param name="population">Population.</param>
        void PopulateChunk(IChunk chunk, ChunkPopulation population);
    }
}
