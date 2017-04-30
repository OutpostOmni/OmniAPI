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
namespace OmniAPI.Economy {
    public interface IMerchandiseBuilder : IBuilder {
        /// <summary>
        /// Build the final merchandise object.
        /// </summary>
        Merchandise Build();

        /// <summary>
        /// Sets the cost.
        /// </summary>
        /// <returns>The merchandise builder.</returns>
        /// <param name="cost">The cost.</param>
        IMerchandiseBuilder SetCost(float cost);

        /// <summary>
        /// Set the merchandise item.
        /// </summary>
        /// <returns>The merchandise builder.</returns>
        /// <typeparam name="T">The item type parameter.</typeparam>
        IMerchandiseBuilder SetItem<T>() where T : IItem;

        /// <summary>
        /// Sets the quantity.
        /// </summary>
        /// <returns>The merchandise builder.</returns>
        /// <param name="quantity">Quantity.</param>
        IMerchandiseBuilder SetQuantity(int quantity);
    }
}
