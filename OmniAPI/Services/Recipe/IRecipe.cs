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

namespace OmniAPI.Services.Recipe {
	/// <summary>
	/// Represents an item recipe.
	/// </summary>
	public interface IRecipe {
		/// <summary>
		/// Get a unique ID for this recipe.
		/// </summary>
		/// <value>The identifier.</value>
		string Id { get; }

		/// <summary>
		/// Can the player construct this recipe.
		/// </summary>
		/// <returns><c>true</c>, if constructable, <c>false</c> otherwise.</returns>
        bool CanConstruct(IContainerComponent[] sourceContainers);

		/// <summary>
		/// Construct the product.
		/// </summary>
		/// <returns>The product.</returns>
        Optional<Item> Construct(IContainerComponent[] sourceContainers);

        /// <summary>
        /// Counts the max constructable.
        /// </summary>
        /// <returns>The max constructable.</returns>
        /// <param name="sourceContainers">Source containers.</param>
        int CountMaxConstructable(IContainerComponent[] sourceContainers);

		/// <summary>
		/// Get the energy cost to construct this product.
		/// </summary>
		/// <returns>The energy cost.</returns>
		float EnergyCost();

		/// <summary>
		/// Get all ingredients.
		/// </summary>
		/// <returns>The ingredients.</returns>
        Item[] Ingredients();

		/// <summary>
		/// Get a dummy instance of the product.
		/// </summary>
		/// <returns>The product.</returns>
        Item Product();
	}
}
