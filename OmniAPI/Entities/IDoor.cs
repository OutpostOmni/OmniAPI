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
using OmniAPI.Services.Event;
using OmniAPI.World;

namespace OmniAPI.Entities {
    /// <summary>
    /// Represents entities placed by a player or a non-decoration process.
    /// </summary>
    public interface IDoor : IInteractable, INeighborConnector, IPlacedEntity, IReturnable {
        /// <summary>
        /// Check if this door is currently open.
        /// 
        /// If set without using the Open/Close methods, the animation will be skipped.
        /// </summary>
        /// <value><c>true</c> if is open; otherwise, <c>false</c>.</value>
        bool IsOpen { get; set; }

        /// <summary>
        /// Closes this door.
        /// </summary>
        void Close();

        /// <summary>
        /// Opens this door.
        /// </summary>
        void Open();
    }
}
