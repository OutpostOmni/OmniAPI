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
using System;

namespace OmniAPI.Services.Save {
    public interface IPersistanceDataChunkWriter : IDisposable {
        /// <summary>
        /// Add an object. Performs a lookup for supported types
        /// and if not found, throws an exception.
        /// </summary>
        /// <param name="val">Value.</param>
        void Write(object val);

        /// <summary>
        /// Add an object, but perform a lookup for supported types
        /// using the type provided instead of the object's.
        /// </summary>
        /// <param name="val">Value.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        void Write<T>(object val);

        /// <summary>
        /// Add an object with a cached handler.
        /// </summary>
        /// <param name="handler">Handler.</param>
        /// <param name="obj">Object.</param>
        void Write(IPersistanceDataType handler, object obj);

        /// <summary>
        /// Add a bool. No type lookup necessary.
        /// </summary>
        /// <param name="val">Value.</param>
        void WriteBool(bool val);

        /// <summary>
        /// Add a byte. No type lookup necessary.
        /// </summary>
        /// <param name="val">Value.</param>
        void WriteByte(byte val);

        /// <summary>
        /// Add a char. No type lookup necessary.
        /// </summary>
        /// <param name="val">Value.</param>
        void WriteChar(char val);

        /// <summary>
        /// Add anything which implements ICollection
        /// </summary>
        /// <param name="val">Value.</param>
        void WriteCollection(object val);

        /// <summary>
        /// Add a collection with a cached handler.
        /// </summary>
        /// <param name="handler">Handler.</param>
        /// <param name="val">Value.</param>
        void WriteCollection(IPersistanceDataType handler, object val);

        /// <summary>
        /// Add a decimal. No type lookup necessary.
        /// </summary>
        /// <param name="val">Value.</param>
        void WriteDecimal(decimal val);

        /// <summary>
        /// Add a double. No type lookup necessary.
        /// </summary>
        /// <param name="val">Value.</param>
        void WriteDouble(double val);

        /// <summary>
        /// Add an enum.
        /// </summary>
        /// <param name="val">Value.</param>
        void WriteEnum(object val);

        /// <summary>
        /// Add a float. No type lookup necessary.
        /// </summary>
        /// <param name="val">Value.</param>
        void WriteFloat(float val);

        /// <summary>
        /// Add a short. No type lookup necessary.
        /// </summary>
        /// <param name="val">Value.</param>
        void WriteInt16(short val);

        /// <summary>
        /// Add an integer. No type lookup necessary.
        /// </summary>
        /// <param name="val">Value.</param>
        void WriteInt32(int val);

        /// <summary>
        /// Add a long. No type lookup necessary.
        /// </summary>
        /// <param name="val">Value.</param>
        void WriteInt64(long val);

        /// <summary>
        /// Add a string. No type lookup necessary.
        /// </summary>
        /// <param name="val">Value.</param>
        void WriteString(string val);

        /// <summary>
        /// Add a ushort. No type lookup necessary.
        /// </summary>
        /// <param name="val">Value.</param>
        void WriteUInt16(ushort val);

        /// <summary>
        /// Add an unsigned integer. No type lookup necessary.
        /// </summary>
        /// <param name="val">Value.</param>
        void WriteUInt32(uint val);

        /// <summary>
        /// Add a ulong. No type lookup necessary.
        /// </summary>
        /// <param name="val">Value.</param>
        void WriteUInt64(ulong val);
    }
}
