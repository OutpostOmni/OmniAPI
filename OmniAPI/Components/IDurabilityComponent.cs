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
using UnityEngine;

namespace OmniAPI.Components {
	/// <summary>
	/// Represents a component which gives an entity a durability.
	/// </summary>
    public interface IDurabilityComponent : IComponent, IPersistanceTarget {
		/// <summary>
		/// Gets or sets the color of the break particles.
		/// </summary>
		/// <value>The color of the break particles.</value>
		Color BreakParticleColor { get; set; }

        /// <summary>
        /// Gets or sets the cold damage.
        /// </summary>
        /// <value>The cold damage.</value>
        float ColdDamage { get; set; }

        /// <summary>
        /// Gets or sets generic damage.
        /// </summary>
        /// <value>The damage.</value>
        float Damage { get; set; }

        /// <summary>
        /// Gets or sets the heat damage.
        /// </summary>
        /// <value>The heat damage.</value>
        float HeatDamage { get; set; }

		/// <summary>
		/// Gets the total damage.
		/// </summary>
		/// <value>The damage.</value>
		float TotalDamage { get; }

        /// <summary>
        /// Gets or sets the toxin damage.
        /// </summary>
        /// <value>The toxin damage.</value>
        float ToxinDamage { get; set; }

		/// <summary>
		/// Gets or sets the durability.
		/// </summary>
		/// <value>The durability.</value>
		int Durability { get; set; }
	}
}
