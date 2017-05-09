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
using System;
using UnityEngine;

namespace OmniAPI.Rendering {
    /// <summary>
    /// Inventory renderer builder.
    /// </summary>
    public interface IInventoryRendererBuilder {
        /// <summary>
        /// Build this instance.
        /// </summary>
        /// <returns>The inventory renderer.</returns>
        IInventoryRenderer Build();

        /// <summary>
        /// Add a custom slot execution handler.
        /// </summary>
        /// <returns>The builder.</returns>
        /// <param name="cb">Execution interaction handler.</param>
        IInventoryRendererBuilder OnSlotExecute(Action<int> cb);

        /// <summary>
        /// Allow or disallow item hover menus.
        /// </summary>
        /// <returns>The builder.</returns>
        /// <param name="allow">If set to <c>true</c> allow.</param>
        IInventoryRendererBuilder SetAllowHoverMenu(bool allow);

		/// <summary>
		/// Sets the allow slot execution.
		/// </summary>
		/// <returns>The allow slot execution.</returns>
		/// <param name="allow">If set to <c>true</c> allow.</param>
		IInventoryRendererBuilder SetAllowSlotExecution(bool allow);

		/// <summary>
		/// Sets the allow resize.
		/// </summary>
		/// <returns>The allow resize.</returns>
		/// <param name="allow">If set to <c>true</c> allow.</param>
		IInventoryRendererBuilder SetAllowResize(bool allow);

        /// <summary>
        /// Sets the source container.
        /// </summary>
        /// <returns>The builder.</returns>
        /// <param name="container">Container.</param>
        IInventoryRendererBuilder SetContainer(IContainerComponent container);

		/// <summary>
		/// Sets the button press handler.
		/// </summary>
		/// <returns>Sets the button press handler.</returns>
		/// <param name="cb">Cb.</param>
		IInventoryRendererBuilder SetOnButtonPress(Func<int, bool> cb);

		/// <summary>
		/// Sets a callback which determines if a given slow is interactable.
		/// </summary>
		/// <returns>The builder.</returns>
		/// <param name="cb">Callback</param>
		IInventoryRendererBuilder SetIsSlotInteractable(Func<int, bool> cb);

		/// <summary>
		/// Sets the padding.
		/// </summary>
		/// <returns>The padding.</returns>
		/// <param name="padding">Padding.</param>
		IInventoryRendererBuilder SetPadding(Vector4 padding);

		/// <summary>
		/// Set whether to render the slot background sprites.
		/// </summary>
		/// <returns>The builder.</returns>
		/// <param name="render">If set to <c>true</c> render.</param>
		IInventoryRendererBuilder SetRenderSlotBackgrounds(bool render);

		/// <summary>
		/// Sets the slot limit. Defaults to -1, which shows all container slots.
		/// </summary>
		/// <returns>The builder.</returns>
		/// <param name="limit">Limit.</param>
		IInventoryRendererBuilder SetSlotLimit(int limit);

		/// <summary>
		/// Sets custom slot positions.
		/// </summary>
		/// <returns>The slot positions.</returns>
		/// <param name="positions">Positions.</param>
		IInventoryRendererBuilder SetSlotPositions(Vector2[] positions);
    }
}
