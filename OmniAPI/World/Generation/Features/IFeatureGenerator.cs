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
    /// Generate world feature.
    /// </summary>
    public interface IFeatureGenerator {
        /// <summary>
        /// Accept or reject the given basis coordinate.
        /// </summary>
        /// <param name="chunkProfile">Chunk Profile.</param>
        /// <param name="profile">Profile.</param>
        bool Accepts(ChunkProfile chunkProfile, CoordinateProfile profile);

        /// <summary>
        /// Generate this feature at the given coordinate.
        /// </summary>
        /// <param name="chunkProfile">Chunk Profile.</param>
        /// <param name="profile">Profile.</param>
        /// <param name="region">Region cache of chunk profiles.</param>
        FeaturePattern Generate(ChunkProfile chunkProfile, CoordinateProfile profile, IRegion region);
    }
}
