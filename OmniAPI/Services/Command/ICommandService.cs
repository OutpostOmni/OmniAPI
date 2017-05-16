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
using OmniAPI.Util;

namespace OmniAPI.Services.Command {
	/// <summary>
	/// Represents the central command management service.
	/// </summary>
	public interface ICommandService : IService {
		/// <summary>
		/// Get a new command builder.
		/// </summary>
		/// <value>The builder.</value>
		ICommandBuilder Builder();

		/// <summary>
		/// Get the specified command from a given alias.
		/// </summary>
		/// <param name="alias">Alias.</param>
		/// <param name="commands">Commands.</param>
		Optional<ICommand> Get(string alias, ICommand[] commands);

		/// <summary>
		/// Parse the given text into a command and arguments.
		/// </summary>
		/// <param name="text">Text.</param>
		CommandResult Parse(string text);

		/// <summary>
		/// Register the specified command.
		/// </summary>
		/// <param name="command">Command.</param>
		void Register(ICommand command);
	}
}
