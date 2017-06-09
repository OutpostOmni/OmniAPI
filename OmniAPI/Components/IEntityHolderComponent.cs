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
using OmniAPI.Entities;
using OmniAPI.Items;
using OmniAPI.Services.Save;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace OmniAPI.Components {
    public interface IEntityHolderComponent : IComponent, IEntityHolder, IPersistanceTarget {
		/// <summary>
		/// Gets or sets the capacity of entities. No entities may be spawned if full.
		/// </summary>
		/// <value>The capacity.</value>
		int Capacity { get; set; }

		/// <summary>
		/// Set a callback for custom verification of an entity.
		/// </summary>
		Func<IPlaceableEntity, bool> VerifyEntity { get; set; }

		/// <summary>
		/// Adds a spawned entity instance.
		/// </summary>
        /// <param name="entity">Entity.</param>
		void AddEntity(IEntity entity);

		/// <summary>
		/// Breaks the entity and returns any drops.
		/// </summary>
		/// <returns>The entity.</returns>
		/// <param name="Entity">Entity.</param>
        List<IItem> BreakEntity(IEntity Entity);

		/// <summary>
		/// Gets the entities.
		/// </summary>
		/// <returns>The entities.</returns>
        IEntity[] GetEntities();

		/// <summary>
		/// Determines whether this holder has an entity.
		/// </summary>
		/// <returns><c>true</c> if this holder has an entity; otherwise, <c>false</c>.</returns>
		bool HasEntity();

		/// <summary>
		/// Determines whether this holder is full.
		/// </summary>
		/// <returns><c>true</c> if this golder is full; otherwise, <c>false</c>.</returns>
		bool IsFull();
	}
}
