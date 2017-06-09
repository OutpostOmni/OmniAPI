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
using OmniAPI.Items;
using OmniAPI.Services.Event;
using OmniAPI.Util;
using OmniAPI.World.Decoration;
using OmniAPI.World.Weather;
using System.Collections.Generic;
using UnityEngine;

namespace OmniAPI.World {
	/// <summary>
	/// Represents the game world.
	/// </summary>
	public interface IWorld {
        /// <summary>
        /// Gets or sets the decorator.
        /// </summary>
        /// <value>The decorator.</value>
        IDecorator Decorator { get; set; }

        /// <summary>
        /// Gets the time.
        /// </summary>
        /// <returns>The time.</returns>
        ITime Time { get; }

        /// <summary>
        /// Gets the weather.
        /// </summary>
        /// <value>The weather.</value>
        IWeather Weather { get; }

        /// <summary>
        /// Check if the given coorinate accepts a placeable entity.
        /// </summary>
        /// <returns><c>true</c>, if placeable entity was acceptsed, <c>false</c> otherwise.</returns>
        /// <param name="worldVec">World vec.</param>
        /// <param name="entity">Entity.</param>
        bool AcceptsPlaceableEntity(Vector2 worldVec, IPlaceableEntity entity);

        /// <summary>
        /// Check if the coordinate allows a placeable item (entity, tile, etc).
        /// </summary>
        /// <returns><c>true</c>, if placeable item was acceptsed, <c>false</c> otherwise.</returns>
        /// <param name="worldVec">World vec.</param>
        /// <param name="item">Item.</param>
        bool AcceptsPlaceableItem(Vector2 worldVec, IPlaceableItem item);

        /// <summary>
        /// Check if a coordinate allows tile placement, meaning there are 
        /// no non-placed entities present.
        /// </summary>
        /// <returns>True if tile may be placed.</returns>
        /// <param name="worldVec">World position.</param>
        bool AllowsTilePlacement(Vector2 worldVec);

        /// <summary>
        /// Breaks the tile entity.
        /// </summary>
        /// <returns>The tile entity.</returns>
        /// <param name="entity">Entity.</param>
        List<IItem> BreakTileEntity(IEntity entity);

		/// <summary>
		/// Drops an item into the world, with a slight animation from the base of the current tile.
		/// </summary>
        /// <param name="worldPos">World position.</param>
		/// <param name="item">Item.</param>
		void DropItem(Vector2 worldPos, Item item);

		/// <summary>
		/// Drops an item into the world, with an animation depending on it's start position.
		/// </summary>
		/// <param name="parentWorldPos">Parent world position.</param>
		/// <param name="startPos">Start position.</param>
		/// <param name="item">Item.</param>
		void DropItem(Vector2 parentWorldPos, Vector3 startPos, Item item);

        /// <summary>
        /// Check if a coordinate is clear of entities.
        /// </summary>
        /// <returns>True if tile is clear.</returns>
        /// <param name="worldVec">World position.</param>
        bool IsClear(Vector2 worldVec);

		/// <summary>
		/// Gets a chunk.
		/// 
		/// If it doesn't exist, it will be created.
		/// </summary>
		/// <returns>The chunk.</returns>
		/// <param name="chunkVec">Chunk vec.</param>
		IChunk GetChunk(Vector2 chunkVec);

		/// <summary>
		/// Gets the chunk containing a world coordinate.
		/// </summary>
		/// <returns>The chunk for world coordinate.</returns>
		/// <param name="worldVec">World vec.</param>
		IChunk GetChunkForWorldCoord(Vector2 worldVec);

		/// <summary>
		/// Gets the current temperature.
		/// </summary>
		/// <returns>The current temperature.</returns>
		/// <param name="worldVec">World vec.</param>
		double GetCurrentTemperature(Vector2 worldVec);

		/// <summary>
		/// Gets the current toxicity.
		/// </summary>
		/// <returns>The current toxicity.</returns>
		/// <param name="worldVec">World vec.</param>
		double GetCurrentToxicity(Vector2 worldVec);

        /// <summary>
        /// Get all entities within the tile represented by worldVec.
        /// </summary>
        /// <returns>The entities.</returns>
        /// <param name="worldVec">World vec.</param>
        IEntity[] GetEntities(Vector2 worldVec);

        /// <summary>
        /// Gets the first available entity holder (a tile or an entity holder)
        /// </summary>
        /// <returns>The first available entity holder.</returns>
        /// <param name="worldVec">World vec.</param>
        Optional<IEntityHolder> GetFirstAvailableEntityHolder(Vector2 worldVec);

		/// <summary>
		/// Gets all items currently in-world.
		/// </summary>
		/// <returns>The items.</returns>
		List<Item> GetItems();

        /// <summary>
        /// Gets the loaded chunks.
        /// </summary>
        /// <returns>The loaded chunks.</returns>
        IChunk[] GetLoadedChunks();

		/// <summary>
		/// Gets a tile by its world vector.
		/// </summary>
		/// <returns>The tile.</returns>
		/// <param name="worldVec">World vec.</param>
		ITile GetTile(Vector2 worldVec);

		/// <summary>
		/// Loads the chunk for a given chunk vec. Will not load an already-loaded chunk.
		/// 
		/// If saved, will load from disk, otherwise it will generate the chunk for the first time.
		/// </summary>
		/// <returns>The chunk.</returns>
		/// <param name="chunkVec">Chunk vec.</param>
		IChunk LoadChunk(Vector2 chunkVec);

		/// <summary>
		/// Spawn an entity.
		/// </summary>
		/// <param name="cause">Cause.</param>
		/// <param name="worldVec">World vec.</param>
		/// <param name="entityPrefabId">Entity prefab identifier.</param>
		IEntity SpawnEntity(Cause cause, Vector2 worldVec, string entityPrefabId);

        /// <summary>
        /// Spawns an entity into a given holder.
        /// </summary>
        /// <returns>The entity.</returns>
        /// <param name="holder">Holder.</param>
        /// <param name="cause">Cause.</param>
        /// <param name="worldVec">World vec.</param>
        /// <param name="entityId">Entity identifier.</param>
        /// <param name="shouldNotifyNeighbors">If set to <c>true</c> should notify neighbors.</param>
        IEntity SpawnEntity(IEntityHolder holder, Cause cause, Vector2 worldVec, string entityId, bool shouldNotifyNeighbors);
	}
}
