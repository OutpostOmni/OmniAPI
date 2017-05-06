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

namespace OmniAPI.Services.Economy {
    /// <summary>
    /// Represents merchandise - an item with an associated currency value.
    /// </summary>
    public class Merchandise {
        /// <summary>
        /// The item available for trade. The currently available quantity
        /// is maintained as the quantity field on this Item.
        /// </summary>
        public readonly Item Item;

        /// <summary>
        /// The cost paid *TO* someone selling this item to this merchant.
        /// </summary>
        public readonly float BuyCost;

        /// <summary>
        /// The price paid *BY* someone buying this item from this merchant.
        /// </summary>
        public readonly float SellCost;

        public Merchandise(Item item, float buyCost, float sellCost) {
            this.Item = item;
            this.BuyCost = buyCost;
            this.SellCost = sellCost;
        }
    }
}
