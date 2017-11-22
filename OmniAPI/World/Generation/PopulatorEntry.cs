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
namespace OmniAPI.World.Generation {
    /// <summary>
    /// Contains entity/item metadata in a populator catalogue.
    /// </summary>
    public class PopulatorEntry {
        /// <summary>
        /// The entity identifier.
        /// </summary>
        public readonly string EntityId;

        /// <summary>
        /// The entity's item identifier, if entity can exist as an item.
        /// </summary>
        public readonly string ItemId;

        /// <summary>
        /// The variant identifier.
        /// </summary>
        public readonly byte VariantId;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:OmniAPI.World.Generation.PopulatorEntry"/> class.
        /// </summary>
        /// <param name="EntityId">Entity identifier.</param>
        /// <param name="VariantId">Variant identifier.</param>
        public PopulatorEntry(string EntityId, byte VariantId) : this(EntityId, null, VariantId) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="T:OmniAPI.World.Generation.PopulatorEntry"/> class.
        /// </summary>
        /// <param name="EntityId">Entity identifier.</param>
        /// <param name="ItemId">Item identifier.</param>
        /// <param name="VariantId">Variant identifier.</param>
        public PopulatorEntry(string EntityId, string ItemId, byte VariantId) {
            this.EntityId = EntityId;
            this.ItemId = ItemId;
            this.VariantId = VariantId;
        }

        /// <summary>
        /// Export the entry as a population queue entry.
        /// </summary>
        /// <returns>The population queue entry.</returns>
        public EntityPopulationQueueEntry ToPopulationQueueEntry() {
            return new EntityPopulationQueueEntry(this.EntityId, this.VariantId);
        }
    }
}
