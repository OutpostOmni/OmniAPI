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
using OmniAPI.Entities;
using OmniAPI.World.Generation;
using UnityEngine;

namespace OmniAPI.World {
	/// <summary>
	/// Represents a chunk of world tiles.
	/// </summary>
	public interface IChunk {
        /// <summary>
        /// Gets current children.
        /// </summary>
        /// <value>The children.</value>
        IChunkChild[] Children { get; }

        /// <summary>
        /// Gets the entities.
        /// </summary>
        /// <value>The entities.</value>
        IEntity[] Entities { get; }

        /// <summary>
        /// Gets the profile.
        /// </summary>
        /// <value>The profile.</value>
        ChunkProfile Profile { get; }

        /// <summary>
        /// Get all entities within the tile represented by worldVec.
        /// </summary>
        /// <returns>The entities.</returns>
        /// <param name="worldVec">World vec.</param>
        IEntity[] GetEntities(Vector2 worldVec);

		/// <summary>
		/// Gets a tile by its local vector.
		/// </summary>
		/// <returns>The tile.</returns>
		/// <param name="localVec">Local vec.</param>
		ITile GetTile(Vector2 localVec);

        /// <summary>
        /// Gets a tile by its index.
        /// </summary>
        /// <returns>The tile.</returns>
        /// <param name="index">Index.</param>
        ITile GetTile(int index);

        /// <summary>
        /// Called when this chunk has been loaded, or a neighbor has
        /// been loaded. This call will also call any Children#OnChunkUpdate
        /// </summary>
        void OnUpdate();

        /// <summary>
        /// Sets the tile.
        /// </summary>
        /// <param name="localVec">Local vec.</param>
        /// <param name="tile">Tile.</param>
        void SetTile(Vector2 localVec, ITile tile);
	}
}
