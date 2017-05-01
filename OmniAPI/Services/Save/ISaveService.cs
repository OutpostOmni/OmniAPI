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
using OmniAPI.Game;
using OmniAPI.Entities;
using OmniAPI.World;
using UnityEngine;

namespace OmniAPI.Services.Save {
    /// <summary>
    /// Represents the game save/load service.
    /// </summary>
    public interface ISaveService : IService {
        /// <summary>
        /// Gets the profile.
        /// </summary>
        /// <value>The profile.</value>
        IGameProfile Profile { get; }

        /// <summary>
        /// Checks if the chunk save exists.
        /// </summary>
        /// <returns><c>true</c>, if save exists, <c>false</c> otherwise.</returns>
        /// <param name="chunkVec">Chunk vec.</param>
        bool ChunkSaveExists(Vector2 chunkVec);

        /// <summary>
        /// Loads a chunk.
        /// </summary>
        /// <returns>The chunk.</returns>
        /// <param name="chunkVec">Chunk vec.</param>
        IChunk LoadChunk(Vector2 chunkVec);

        /// <summary>
        /// Loads an entity.
        /// </summary>
        /// <returns><c>true</c>, if entity was loaded, <c>false</c> otherwise.</returns>
        /// <param name="entity">Entity.</param>
        bool LoadEntity(Entity entity);

        /// <summary>
        /// Saves a chunk.
        /// </summary>
        /// <param name="chunk">Chunk.</param>
        /// <param name="async">If set to <c>true</c> async.</param>
        void SaveChunk(IChunk chunk, bool async = true);
    }
}
