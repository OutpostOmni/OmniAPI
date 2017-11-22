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
using OmniAPI.Util;
using System.Collections.Generic;

namespace OmniAPI.World.Generation {
    /// <summary>
    /// Simple wrapper for a fixed-size array which maps coordinate indices
    /// to lists of entities queued for population.
    /// </summary>
    public class ChunkPopulation {
        public readonly List<EntityPopulationQueueEntry>[] Entities;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:OmniAPI.World.Generation.ChunkPopulation"/> class.
        /// </summary>
        /// <param name="coordSize">Coordinate size.</param>
        public ChunkPopulation(int coordSize) {
            Entities = new List<EntityPopulationQueueEntry>[coordSize];
        }

        /// <summary>
        /// Add the specified index and entity entry.
        /// </summary>
        /// <returns>The add.</returns>
        /// <param name="index">Index.</param>
        /// <param name="entry">Entity population entry.</param>
        public void Add(int index, EntityPopulationQueueEntry entry) {
            if (Entities[index] == null) {
                Entities[index] = new List<EntityPopulationQueueEntry>();
            }

            Entities[index].Add(entry);
        }

        /// <summary>
        /// Clear the specified index.
        /// </summary>
        /// <returns>The clear.</returns>
        /// <param name="index">Index.</param>
        public void Clear(int index) {
            Entities[index] = null;
        }

        /// <summary>
        /// Checks if an index has any entities already.
        /// </summary>
        /// <returns><c>true</c>, if entities exist, <c>false</c> otherwise.</returns>
        /// <param name="index">Index.</param>
        public bool HasEntities(int index) {
            return !(Entities[index] == null || Entities[index].Count == 0);
        }
    }
}
