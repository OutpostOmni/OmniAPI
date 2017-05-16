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
using OmniAPI.Services.Mod;
using OmniAPI.Util;
using System;
using UnityEngine;

namespace OmniAPI.Catalogues {
	/// <summary>
	/// Item catalogue.
	/// </summary>
    public interface IItemCatalogue : ICatalogue {
		/// <summary>
		/// Finds an item by the identifier.
		/// </summary>
		/// <returns>The item, if any.</returns>
		/// <param name="id">Identifier.</param>
		Optional<IItem> FindById(string id);

		/// <summary>
		/// Gets the sprite registered for a specific Item.
		/// </summary>
		/// <returns>The sprite.</returns>
		/// <param name="item">Item.</param>
		Sprite GetSprite(Item item);

		/// <summary>
		/// Register an asset for the given item ID. At this time only Sprites are supported.
		/// </summary>
		/// <returns>The register.</returns>
		/// <param name="owner">Owner.</param>
		/// <param name="id">Identifier.</param>
		/// <param name="assetName">Sprite asset name.</param>
		void RegisterAsset(Mod owner, string id, string assetName);

		/// <summary>
		/// Register an item type and a reference interface.
		/// </summary>
		/// <param name="t">Type of the item class.</param>
		/// <typeparam name="T">The representative interface</typeparam>
		void RegisterItem<T>(Type t) where T : IItem;
	}
}
