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
using System.Collections.Generic;
using System.IO;

namespace OmniAPI.Services.Save {
    public interface IPersistanceDataChunkReader : IDisposable {
        /// <summary>
        /// Gets the underlying binary reader.
        /// </summary>
        /// <value>The binary reader.</value>
        BinaryReader BinaryReader { get; }

        /// <summary>
        /// Read and return the given data type.
        /// </summary>
        /// <returns>The read object.</returns>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        T Read<T>();

        /// <summary>
        /// Read data with a cached handler.
        /// </summary>
        /// <returns>The read.</returns>
        /// <param name="handler">Handler.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        T Read<T>(IPersistanceDataType handler);

        /// <summary>
        /// Read the given data type into an existing instance.
        /// </summary>
        /// <param name="instance">Instance.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        void Read<T>(T instance);

        /// <summary>
        /// Read an array.
        /// </summary>
        /// <returns>The array.</returns>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        T[] ReadArray<T>();

        /// <summary>
        /// Reads the bool.
        /// </summary>
        /// <returns>The bool.</returns>
        bool ReadBool();

        /// <summary>
        /// Reads the byte.
        /// </summary>
        /// <returns>The byte.</returns>
        byte ReadByte();

        /// <summary>
        /// Reads the char.
        /// </summary>
        /// <returns>The char.</returns>
        char ReadChar();

        /// <summary>
        /// Reads the chunk.
        /// </summary>
        /// <returns>The chunk.</returns>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        T ReadChunk<T>();

        /// <summary>
        /// Reads the chunk into an existing intsance.
        /// </summary>
        /// <returns>The chunk.</returns>
        /// <param name="complex">Complex.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        T ReadChunk<T>(IKeyedPersistanceDataType complex);

        /// <summary>
        /// Reads chunks dynamically by key into the given targets.
        /// </summary>
        /// <param name="targets">Targets.</param>
        void ReadChunks(IPersistanceTarget[] targets);

        /// <summary>
        /// Reads chunks dynamically by key into the given targets.
        /// </summary>
        /// <param name="targets">Targets.</param>
        void ReadChunks(List<IPersistanceTarget> targets);

        /// <summary>
        /// Reads the decimal.
        /// </summary>
        /// <returns>The decimal.</returns>
        decimal ReadDecimal();

        /// <summary>
        /// Reads a dictionary of data.
        /// </summary>
        /// <returns>The dictionary.</returns>
        /// <typeparam name="TKey">The 1st type parameter.</typeparam>
        /// <typeparam name="TValue">The 2nd type parameter.</typeparam>
        Dictionary<TKey, TValue> ReadDictionary<TKey, TValue>();

        /// <summary>
        /// Reads the double.
        /// </summary>
        /// <returns>The double.</returns>
        double ReadDouble();

        /// <summary>
        /// Reads the enum.
        /// </summary>
        /// <returns>The enum.</returns>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        T ReadEnum<T>();

        /// <summary>
        /// Reads the float.
        /// </summary>
        /// <returns>The float.</returns>
        float ReadFloat();

        /// <summary>
        /// Reads the int16.
        /// </summary>
        /// <returns>The int16.</returns>
        short ReadInt16();

        /// <summary>
        /// Reads the int32.
        /// </summary>
        /// <returns>The int32.</returns>
        int ReadInt32();

        /// <summary>
        /// Reads the int64.
        /// </summary>
        /// <returns>The int64.</returns>
        long ReadInt64();

        /// <summary>
        /// Reads a list of items.
        /// </summary>
        /// <returns>The list.</returns>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        List<T> ReadList<T>();

        /// <summary>
        /// Read a list of items with a cached handler.
        /// </summary>
        /// <returns>The list.</returns>
        /// <param name="handler">Handler.</param>
        /// <typeparam name="T">The 1st type parameter.</typeparam>
        List<T> ReadList<T>(IPersistanceDataType handler);

        /// <summary>
        /// Reads the string.
        /// </summary>
        /// <returns>The string.</returns>
        string ReadString();

        /// <summary>
        /// Reads ushort.
        /// </summary>
        /// <returns>The ushort.</returns>
        UInt16 ReadUInt16();

        /// <summary>
        /// Reads uint.
        /// </summary>
        /// <returns>The uint.</returns>
        UInt32 ReadUInt32();

        /// <summary>
        /// Reads ulong.
        /// </summary>
        /// <returns>The ulong.</returns>
        UInt64 ReadUInt64();
    }
}
