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
namespace OmniAPI.Components {
    public interface IShieldComponent : IComponent {
		/// <summary>
		/// Gets the energy cost per second.
		/// 
		/// This represents the energy cost for max protection per second. This is applied
		/// separately to each form of protection.
		/// 
		/// The true cost of energy is calculated by using the percent shielded, so if the 
		/// max temp protection is 150, and the temp is 75, the temperature protection costs 50%.
		/// 
		/// If the temperature exceeds the protection level, the energy cost increases.
		/// If the max temp protection is 150, but the temp is 200, the energy cost is 133%.
		/// </summary>
		/// <value>The energy cost per second.</value>
		float EnergyCostPerSecond { get; }

		/// <summary>
		/// Gets the max temperature protection.
		/// </summary>
		/// <value>The max temperature protection.</value>
		float MaxTemperatureProtection { get; }

		/// <summary>
		/// Gets the max toxicity protection.
		/// </summary>
		/// <value>The max toxicity protection.</value>
		float MaxToxicityProtection { get; }
	}
}
