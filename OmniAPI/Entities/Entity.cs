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
using OmniAPI.Entities.Traits;
using OmniAPI.Rendering;
using OmniAPI.Services.Event;
using OmniAPI.Util;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace OmniAPI.Entities {
    abstract public class Entity : MonoBehaviour, IEntity, IPoolListener {
        // Entity is in the process of being removed
        public bool expired;

        /// <summary>
        /// Determine a "facing" direction for this entity.
        /// </summary>
        /// <value>The facing.</value>
        public Vector2 Facing { get; set; }

		// An ID of the current prefab
		public string PrefabId;

        // An ID of the current variant. Not all entities will use
        // variants, but it's common enough and minor enough to 
        // warrant just storing here.
        public byte VariantId;

		// Sets the rendering layer.
		public RenderLayer RenderLayer = RenderLayer.Entities;

		// A unique UUID assigned to this specific entity
		public string UniqueID = System.Guid.NewGuid().ToString();

        /// <summary>
        /// Access property to the 2D world vec.
        /// </summary>
        /// <value>The world vec.</value>
        public Vector2 WorldVec {
            get { return GetTileCoordinate(); }
        }

        // Cache list of all traits
        Dictionary<Type, ITrait> traits = new Dictionary<Type, ITrait>();

        /// <summary>
        /// Adds a trait.
        /// </summary>
        /// <param name="trait">Trait.</param>
        /// <typeparam name="T">The trait type parameter.</typeparam>
        public void AddTrait<T>(ITrait trait) where T : ITrait {
            traits.Add(typeof(T), trait);
        }

		/// <summary>
		/// Gets the identifier.
		/// </summary>
		/// <returns>The identifier.</returns>
		public virtual string GetId() {
            return UniqueID;
		}

		/// <summary>
		/// Gets the tile coordinate, which is our world positioned "floored" to the current tile coordinate.
		/// </summary>
		/// <returns>The tile coordinate.</returns>
		public Vector2 GetTileCoordinate() {
			var pos = transform.position;

			// Round, because tiles are positioned via the center pivot, so tile 2,0 includes 1.5,0 - 2.5,0
			return new Vector2(Mathf.RoundToInt(pos.x), Mathf.RoundToInt(pos.y));
		}

        /// <summary>
        /// Gets the trait.
        /// </summary>
        /// <returns>The trait.</returns>
        /// <typeparam name="T">The trait type parameter.</typeparam>
        public Optional<T> GetTrait<T>() where T : ITrait {
            if (HasTrait<T>()) {
                return Optional<T>.From((T) traits[typeof(T)]);
            } else {
                return Optional<T>.Empty();
            }
        }

        /// <summary>
        /// Get whether this entity has the given trait.
        /// </summary>
        /// <returns><c>true</c>, if has the trait, <c>false</c> otherwise.</returns>
        /// <typeparam name="T">The trait type parameter.</typeparam>
        public bool HasTrait<T>() where T : ITrait {
            return traits.ContainsKey(typeof(T));
        }

		/// <summary>
        /// Called when the entity is broken by a game object or player.
        /// </summary>
        /// <param name="cause">Cause.</param>
        /// <param name="callback">Callback.</param>
		public virtual void OnBreak(Cause cause, Action callback) {
            callback();
        }

        /// <summary>
        /// On despawn.
        /// </summary>
        public virtual void OnDespawn() {
            expired = false;
        }

        /// <summary>
        /// A neighbor tile has been updated and notifications sent.
        /// </summary>
        public virtual void OnNeighborUpdate() {}

		/// <summary>
		/// Called when the entity has been rendered.
		/// </summary>
		public virtual void OnRender() {}

        /// <summary>
        /// On spawn.
        /// </summary>
        public virtual void OnSpawn() {}
	}
}
