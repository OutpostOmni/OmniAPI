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
    /// Describes everything necessary to render an inventory panel. 
    /// </summary>
    public interface IInventoryRenderer {
		/// <summary>
		/// Gets a value indicating whether this <see cref="OmniAPI.Rendering.IInventoryRenderer"/> allow slot execution.
		/// </summary>
		/// <value><c>true</c> if allow slot execution; otherwise, <c>false</c>.</value>
		bool AllowSlotExecution { get; }

		/// <summary>
		/// Gets a value indicating whether this <see cref="OmniAPI.Rendering.IInventoryRenderer"/> allows resize.
		/// </summary>
		/// <value><c>true</c> if allow resize; otherwise, <c>false</c>.</value>
		bool AllowResize { get; }

        /// <summary>
        /// Gets the container.
        /// </summary>
        /// <value>The container.</value>
        IContainerComponent Container { get; }

		/// <summary>
		/// Custom handling of a button press. Return false if the handler did not cover the buttons pressed.
		/// </summary>
		/// <value>The button press handler.</value>
		Func<int, bool> OnButtonPress { get; }

        /// <summary>
        /// Optional custom execution logic for slot interaction.
        /// </summary>
        /// <value>The execution callback.</value>
        Action<int> HandleExecuteOnSlot { get; }

		/// <summary>
		/// Determines whether a slot is interactable.
		/// </summary>
		/// <returns><c>true</c> if slot is interactable; otherwise, <c>false</c>.</returns>
		Func<int, bool> IsSlotInteractable { get; }

        /// <summary>
        /// Get the slot click callback.
        /// </summary>
        /// <value>The on slot click.</value>
        Action<int> OnSlotClick { get; }

        /// <summary>
        /// Gets the on slot selection change.
        /// </summary>
        /// <value>The on slot selection change.</value>
        Action<int> OnSlotSelectionChange { get; }

		/// <summary>
		/// Set the spacing around the background image. Used only if calculating slot positions.
		/// </summary>
		/// <value>The padding.</value>
		Vector4 Padding { get; }

		/// <summary>
		/// Gets a value indicating whether this <see cref="OmniAPI.Rendering.IInventoryRenderer"/> render slot backgrounds.
		/// </summary>
		/// <value><c>true</c> if render slot backgrounds; otherwise, <c>false</c>.</value>
		bool RenderSlotBackgrounds { get; }

        /// <summary>
        /// Gets the length of the row.
        /// </summary>
        /// <value>The length of the row.</value>
        int RowLength { get; }

        /// <summary>
        /// Whether to allow item hover menus.
        /// </summary>
        /// <value><c>true</c> if show hover menus; otherwise, <c>false</c>.</value>
        bool ShowHoverMenus { get; }

        /// <summary>
        /// Whether to show the modal header.
        /// </summary>
        bool ShowModalHeader { get; }

		/// <summary>
		/// Limit rendered slot count. For example the Hotbar only renders 9 slots but the player in might be larger.
		/// </summary>
		/// <value>The slot limit.</value>
		int SlotLimit { get; }

		/// <summary>
		/// Sets custom slot positions. Must contain an equal number of entries as container slots.
		/// </summary>
		/// <value>The slot positions.</value>
		Vector2[] SlotPositions { get; }
    }
}
