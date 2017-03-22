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
using UnityEngine;

namespace OmniAPI {
	/// <summary>
	/// Represents a waypoint on a player's map.
	/// </summary>
	public class Waypoint {
		/// <summary>
		/// Represents the coordinate this waypoint is assigned to.
		/// </summary>
		/// <value>The coordinate.</value>
		public Vector2 coordinate;

		/// <summary>
		/// The waypoint type, defaults to HOME.
		/// </summary>
		public WaypointType type = WaypointType.HOME;

		public Waypoint() {}

		/// <summary>
		/// Initializes a new waypoint.
		/// </summary>
		/// <param name="coordinate">Coordinate.</param>
		public Waypoint(Vector2 coordinate) {
			this.coordinate = coordinate;
		}

		/// <summary>
		/// Determines whether the specified <see cref="object"/> is equal to the current <see cref="T:OmniAPI.Waypoint"/>.
		/// </summary>
		/// <param name="obj">The <see cref="object"/> to compare with the current <see cref="T:OmniAPI.Waypoint"/>.</param>
		/// <returns><c>true</c> if the specified <see cref="object"/> is equal to the current <see cref="T:OmniAPI.Waypoint"/>;
		/// otherwise, <c>false</c>.</returns>
		public override bool Equals(object obj) {
			Waypoint waypoint = obj as Waypoint;
			if (waypoint == null) {
				return false;
			} else {
				return coordinate.Equals(waypoint.coordinate);
			}
		}
	}
}
