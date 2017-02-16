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
using System.Collections.Generic;
using UnityEngine;
      
namespace OmniAPI {
	/// <summary>
	/// Wrapper for optional values. Null is terrible.
	/// </summary>
	sealed public class Optional<T> {
		T val;

		/// <summary>
		/// Creates a new empty-value instance.
		/// </summary>
		/// <returns>An empty optional.</returns>
		public static Optional<T> Empty() {
			return new Optional<T>();
		}

		/// <summary>
		/// Statically construct a new optional.
		/// </summary>
		/// <returns>Optional.</returns>
		/// <param name="val">The value.</param>
		public static Optional<T> From(T val) {
			return new Optional<T>(val);
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:OmniAPI.Optional`1"/> class.
		/// </summary>
		/// <param name="val">Value.</param>
		public Optional(T val) {
			this.val = val;
		}

		/// <summary>
		/// Initializes a new empty-value instance of the <see cref="T:OmniAPI.Optional`1"/> class.
		/// </summary>
		public Optional() {}

		/// <summary>
		/// Get this value.
		/// </summary>
		/// <returns>The value.</returns>
		public T Get() {
			return val;
		}

		/// <summary>
		/// Checks if the value is empty.
		/// </summary>
		/// <returns><c>true</c>, if the value is empty, <c>false</c> otherwise.</returns>
		public bool IsEmpty() {
			return EqualityComparer<T>.Default.Equals(val, default(T));
		}

		/// <summary>
		/// Checks if the value is present.
		/// </summary>
		/// <returns><c>true</c>, if value is present, <c>false</c> otherwise.</returns>
		public bool IsPresent() {
			return !IsEmpty();
		}
	}
}
