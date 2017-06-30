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
using OmniAPI.Services.Messaging;
using OmniAPI.Services.Save;

namespace OmniAPI.Services.Story {
	/// <summary>
	/// Represents the story manager.
	/// </summary>
    public interface IStoryService : IService, IPersistanceTarget {
		/// <summary>
		/// Activate a story point. Will fail if a story point is already active.
		/// </summary>
        /// <param name="message">Story message.</param>
		void Activate(Message message);

        /// <summary>
        /// Activate the specified message after a delay.
        /// </summary>
        /// <returns>The activate.</returns>
        /// <param name="message">Message.</param>
        /// <param name="delay">Delay.</param>
        void Activate(Message message, float delay);

		/// <summary>
		/// Complete the specified point.
		/// </summary>
        /// <param name="message">Story Message.</param>
        void Complete(Message message);

		/// <summary>
		/// Register a story type for the given ID. 
		/// </summary>
        /// <param name="message">Story Message.</param>
        void Register(Message message);
	}
}
