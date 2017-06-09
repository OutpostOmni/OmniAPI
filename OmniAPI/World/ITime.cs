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
using OmniAPI.Services.Save;

namespace OmniAPI.World {
	/// <summary>
	/// Represents the current time within a game world.
	/// </summary>
    public interface ITime : IPersistanceTarget {
		/// <summary>
		/// Gets or sets the current time.
		/// </summary>
		/// <value>The current time.</value>
		int CurrentTime { get; set; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="T:OmniAPI.World.ITime"/> is day.
        /// </summary>
        /// <value><c>true</c> if is day; otherwise, <c>false</c>.</value>
        bool IsDay { get; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="T:OmniAPI.World.ITime"/> is evening.
        /// </summary>
        /// <value><c>true</c> if is evening; otherwise, <c>false</c>.</value>
        bool IsEvening { get; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="T:OmniAPI.World.ITime"/> is morning.
        /// </summary>
        /// <value><c>true</c> if is morning; otherwise, <c>false</c>.</value>
        bool IsMorning { get; }

        /// <summary>
        /// Gets a value indicating whether this <see cref="T:OmniAPI.World.ITime"/> is night.
        /// </summary>
        /// <value><c>true</c> if is night; otherwise, <c>false</c>.</value>
        bool IsNight { get; }

		/// <summary>
		/// Gets the sun intensity.
		/// </summary>
		/// <returns>The sun intensity.</returns>
        float GetSunIntensity();
	}
}
