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
using OmniAPI.Util;

namespace OmniAPI.Components {
	/// <summary>
	/// Describes a container, which holds Items.
	/// </summary>
	public interface IContainerComponent : IComponent {
        /// <summary>
        /// Gets or sets the number of slots.
        /// </summary>
        /// <value>The slots.</value>
        int Slots { get; set; }

		/// <summary>
		/// Add an item to this container.
		/// </summary>
		/// <returns>The slot index this item was placed in.</returns>
		/// <param name="item">Item.</param>
		int Add(Item item);

        /// <summary>
        /// Count total quantity of a given item.
        /// </summary>
        /// <returns>The count.</returns>
        /// <param name="item">Item.</param>
        int Count(Item item);

        /// <summary>
        /// Returns the index of the first empty slot.
        /// </summary>
        /// <returns>The index.</returns>
        int FirstEmpty();

        /// <summary>
        /// Get any item in the given slot.
        /// </summary>
        /// <returns>The get.</returns>
        /// <param name="slot">Slot.</param>
        Optional<IItem> Get(int slot);

		/// <summary>
		/// Has at least one of the specified item.
		/// </summary>
		/// <returns>If this container has the item.</returns>
		/// <param name="item">Item.</param>
		bool Has(Item item);

		/// <summary>
		/// Has at least x quantity of the specified item.
		/// </summary>
		/// <returns>If this container has enough of the item.</returns>
		/// <param name="item">Item.</param>
		bool Has(Item item, int quantity);

		/// <summary>
		/// Has at least one of the specified item id.
		/// </summary>
		/// <returns>The has.</returns>
		/// <param name="itemId">Item identifier.</param>
		bool Has(string itemId);

        /// <summary>
        /// Remove any item in a given slot.
        /// </summary>
        /// <returns>The item, if any.</returns>
        /// <param name="slot">Slot.</param>
        Optional<IItem> Remove(int slot);

        /// <summary>
        /// Remove the specified quantity of item. If the user doesn't have enough,
        /// none are removed.
        /// </summary>
        /// <returns>Whether enough items were removed.</returns>
        /// <param name="item">Item.</param>
        /// <param name="minQuantity">Quantity.</param>
        bool RemoveAtLeast(Item item, int minQuantity = 1);

        /// <summary>
        /// Place an item at the specified slot.
        /// </summary>
        /// <returns>The set.</returns>
        /// <param name="slot">Slot.</param>
        /// <param name="item">Item.</param>
        void Set(int slot, IItem item);
	}
}
