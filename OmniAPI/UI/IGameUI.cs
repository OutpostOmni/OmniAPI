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
using OmniAPI.Players;
using OmniAPI.Rendering;
using OmniAPI.Util;
using UnityEngine;

namespace OmniAPI.UI {
    public interface IGameUI {
        /// <summary>
        /// Get the hotbar inventory UI.
        /// </summary>
        /// <value>The hotbar.</value>
        IInventoryUI Hotbar { get; }

        /// <summary>
        /// Clears any and all active modals.
        /// </summary>
        void ClearModals();

		/// <summary>
		/// Gets the next modal, if any.
		/// </summary>
		/// <returns>The next modal.</returns>
		Optional<GameObject> GetNextModal(GameObject basis);

		/// <summary>
		/// Gets the opposite modal. For dual modals, like when the player's inventory is open
		/// along with a container, this gets the opposite modal for easy communication.
		/// </summary>
		/// <returns>The opposite modal.</returns>
		/// <param name="basis">Basis.</param>
		Optional<GameObject> GetOppositeModal(GameObject basis);

		/// <summary>
		/// Gets the previous modal, if any.
		/// </summary>
		/// <returns>The previous modal.</returns>
		Optional<GameObject> GetPreviousModal(GameObject basis);

        /// <summary>
        /// Check if there's at least one active modal.
        /// </summary>
        /// <returns><c>true</c>, if active modal was hased, <c>false</c> otherwise.</returns>
        bool HasActiveModal();

        /// <summary>
        /// Hides any currently-open item popup.
        /// </summary>
        void HideItemTooltip();

        /// <summary>
        /// Show an inventory with a custom parent prefab. Is not counted as a modal.
        /// </summary>
        /// <returns>The inventory.</returns>
        /// <param name="prefab">Prefab.</param>
        /// <param name="renderer">Renderer.</param>
        GameObject ShowInventory(GameObject prefab, IInventoryRenderer renderer);

        /// <summary>
        /// Shows an inventory modal.
        /// </summary>
        /// <param name="renderer">Renderer.</param>
        GameObject ShowInventoryModal(IInventoryRenderer renderer);

        /// <summary>
        /// Shows an inventory modal.
        /// </summary>
        /// <returns>The inventory modal.</returns>
        /// <param name="prefab">Prefab.</param>
        /// <param name="renderer">Renderer.</param>
        GameObject ShowInventoryModal(GameObject prefab, IInventoryRenderer renderer);

        /// <summary>
        /// Shows an item tooltip.
        /// </summary>
        /// <param name="item">Item.</param>
        /// <param name="pos">Position.</param>
        void ShowItemTooltip(IItem item, Vector2 pos);

        /// <summary>
        /// Show a modal.
        /// </summary>
        /// <returns>The modal object.</returns>
		/// <param name="modalGameObject">Modal GameObject.</param>
		GameObject ShowModal(GameObject modalGameObject);

		/// <summary>
		/// Shows a modal prefab.
		/// </summary>
		/// <returns>The modal game object.</returns>
		/// <param name="prefab">Prefab.</param>
		GameObject ShowModalPrefab(GameObject prefab);

        /// <summary>
        /// Shows or hides the modal header.
        /// </summary>
        /// <param name="tab">Image index of tab</param>
		/// <remarks>DEPRACATED. The index system is not final.</remarks>
        void ShowOrHideModalHeader(int tab);

        /// <summary>
        /// Shows the player construction modal.
        /// </summary>
        /// <param name="player">Player.</param>
        void ShowPlayerConstructionModal(IPlayer player);

        /// <summary>
        /// Opens the player element inventory.
        /// </summary>
        /// <param name="player">Player.</param>
        void ShowPlayerElementInventory(IPlayer player);

        /// <summary>
        /// Opens the player inventory.
        /// </summary>
        /// <param name="player">Player.</param>
        void ShowPlayerInventory(IPlayer player);
    }
}
