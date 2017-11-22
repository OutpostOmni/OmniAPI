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
using OmniAPI.World.Biomes;
using OmniAPI.Util;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace OmniAPI.World.Generation {
    public class CoordinateProfile {
        /// <summary>
        /// The coordinate.
        /// </summary>
        public Vector2 Coordinate;

        /// <summary>
        /// The height.
        /// </summary>
        public double Height;

        /// <summary>
        /// The temperature.
        /// </summary>
        public double Temperature;

        /// <summary>
        /// The rainfall.
        /// </summary>
        public double Rainfall;

        /// <summary>
        /// The toxicity.
        /// </summary>
        public double Toxicity;

        /// <summary>
        /// The biome.
        /// </summary>
        public IBiome Biome;

        /// <summary>
        /// Current tile data.
        /// </summary>
        public Tuple<string, byte> Tile;

        /// <summary>
        /// Contains all entities that will be spawned when this coordinate is.
        /// Is used only during generation-related rendering. phases.
        /// </summary>
        public List<EntityPopulationQueueEntry> Entities = new List<EntityPopulationQueueEntry>();

        public CoordinateProfile(Vector2 coordinate, double height, double temperature, double rainfall, double toxicity) {
            this.Coordinate = coordinate;
            this.Height = height;
            this.Temperature = temperature;
            this.Rainfall = rainfall;
            this.Toxicity = toxicity;
        }

        public override string ToString() {
            var builder = new StringBuilder();

            builder.Append("Coordinate: ");
            builder.Append(Coordinate);
            builder.Append(", ");

            builder.Append("Height: ");
            builder.Append(Height);
            builder.Append(", ");

            builder.Append("Temperature: ");
            builder.Append(Temperature);
            builder.Append(", ");

            builder.Append("Rainfall: ");
            builder.Append(Rainfall);
            builder.Append(", ");

            builder.Append("Toxicity: ");
            builder.Append(Toxicity);
            builder.Append(", ");

            builder.Append("Biome: ");
            builder.Append(Biome);
            builder.Append(", ");

            builder.Append("Tile: ");
            builder.Append(Tile);
            builder.Append(", ");

            builder.Append("Entities: ");
            builder.Append(Entities.Count);

            return builder.ToString();
        }
    }
}
