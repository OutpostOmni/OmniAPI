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
using OmniAPI.Items;
using System.Collections.Generic;

namespace OmniAPI.Components {
	/// <summary>
	/// Represents an entity's loot drops.
	/// </summary>
	public interface ILootComponent : IComponent {
		/// <summary>
		/// Add a loot item with a 100% drop chance.
		/// </summary>
		/// <typeparam name="IItem">The item type.</typeparam>
		void Add<T>(int quantity = 1) where T : IItem;

		/// <summary>
		/// Adds a loot item with a specific drop chance, between 0-1.
		/// 
		/// Chance is met when a Random float between 0-1 and less than or equal to the value.
		/// </summary>
		/// <param name="chance">Chance.</param>
		/// <typeparam name="T">The item type.</typeparam>
		void AddChanced<T>(float chance = 1) where T : IItem;

		/// <summary>
		/// Adds guaranteed drops if this is an immature growable entity.
		/// </summary>
		/// <param name="quantity">Quantity.</param>
		/// <typeparam name="T">The item type.</typeparam>
		void AddImmature<T>(int quantity = 1) where T : IItem;

		/// <summary>
		/// Add a loot item with given drop chance.
		/// 
		/// Note: currently does not support quantities.
		/// </summary>
		/// <param name="weight">Weight.</param>
		/// <typeparam name="T">The item type.</typeparam>
		void AddWeighted<T>(int weight) where T : IItem;

		/// <summary>
		/// Get drops. Will give priority to any non-weighted loot.
		/// If none exists, a weighted loot item will be returned.
		/// </summary>
		/// <returns>The drops.</returns>
		List<IItem> Drops();
	}
}
