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
using UnityEngine;

namespace OmniAPI.Services.Audio {
    /// <summary>
    /// Represents background in-world audio.
    /// </summary>
    public interface IAtmosphericAudio {
        /// <summary>
        /// Gets the audio source.
        /// </summary>
        /// <value>The audio source.</value>
        AudioSource AudioSource { get; }

        /// <summary>
        /// Gets the clip play mode.
        /// </summary>
        /// <value>The clip play mode.</value>
        ClipPlayMode ClipPlayMode { get; }

        /// <summary>
        /// Can the audio play now. Does not check if audio is already playing.
        /// </summary>
        /// <returns><c>true</c>, if audio may play now, <c>false</c> otherwise.</returns>
        bool CanPlayNow();
    }
}
