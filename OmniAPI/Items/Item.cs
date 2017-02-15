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
using System;
using UnityEngine;

namespace OmniAPI {
	abstract public class Item {
		// Quantity of items contained in this "stack"
		private int _quantity = 1;
		public int quantity {
			get { return _quantity; }
			set {
				_quantity = value;

				if (_quantity <= 0) {
					expired = true;
				}
			}
		}

		// Set the maximum quantity, or <= 0 for infinite
		public int maxStackSize = -1;

		// Set a textual name for this item
		public string name = "Unknown";

		// Expired items will be removed from any containers next frame
		public bool expired = false;

		// Internal-use cache for this gameobject, which may hold components
		protected GameObject gameObject = new GameObject();

		/// <summary>
		/// Zero-argument constructor for dynamic instantiation
		/// </summary>
		protected Item() : this(1) {}

		/// <summary>
		/// Initializes a new instance of the Item.
		/// </summary>
		/// <param name="quantity">Quantity.</param>
		protected Item(int quantity = 1) {
			this.quantity = quantity;
		}

		/// <summary>
		/// Convenience method to get a component from our game object.
		/// </summary>
		/// <returns>The component.</returns>
		/// <typeparam name="T">Component type</typeparam>
		public Optional<T> GetComponent<T>() {
			return Optional<T>.From(gameObject.GetComponent<T>());
		}

		/// <summary>
		/// Convenience method to get a component from our game object.
		/// </summary>
		/// <returns>The component.</returns>
		/// <param name="type">Component type</param>
		public Component GetComponent(Type type) {
			return gameObject.GetComponent(type);
		}

		/// <summary>
		/// Convenience method to get components from our game object.
		/// </summary>
		/// <returns>The component.</returns>
		/// <typeparam name="T">Component type</typeparam>
		public T[] GetComponents<T>() {
			return gameObject.GetComponents<T>();
		}

		/// <summary>
		/// Gets the identifier.
		/// </summary>
		/// <returns>The identifier.</returns>
		public virtual string GetId() {
			return null;
		}

		/// <summary>
		/// Gets the sprite identifier. Typically this will not be different from the item ID.
		/// </summary>
		/// <returns>The sprite identifier.</returns>
		public virtual string GetSpriteId() {
			return GetId();
		}

		/// <summary>
		/// Determines whether the specified <see cref="object"/> is equal to the current <see cref="T:OmniAPI.Item"/>.
		/// </summary>
		/// <param name="obj">The <see cref="object"/> to compare with the current <see cref="T:OmniAPI.Item"/>.</param>
		/// <returns><c>true</c> if the specified <see cref="object"/> is equal to the current <see cref="T:OmniAPI.Item"/>; otherwise, <c>false</c>.</returns>
		public override bool Equals(object obj) {
			Item item = obj as Item;
			if (item == null) {
				return false;
			} else {
				return GetId() == item.GetId();
			}
		}

		/// <summary>
		/// Serves as a hash function for a <see cref="T:OmniAPI.Item"/> object.
		/// </summary>
		/// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a hash table.</returns>
		public override int GetHashCode() {
			return GetId().GetHashCode();
		}
	}
}
