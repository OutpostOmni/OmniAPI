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
using System;
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
        /// Breaks the tile entity.
        /// </summary>
        /// <returns>The tile entity.</returns>
        /// <param name="cause">Cause.</param>
        /// <param name="entity">Entity.</param>
        List<IItem> BreakTileEntity(Cause cause, IEntity entity);

        /// <summary>
        /// Finds the closest entity of a given type.
        /// </summary>
        /// <returns>The entity of type.</returns>
        /// <param name="worldVec">World vec.</param>
        /// <param name="facing">Facing.</param>
        /// <param name="type">Type.</param>
        IEntity ClosestEntityOfType(Vector2 worldVec, Vector2 facing, Type type);

        /// <summary>
        /// Finds the closest entities matching the given types.
        /// </summary>
        /// <returns>The entity of types.</returns>
        /// <param name="worldVec">World vec.</param>
        /// <param name="facing">Facing.</param>
        /// <param name="types">Types.</param>
        IEntity ClosestEntityOfTypes(Vector2 worldVec, Vector2 facing, Type[] types);

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
        /// 
        /// Returns empty if this chunk is actively queued for load.
		/// </summary>
		/// <returns>The chunk.</returns>
		/// <param name="chunkVec">Chunk vec.</param>
        Optional<IChunk> GetChunk(Vector2 chunkVec);

        /// <summary>
        /// Gets the chunk.
        /// </summary>
        /// <returns>The chunk.</returns>
        /// <param name="chunkVec">Chunk vec.</param>
        /// <param name="autoLoad">If set to <c>true</c> auto load.</param>
        Optional<IChunk> GetChunk(Vector2 chunkVec, bool autoLoad);

		/// <summary>
		/// Gets the chunk containing a world coordinate.
        /// 
        /// Returns empty if this chunk is actively queued for load.
		/// </summary>
		/// <returns>The chunk for world coordinate.</returns>
		/// <param name="worldVec">World vec.</param>
        Optional<IChunk> GetChunkForWorldCoord(Vector2 worldVec);

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
        /// Gets the entities within range.
        /// </summary>
        /// <returns>The entities within range.</returns>
        /// <param name="worldVec">World vec.</param>
        /// <param name="radius">Radius.</param>
        /// <param name="types">Types.</param>
        IEntity[] GetEntitiesWithinRange(Vector2 worldVec, int radius, Type[] types);

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
        /// Get the current movement surface, if any. Entities first, tiles second.
        /// </summary>
        /// <returns>The movement surface.</returns>
        /// <param name="worldVec">World vec.</param>
        Optional<IMovementSurface> GetMovementSurface(Vector2 worldVec);

        /// <summary>
        /// Gets the rocks catalogue.
        /// </summary>
        /// <returns>The rocks catalogue.</returns>
        IWeightedCatalogue<Tuple<string, string>> GetRocksCatalogue();

		/// <summary>
		/// Gets a tile by its world vector.
		/// </summary>
		/// <returns>The tile.</returns>
		/// <param name="worldVec">World vec.</param>
		ITile GetTile(Vector2 worldVec);

        /// <summary>
        /// Gets the tile.
        /// </summary>
        /// <returns>The tile.</returns>
        /// <param name="worldVec">World vec.</param>
        /// <param name="autoLoadChunk">If set to <c>true</c> auto load chunk.</param>
        Optional<ITile> GetTile(Vector2 worldVec, bool autoLoadChunk);

		/// <summary>
		/// Loads the chunk for a given chunk vec. 
        /// 
        /// Will not load an already-loaded chunk.
        /// Returns empty if chunk is actively queued to load.
		/// 
		/// If saved, will load from disk, otherwise it will generate the chunk for the first time.
		/// </summary>
		/// <returns>The chunk, if it could be loaded.</returns>
		/// <param name="chunkVec">Chunk vec.</param>
        Optional<IChunk> LoadChunk(Vector2 chunkVec);

        /// <summary>
        /// Removes an entity without "breaking" it or cause.
        /// </summary>
        /// <param name="entity">Entity.</param>
        void RemoveEntity(IEntity entity);
    
        /// <summary>
        /// Set the tile type of a given vector.
        /// </summary>
        /// <param name="worldVec">World vec.</param>
        /// <param name="tileId">Tile identifier.</param>
        void SetTile(Vector2 worldVec, string tileId, byte variantId);

        /// <summary>
        /// Sets the tile and optionally notifies neighbors.
        /// </summary>
        /// <param name="worldVec">World vec.</param>
        /// <param name="tileId">Tile identifier.</param>
        /// <param name="variantId">Variant identifier.</param>
        /// <param name="shouldNotifyNeighbors">If set to <c>true</c> should notify neighbors.</param>
        void SetTile(Vector2 worldVec, string tileId, byte variantId, bool shouldNotifyNeighbors);

        /// <summary>
        /// Spawn an entity.
        /// </summary>
        /// <param name="cause">Cause.</param>
        /// <param name="worldVec">World vec.</param>
        /// <param name="entityPrefabId">Entity prefab identifier.</param>
        IEntity SpawnEntity(Cause cause, Vector2 worldVec, string entityPrefabId);

		/// <summary>
		/// Spawn an entity.
		/// </summary>
		/// <param name="cause">Cause.</param>
		/// <param name="worldVec">World vec.</param>
		/// <param name="entityPrefabId">Entity prefab identifier.</param>
		IEntity SpawnEntity(Cause cause, Vector2 worldVec, string entityPrefabId, byte variantId);

        /// <summary>
        /// Spawns an entity into a given holder.
        /// </summary>
        /// <returns>The entity.</returns>
        /// <param name="holder">Holder.</param>
        /// <param name="cause">Cause.</param>
        /// <param name="worldVec">World vec.</param>
        /// <param name="entityId">Entity identifier.</param>
        /// <param name="shouldNotifyNeighbors">If set to <c>true</c> should notify neighbors.</param>
        IEntity SpawnEntity(IEntityHolder holder, Cause cause, Vector2 worldVec, string entityPrefabId, bool shouldNotifyNeighbors);

        /// <summary>
        /// Spawns an entity into a given holder.
        /// </summary>
        /// <returns>The entity.</returns>
        /// <param name="holder">Holder.</param>
        /// <param name="cause">Cause.</param>
        /// <param name="worldVec">World vec.</param>
        /// <param name="entityId">Entity identifier.</param>
        /// <param name="shouldNotifyNeighbors">If set to <c>true</c> should notify neighbors.</param>
        IEntity SpawnEntity(IEntityHolder holder, Cause cause, Vector2 worldVec, string entityPrefabId, byte variantId, bool shouldNotifyNeighbors);
	}
}
