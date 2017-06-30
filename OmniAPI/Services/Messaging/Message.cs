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
using OmniAPI.Rendering;
using System;

namespace OmniAPI.Services.Messaging {
    public class Message {
        /// <summary>
        /// Sets custom buttons.
        /// </summary>
        public ButtonMeta[] Buttons;

        /// <summary>
        /// A unique ID for this set of messages.
        /// </summary>
        public string Id;

        /// <summary>
        /// An array of message pages.
        /// </summary>
        public MessagePage[] Pages;

        /// <summary>
        /// A callback when this series of message has been read or cleared.
        /// </summary>
        public Action OnComplete;

        /// <summary>
        /// Initializes a new instance of the <see cref="T:OmniAPI.Services.Messaging.Message"/> class.
        /// </summary>
        public Message() {}

        /// <summary>
        /// Initializes a new instance of the <see cref="T:OmniAPI.Services.Messaging.Message"/> class.
        /// </summary>
        /// <param name="page">Page.</param>
        public Message(MessagePage page) {
            this.Pages = new MessagePage[] { page };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:OmniAPI.Services.Messaging.Message"/> class.
        /// </summary>
        /// <param name="pages">Pages.</param>
        public Message(MessagePage[] pages) : this(null, pages, null) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="T:OmniAPI.Services.Messaging.Message"/> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="pages">Pages.</param>
        public Message(string id, MessagePage[] pages) : this(id, pages, null) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="T:OmniAPI.Services.Messaging.Message"/> class.
        /// </summary>
        /// <param name="pages">Pages.</param>
        /// <param name="cb">Cb.</param>
        public Message(MessagePage[] pages, Action cb) : this(null, pages, cb) {}

        /// <summary>
        /// Initializes a new instance of the <see cref="T:OmniAPI.Services.Messaging.Message"/> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="pages">Pages.</param>
        /// <param name="cb">Cb.</param>
        public Message(string id, MessagePage[] pages, Action cb) {
            this.Id = id;
            this.Pages = pages;
            this.OnComplete = cb;
        }
    }
}
