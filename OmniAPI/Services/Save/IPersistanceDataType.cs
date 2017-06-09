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
namespace OmniAPI.Services.Save {
    /// <summary>
    /// Custom read/write logic for complex objects.
    /// </summary>
    public interface IPersistanceDataType {
        /// <summary>
        /// Read data into a new object instance from the given reader.
        /// </summary>
        /// <returns>The read.</returns>
        /// <param name="reader">Reader.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        object Read(IPersistanceDataChunkReader reader);

        /// <summary>
        /// Read data into an existing object from the given reader.
        /// </summary>
        /// <returns>The read.</returns>
        /// <param name="reader">Reader.</param>
        /// <param name="obj">Object.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        object Read(IPersistanceDataChunkReader reader, object obj);

        /// <summary>
        /// Write the specified obj to the writer.
        /// </summary>
        /// <returns>The write.</returns>
        /// <param name="obj">Object.</param>
        /// <param name="writer">Writer.</param>
        void Write(object obj, IPersistanceDataChunkWriter writer);
    }
}
