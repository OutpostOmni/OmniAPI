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
using OmniAPI.Components;
using OmniAPI.Items;
using OmniAPI.Util;

namespace OmniAPI.Rendering {
    /// <summary>
    /// Represents a UI controller for an inventory.
    /// </summary>
	public interface IInventoryUI : IModalUI {
		/// <summary>
		/// Gets the container.
		/// </summary>
		/// <value>The container.</value>
		IContainerComponent Container { get; }

		/// <summary>
		/// Gets or sets a value indicating whether this UI has focus.
		/// 
		/// When focused, this UI will cause other UI to ignore input.
		/// </summary>
		/// <value><c>true</c> if this instance has focus; otherwise, <c>false</c>.</value>
		bool HasFocus { get; set; }

		/// <summary>
		/// Gets or sets the selected slot.
		/// </summary>
		/// <value>The selected slot.</value>
		int SelectedSlot { get; set; }

        /// <summary>
        /// Return the currently selected item, if any.
        /// </summary>
        /// <returns>The item.</returns>
        Optional<IItem> GetSelectedItem();
    }
}
