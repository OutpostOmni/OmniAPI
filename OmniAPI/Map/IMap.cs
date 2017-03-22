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
	/// Represents the in-game Map.
	/// </summary>
	public interface IMap {
		/// <summary>
		/// Gets the active waypoint, if any.
		/// </summary>
		/// <value>The optional active waypoint.</value>
		Optional<Waypoint> activeWaypoint { get; }

		/// <summary>
		/// Activates a waypoint.
		/// </summary>
		/// <param name="waypoint">Waypoint.</param>
		void ActivateWaypoint(Waypoint waypoint);

		/// <summary>
		/// Adds a waypoint.
		/// </summary>
		/// <param name="waypoint">Waypoint.</param>
		void AddWaypoint(Waypoint waypoint);

		/// <summary>
		/// Gets the waypoint for a given vector.
		/// </summary>
		/// <returns>The waypoint.</returns>
		/// <param name="pos">Position.</param>
		Optional<Waypoint> GetWaypointFor(Vector2 pos);

		/// <summary>
		/// Removes a waypoint.
		/// </summary>
		/// <param name="waypoint">Waypoint.</param>
		void RemoveWaypoint(Waypoint waypoint);
	}
}