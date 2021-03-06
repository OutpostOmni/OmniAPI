﻿/**
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
using OmniAPI.Services.Mod;
using OmniAPI.Util;
using UnityEngine;

namespace OmniAPI.Catalogues {
	/// <summary>
	/// Entity catalogue.
	/// </summary>
    public interface IEntityCatalogue : ICatalogue {
        /// <summary>
        /// Get an entity asset by ID.
        /// </summary>
        /// <returns>The entity, if any.</returns>
        /// <param name="id">Identifier.</param>
        Optional<GameObject> Get(string id);

        /// <summary>
        /// Get an entity asset by the ID and variant ID.
        /// </summary>
        /// <returns>The get.</returns>
        /// <param name="id">Identifier.</param>
        /// <param name="variantId">Variant identifier.</param>
        Optional<GameObject> Get(string id, byte variantId);

		/// <summary>
		/// Register a prefab asset with the given ID. At this time only Prefabs are supported.
		/// </summary>
		/// <returns>The GameObject prefab.</returns>
		/// <param name="owner">Owner.</param>
		/// <param name="id">Identifier.</param>
		/// <param name="assetName">Prefab asset name.</param>
		GameObject RegisterAsset(IMod owner, string id, string assetName);
	}
}
