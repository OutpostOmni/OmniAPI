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
using OmniAPI.Entities.Living;
using OmniAPI.Services.Recipe;
using OmniAPI.Services.Save;

namespace OmniAPI.Players {
	/// <summary>
	/// Describes an individual player, a human-controller entity.
	/// </summary>
    public interface IPlayer : IIntelligentEntity, IPersistanceTarget {
		/// <summary>
		/// Gets the list of learned recipes.
		/// </summary>
		/// <value>The learned recipes.</value>
		string[] LearnedRecipes { get; }

        /// <summary>
        /// Gets the character inventory.
        /// </summary>
        /// <returns>The character inventory.</returns>
        ICharacterContainerComponent GetCharacterInventory();

        /// <summary>
        /// Get the player's element container.
        /// </summary>
        /// <returns>The container.</returns>
        IContainerComponent GetElementInventory();

		/// <summary>
		/// Get the player's primary container, a.k.a. their inventory.
		/// </summary>
		/// <returns>The container.</returns>
        IContainerComponent GetInventory();

		/// <summary>
		/// Determines whether this player has learned the given recipe.
		/// </summary>
		/// <returns><c>true</c> if player has learned the specified recipe; otherwise, <c>false</c>.</returns>
		/// <param name="recipe">Recipe.</param>
		bool HasLearned(IRecipe recipe);

		/// <summary>
		/// Learn a recipe.
		/// </summary>
        /// <param name="recipe">Recipe.</param>
		void LearnRecipe(IRecipe recipe);
	}
}
