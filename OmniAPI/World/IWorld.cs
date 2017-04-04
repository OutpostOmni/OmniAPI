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
using System.Collections.Generic;
using UnityEngine;

namespace OmniAPI {
	/// <summary>
	/// Represents the game world.
	/// </summary>
	public interface IWorld {
		/// <summary>
		/// Drops an item into the world, with an animation depending on it's start position.
		/// </summary>
		/// <param name="parentWorldPos">Parent world position.</param>
		/// <param name="startPos">Start position.</param>
		/// <param name="item">Item.</param>
		void DropItem(Vector2 parentWorldPos, Vector3 startPos, Item item);

		/// <summary>
		/// Gets a chunk.
		/// </summary>
		/// <returns>The chunk.</returns>
		/// <param name="chunkVec">Chunk vec.</param>
		IChunk GetChunk(Vector2 chunkVec);

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
		/// Gets all items currently in-world.
		/// </summary>
		/// <returns>The items.</returns>
		List<Item> GetItems();

		/// <summary>
		/// Gets a tile by its world vector.
		/// </summary>
		/// <returns>The tile.</returns>
		/// <param name="worldVec">World vec.</param>
		ITile GetTile(Vector2 worldVec);

		/// <summary>
		/// Gets the time.
		/// </summary>
		/// <returns>The time.</returns>
		ITime GetTime();

		/// <summary>
		/// Spawn an entity.
		/// </summary>
		/// <param name="cause">Cause.</param>
		/// <param name="worldVec">World vec.</param>
		/// <param name="entityPrefabId">Entity prefab identifier.</param>
		void SpawnEntity(Cause cause, Vector2 worldVec, string entityPrefabId);

		/// <summary>
		/// Spawn an entity.
		/// </summary>
		/// <param name="cause">Cause.</param>
		/// <param name="worldVec">World vec.</param>
		/// <param name="entityPrefabId">Entity prefab identifier.</param>
		/// <param name="shouldNotifyNeighbors">If set to <c>true</c> should notify neighbors.</param>
		void SpawnEntity(Cause cause, Vector2 worldVec, string entityPrefabId, bool shouldNotifyNeighbors);
	}
}
