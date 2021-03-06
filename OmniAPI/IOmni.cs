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
using log4net;
using OmniAPI.Catalogues;
using OmniAPI.Game;
using OmniAPI.Services;
using OmniAPI.Util;

namespace OmniAPI {
    /// <summary>
    /// The primary application interface.
    /// </summary>
    public interface IOmni {
        /// <summary>
        /// Gets the game.
        /// If the game scene is not currently loaded, returns null.
        /// </summary>
        /// <value>The game.</value>
        IGame Game { get; }

        /// <summary>
        /// Gets the logger.
        /// </summary>
        /// <value>The logger.</value>
        ILog Logger { get; }

        /// <summary>
        /// Get an application-level catalogue, or a game-level catalogue if a game is loaded.
        /// </summary>
        /// <returns>The optional catalogue.</returns>
        /// <typeparam name="T">The catalogue type.</typeparam>
        Optional<T> GetCatalogue<T>() where T : ICatalogue;

        /// <summary>
        /// Get an application-level service, or a game-level service if a game is loaded.
        /// </summary>
        /// <returns>The optional service.</returns>
        /// <typeparam name="T">The service type.</typeparam>
        Optional<T> GetService<T>() where T : IService;

        /// <summary>
        /// Register a new catalogue.
        /// </summary>
        /// <param name="catalogue">Catalogue.</param>
        void RegisterCatalogue(ICatalogue catalogue);
    }
}
