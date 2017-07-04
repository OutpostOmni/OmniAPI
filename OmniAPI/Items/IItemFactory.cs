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
using OmniAPI.Services;
using System;

namespace OmniAPI.Items {
    /// <summary>
    /// Item factory.
    /// </summary>
	public interface IItemFactory : IFactory {
		/// <summary>
		/// Create an item registered to the provided type, with the specified quantity.
		/// </summary>
		/// <returns>The item.</returns>
		/// <param name="quantity">The desired quantity.</param>
		/// <typeparam name="T">The item type</typeparam>
		Item Create<T>(int quantity = 1) where T : IItem;

        /// <summary>
        /// Create the specified item by its ID.
        /// </summary>
        /// <returns>The create.</returns>
        /// <param name="itemId">Item identifier.</param>
        /// <param name="quantity">Quantity.</param>
        Item Create(string itemId, int quantity = 1);

        /// <summary>
        /// Create the specified item and quantity.
        /// </summary>
        /// <returns>The item.</returns>
        /// <param name="type">Type.</param>
        /// <param name="quantity">Quantity.</param>
        Item Create(Type type, int quantity = 1);
	}
}
