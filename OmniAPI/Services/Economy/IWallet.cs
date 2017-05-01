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
namespace OmniAPI.Services.Economy {
    /// <summary>
    /// Represents a wallet, a container and transaction manager for currency.
    /// </summary>
    public interface IWallet {
        /// <summary>
        /// Gets the balance.
        /// </summary>
        /// <value>The balance.</value>
        float Balance { get; }

        /// <summary>
        /// Deposit the specified amount.
        /// </summary>
        /// <returns>The deposit.</returns>
        /// <param name="amount">Amount.</param>
        void Deposit(float amount);

        /// <summary>
        /// Check if the wallet has the given balance.
        /// </summary>
        /// <returns><c>true</c>, if balance is equal to or greater than the amount, <c>false</c> otherwise.</returns>
        /// <param name="amount">Amount.</param>
        bool HasBalance(float amount);

        /// <summary>
        /// Sets the balance.
        /// </summary>
        /// <param name="balance">Balance.</param>
        void SetBalance(float balance);

        /// <summary>
        /// Withdraw the specified amount.
        /// </summary>
        /// <returns>Whether the amount was withdrawn successfully.</returns>
        /// <param name="amount">Amount.</param>
        bool Withdraw(float amount);
    }
}
