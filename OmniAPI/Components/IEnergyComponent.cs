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
namespace OmniAPI {
	/// <summary>
	/// Represents an energy component. Its assumed this component cannot accept new energy
	/// post-instantiation, leaving those duties to IRechargeableEnergyComponents.
	/// </summary>
	public interface IEnergyComponent : IComponent {
		/// <summary>
		/// The charge percentage.
		/// </summary>
		/// <returns>The charge percent.</returns>
		float ChargePercent();

		/// <summary>
		/// Draw charge limited by the specified max (and any internal maximums).
		/// </summary>
		/// <returns>The draw charge.</returns>
		/// <param name="max">Max.</param>
		float Draw(float max);

		/// <summary>
		/// Get how much of the max capacity is empty.
		/// </summary>
		/// <returns>The empty capacity.</returns>
		float EmptyCapacity();

		/// <summary>
		/// Get if any charge exists.
		/// </summary>
		/// <returns><c>true</c>, if charge exists, <c>false</c> otherwise.</returns>
		bool HasCharge();

		/// <summary>
		/// Get if there's at least x units of charge.
		/// </summary>
		/// <returns><c>true</c>, if charge exists, <c>false</c> otherwise.</returns>
		/// <param name="units">Units.</param>
		bool HasCharge(float units);

		/// <summary>
		/// Get if the charge is at max capacity.
		/// </summary>
		/// <returns><c>true</c>, if full, <c>false</c> otherwise.</returns>
		bool IsFull();
	}
}
