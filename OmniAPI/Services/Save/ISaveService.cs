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
using OmniAPI.Players;
using OmniAPI.Util;
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
        IGameProfile CurrentProfile { get; }

        /// <summary>
        /// Check if a chunk save exists.
        /// </summary>
        /// <returns><c>true</c>, if chunk save exists, <c>false</c> otherwise.</returns>
        /// <param name="chunkVec">Chunk vec.</param>
        bool ChunkSaveExists(Vector2 chunkVec);

        /// <summary>
        /// Creates a new save.
        /// </summary>
        /// <param name="profile">Profile.</param>
        void CreateNewSave(IGameProfile profile);

        /// <summary>
        /// Create or load game.
        /// </summary>
        /// <param name="profile">Profile.</param>
        void CreateOrLoadGame(IGameProfile profile);

        /// <summary>
        /// Deletes a game for a given profile.
        /// </summary>
        /// <param name="profile">Profile.</param>
        void DeleteGame(IGameProfile profile);

        /// <summary>
        /// Lists all saved games.
        /// </summary>
        /// <returns>The saved games.</returns>
        IGameProfile[] GetSavedGames();

        /// <summary>
        /// Load a chunk.
        /// </summary>
        /// <returns>The chunk.</returns>
        /// <param name="chunkVec">Chunk vec.</param>
        IChunk LoadChunk(Vector2 chunkVec);

        /// <summary>
        /// Loads a player's save file, if any.
        /// </summary>
        /// <returns><c>true</c>, if player was loaded, <c>false</c> otherwise.</returns>
        /// <param name="player">Player.</param>
        bool LoadPlayer(IPlayer player);

        /// <summary>
        /// Loads the save game.
        /// </summary>
        /// <param name="profile">Profile.</param>
        void LoadSaveGame(IGameProfile profile);

        /// <summary>
        /// Reads a game profile, without loading the save.
        /// </summary>
        /// <returns>The game profile.</returns>
        /// <param name="saveName">Save name.</param>
        Optional<IGameProfile> ReadGameProfile(string saveName);

        /// <summary>
        /// Registers a new save target.
        /// </summary>
        /// <param name="target">Target.</param>
        void RegisterTarget(IPersistanceTarget target);

        /// <summary>
        /// Saves a chunk.
        /// </summary>
        /// <param name="chunk">Chunk.</param>
        void SaveChunk(IChunk chunk);

        /// <summary>
        /// Saves the game.
        /// </summary>
        void SaveGame();
    }
}
