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
using OmniAPI.Util;

namespace OmniAPI.Components {
    /// <summary>
    /// Represents a character's container, holding 
    /// wearable items, components, and upgrades.
    /// </summary>
    public interface ICharacterContainerComponent : IContainerComponent {
        /// <summary>
        /// Gets the energy core, if any.
        /// </summary>
        /// <returns>The energy core.</returns>
        Optional<IEnergyCore> GetEnergyCore();

        /// <summary>
        /// Gets the current shield item, if any.
        /// </summary>
        /// <returns>The shield.</returns>
        Optional<IShield> GetShield();

        /// <summary>
        /// Gets all upgrade slots. They may be null if empty.
        /// </summary>
        /// <returns>The upgrades.</returns>
        IUpgrade[] GetUpgrades();

        /// <summary>
        /// Sets the energy core and returns the previous one, if any.
        /// </summary>
        /// <returns>The energy core.</returns>
        /// <param name="energyCore">Energy core.</param>
        Optional<IEnergyCore> SetEnergyCore(IEnergyCore energyCore);

        /// <summary>
        /// Sets a shield and returns the previous shield, if any.
        /// </summary>
        /// <returns>The shield.</returns>
        /// <param name="shield">Shield.</param>
        Optional<IShield> SetShield(IShield shield);
    }
}
