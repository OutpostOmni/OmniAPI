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
using OmniAPI.Services.Resource;
using OmniAPI.Services.Save;

namespace OmniAPI.Components {
	/// <summary>
	/// Represents a volume of a named resource.
	/// </summary>
    public interface IVolumeComponent : IComponent, IPersistanceTarget {
		/// <summary>
		/// Gets or sets the capacity.
		/// </summary>
		/// <value>The capacity.</value>
		float Capacity { get; set; }

		/// <summary>
		/// Gets a value indicating whether this volume is full.
		/// </summary>
		/// <value><c>true</c> if this volume is full; otherwise, <c>false</c>.</value>
		bool IsFull { get; }

		/// <summary>
		/// Gets or sets the max rate per second.
		/// </summary>
		/// <value>The max rate per second.</value>
		float MaxRatePerSecond { get; set; }

		/// <summary>
		/// Gets or sets the resource.
		/// </summary>
		/// <value>The resource.</value>
		IResource Resource { get; set; }

		/// <summary>
		/// Gets the volume.
		/// </summary>
		/// <value>The volume.</value>
		float Volume { get; }

		/// <summary>
		/// Drain the amount or as much up to the amount is available.
		/// </summary>
		/// <param name="amountRequested">Amount requested.</param>
		float Drain(float amountRequested);

		/// <summary>
		/// Fill the volume with the given amount of the resource.
		/// </summary>
		/// <param name="amount">Amount.</param>
		void Fill(float amount);
	}
}
