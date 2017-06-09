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
using OmniAPI.Services.Save;
using System.Collections.Generic;
using UnityEngine;

namespace OmniAPI.Components {
	/// <summary>
	/// Represents an entity which displays items, but is not considered a container.
	/// 
	/// For example, a berry bush entity may hold berry items which are seen in-game.
	/// </summary>
    public interface IItemDisplayComponent : IComponent, IPersistanceTarget {
		/// <summary>
		/// Add the item for display at the given pos.
		/// </summary>
		/// <param name="item">The item.</param>
		/// <param name="pos">The position.</param>
		void Add(Item item, Vector3 pos);

		/// <summary>
		/// Clear all displayed items.
		/// </summary>
		void Clear();

		/// <summary>
		/// Get the list of currently displayed items.
		/// </summary>
		/// <returns>The list.</returns>
		List<Item> Get();
	}
}
