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
using UnityEngine;

namespace OmniAPI.World.Generation.Features {
    /// <summary>
    /// Caches features/structures after their first generation for better performance.
    /// </summary>
    public class FeaturePattern {
        public readonly Dictionary<Vector2, Tuple<string, byte>> Tiles = new Dictionary<Vector2, Tuple<string, byte>>();
        public readonly Dictionary<Vector2, List<EntityPopulationQueueEntry>> Entities = new Dictionary<Vector2, List<EntityPopulationQueueEntry>>();

        /// <summary>
        /// Add multiple entities for a specific world coordinate.
        /// </summary>
        /// <param name="worldVec">World vec.</param>
        /// <param name="entityEntry">Entity entry.</param>
        public void AddEntity(Vector2 worldVec, EntityPopulationQueueEntry entityEntry) {
            List<EntityPopulationQueueEntry> entityList;

            if (!Entities.TryGetValue(worldVec, out entityList)) {
                entityList = new List<EntityPopulationQueueEntry>();
            }

            entityList.Add(entityEntry);

            Entities[worldVec] = entityList;
        }
    }
}
