﻿/**
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

namespace OmniAPI {
	/// <summary>
	/// Represents a single world tile.
	/// </summary>
	public interface ITile {
		/// <summary>
		/// Gets the identifier.
		/// </summary>
		/// <value>The identifier.</value>
		string id { get; }

		/// <summary>
		/// Gets the world vec.
		/// </summary>
		/// <value>The world vec.</value>
		Vector2 WorldVec { get; }

		/// <summary>
		/// Sets the entity.
		/// </summary>
		/// <param name="id">Identifier.</param>
		/// <param name="shouldUpdateNeighbors">If set to <c>true</c> should update neighbors.</param>
		void SetEntity(string id, bool shouldUpdateNeighbors = false);

		/// <summary>
		/// Sets the type of this tile.
		/// </summary>
		/// <param name="id">Tile Identifier.</param>
		/// <param name="shouldUpdateNeighbors">If set to <c>true</c> should trigger updates for neighbors.</param>
		void SetType(string id, bool shouldUpdateNeighbors = false);
	}
}
