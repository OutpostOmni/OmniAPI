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
using UnityEngine;

namespace OmniAPI.World {
	/// <summary>
	/// Represents a single world tile.
	/// </summary>
    public interface ITile : IEntityHolder, IMovementSurface, IChunkChild {
        /// <summary>
        /// Gets the environment.
        /// </summary>
        /// <value>The environment.</value>
        CoordinateProfile Environment { get; }

        /// <summary>
        /// Gets the entity speed modifier.
        /// </summary>
        /// <value>The entity speed modifier.</value>
        new float EntitySpeedModifier { get; }

        /// <summary>
        /// Is this tile liquid.
        /// </summary>
        /// <returns><c>true</c>, if liquid was ised, <c>false</c> otherwise.</returns>
        bool IsLiquid { get; }

        /// <summary>
        /// Gets the world vec.
        /// </summary>
        /// <value>The world vec.</value>
        Vector2 WorldVec { get; }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <returns>The identifier.</returns>
        string GetId();

        /// <summary>
        /// Called when a neighbor updates and shouldNotifyNeighbors was true.
        /// </summary>
        void OnNeighborUpdate();

		/// <summary>
		/// Sets the type of this tile.
		/// </summary>
		/// <param name="id">Tile Identifier.</param>
		/// <param name="shouldUpdateNeighbors">If set to <c>true</c> should trigger updates for neighbors.</param>
		//void SetType(string id, bool shouldUpdateNeighbors = false);
	}
}
