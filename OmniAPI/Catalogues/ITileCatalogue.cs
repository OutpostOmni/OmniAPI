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
using OmniAPI.World.Tiles;
using OmniAPI.Util;
using UnityEngine;

namespace OmniAPI.Catalogues {
    /// <summary>
    /// Tile catalogue.
    /// </summary>
    public interface ITileCatalogue : ICatalogue {
        /// <summary>
        /// Get a tile prefab by ID.
        /// </summary>
        /// <returns>The prefab, if any.</returns>
        /// <param name="id">Identifier.</param>
        Optional<GameObject> Get(string id);

        /// <summary>
        /// Get a tile prefab by id and variant.
        /// </summary>
        /// <returns>The prefab, if any.</returns>
        /// <param name="id">Identifier.</param>
        /// <param name="variantId">Variant identifier.</param>
        Optional<GameObject> Get(string id, byte variantId);

        /// <summary>
        /// Get a tile prefab by id and variant
        /// </summary>
        /// <returns>The prefab, if any.</returns>
        /// <param name="">.</param>
        Optional<GameObject> Get(Tuple<string, byte> tuple);

        /// <summary>
        /// Get a tile catalogue entry by an id/variant tuple
        /// </summary>
        /// <returns>The prefab, if any.</returns>
        /// <param name="">.</param>
        Optional<ITileCatalogueEntry> GetEntry(Tuple<string, byte> tuple);
    }
}
