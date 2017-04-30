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
using OmniAPI.Services;
using System;

namespace OmniAPI {
	/// <summary>
	/// Describes the game manager.
	/// The game manager is the central authority for all game-related objects and components.
	/// </summary>
	public interface IGameManager {
		/// <summary>
		/// Get a native game component by its interface.
		/// </summary>
		/// <returns>The component type.</returns>
		/// <typeparam name="T">The component type parameter.</typeparam>
		Type ComponentFor<T>();

		/// <summary>
		/// Gets the entity manager.
		/// </summary>
		/// <returns>The entity manager.</returns>
		IEntityManager GetEntityManager();

		/// <summary>
		/// Gets the event manager.
		/// </summary>
		/// <returns>The event manager.</returns>
		IEventManager GetEventManager();

		/// <summary>
		/// Get the factory for the specified type.
		/// </summary>
		/// <returns>The factory.</returns>
		/// <typeparam name="T">The factory type.</typeparam>
		T GetFactory<T>() where T : IFactory;

		/// <summary>
		/// Gets the item manager.
		/// </summary>
		/// <returns>The item manager.</returns>
		IItemManager GetItemManager();

		/// <summary>
		/// Gets the mission manager.
		/// </summary>
		/// <returns>The mission manager.</returns>
		IMissionManager GetMissionManager();

		/// <summary>
		/// Get a list of players.
		/// </summary>
		/// <returns>The players.</returns>
		IPlayer[] GetPlayers();

		/// <summary>
		/// Gets the recipe manager.
		/// </summary>
		/// <returns>The recipe manager.</returns>
		IRecipeManager GetRecipeManager();

        /// <summary>
        /// Get a service.
        /// </summary>
        /// <returns>The optional service.</returns>
        /// <typeparam name="T">The service type.</typeparam>
        Optional<T> GetService<T>() where T : IService;

		/// <summary>
		/// Gets the story manager.
		/// </summary>
		/// <returns>The story manager.</returns>
		IStoryManager GetStoryManager();

		/// <summary>
		/// Gets the game world.
		/// </summary>
		/// <returns>The world.</returns>
		IWorld GetWorld();

        /// <summary>
        /// Register a service.
        /// </summary>
        /// <param name="service">Service.</param>
        void RegisterService(IService service);
	}
}
