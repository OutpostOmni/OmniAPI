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
using OmniAPI.Util;
using System.Collections.Generic;

namespace OmniAPI.Services.Recipe {
	/// <summary>
	/// Represents the item recipe manager.
	/// </summary>
    public interface IRecipeService : IService {
		/// <summary>
		/// Get all recipes.
		/// </summary>
		/// <returns>All recipes.</returns>
		List<IRecipe> All();

		/// <summary>
		/// Gets a blueprint holding the recipe for the given item.
		/// </summary>
		/// <returns>The blueprint, if recipe found.</returns>
		/// <param name="item">Item.</param>
		Optional<IBlueprint> BlueprintFor(Item item);

		/// <summary>
		/// Factory which creates a new recipe for the given product.
		/// </summary>
		/// <returns>The recipe.</returns>
		/// <param name="product">The product.</param>
		/// <param name="ingredients">Any ingredients.</param>
		IRecipe Create(Item product, params Item[] ingredients);

		/// <summary>
		/// Lookup a recipe for the given item.
		/// </summary>
		/// <returns>The recipe.</returns>
		/// <param name="item">Item.</param>
		IRecipe RecipeFor(Item item);

		/// <summary>
		/// Register a recipe.
		/// </summary>
		/// <param name="recipe">The recipe.</param>
		void Register(IRecipe recipe);

		/// <summary>
		/// Register a recipe, player immediately "learns" it.
		/// </summary>
		/// <param name="recipe">Recipe.</param>
		/// <param name="player">Player.</param>
		void RegisterAndLearn(IRecipe recipe, IPlayer player);
	}
}
