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
using OmniAPI.Services.Event;
using OmniAPI.World;
using UnityEngine;

namespace OmniAPI.Entities {
	abstract public class Entity : MonoBehaviour, IEntity {
		// An ID of the current prefab
		public string PrefabId;

		// A unique UUID assigned to this specific entity
		public string UniqueID = System.Guid.NewGuid().ToString();

		// A convenience property caching our parent tile, if any
		public ITile Tile;

		/// <summary>
		/// Gets the identifier.
		/// </summary>
		/// <returns>The identifier.</returns>
		public virtual string GetId() {
            return UniqueID;
		}

		/// <summary>
		/// Get a new variant, if any. Useful if this entity has to change
		/// based on updates to neighboring tiles.
		/// </summary>
		/// <returns>The variant.</returns>
		public virtual string GetVariant() {
			return null;
		}

		/// <summary>
		/// Called when the entity is broken by a game object or player.
		/// </summary>
		public virtual void OnBreak() {}

		/// <summary>
		/// Called when a change has been made which might update this entity.
		/// </summary>
		public virtual void OnNotify() {}

		/// <summary>
		/// Called when the entity has been rendered.
		/// </summary>
		/// <param name="cause">Spawn cause.</param>
		public virtual void OnRender(Cause cause) {}
	}
}
