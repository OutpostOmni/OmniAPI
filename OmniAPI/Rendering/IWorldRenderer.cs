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
using OmniAPI.Entities;
using OmniAPI.Services.Event;
using OmniAPI.World;
using UnityEngine;

namespace OmniAPI.Rendering {
    public interface IWorldRenderer {
        /// <summary>
        /// Despawns the entity.
        /// </summary>
        /// <param name="entity">Entity.</param>
        void DespawnEntity(IEntity entity);

        /// <summary>
        /// Despawns the tile.
        /// </summary>
        /// <param name="tile">Tile.</param>
        void DespawnTile(ITile tile);

        /// <summary>
        /// Renders the entity.
        /// </summary>
        /// <returns>The entity.</returns>
        /// <param name="entityPrefabId">Entity prefab identifier.</param>
        /// <param name="variantId">Variant identifier.</param>
        /// <param name="worldVec">World vec.</param>
        IEntity RenderEntity(string entityPrefabId, byte variantId, Vector2 worldVec);

        /// <summary>
        /// Renders the entity.
        /// </summary>
        /// <returns>The entity.</returns>
        /// <param name="entityPrefabId">Entity prefab identifier.</param>
        /// <param name="variantId">Variant identifier.</param>
        /// <param name="worldVec">World vec.</param>
        /// <param name="holder">Holder.</param>
        IEntity RenderEntity(string entityPrefabId, byte variantId, Vector2 worldVec, IEntityHolder holder);
   
        /// <summary>
        /// Renders the entity.
        /// </summary>
        /// <returns>The entity.</returns>
        /// <param name="entityPrefabId">Entity prefab identifier.</param>
        /// <param name="variantId">Variant identifier.</param>
        /// <param name="worldVec">World vec.</param>
        /// <param name="parentTransform">Parent transform.</param>
        IEntity RenderEntity(string entityPrefabId, byte variantId, Vector2 worldVec, Transform parentTransform);

        /// <summary>
        /// Render an item in the world.
        /// </summary>
        /// <param name="cause">Cause.</param>
        /// <param name="itemGameObject">Item game object.</param>
        void RenderItem(Cause cause, GameObject itemGameObject);

        /// <summary>
        /// Renders the particles.
        /// </summary>
        /// <returns>The particles.</returns>
        /// <param name="prefab">Prefab.</param>
        /// <param name="worldVec">World vec.</param>
        /// <param name="sortingOrder">Sorting order.</param>
        GameObject RenderParticles(GameObject prefab, Vector3 worldVec, int sortingOrder);

        /// <summary>
        /// Renders a random smoke particle prefab.
        /// </summary>
        /// <param name="worldVec">World vec.</param>
        /// <param name="sortingOrder">Sorting order.</param>
        void RenderSmokeParticles(Vector3 worldVec, int sortingOrder);

        /// <summary>
        /// Renders the spark particles.
        /// </summary>
        /// <param name="worldVec">World vec.</param>
        /// <param name="sortingOrder">Sorting order.</param>
        void RenderSparkParticles(Vector3 worldVec, int sortingOrder);

        /// <summary>
        /// Renders the tile.
        /// </summary>
        /// <returns>The tile.</returns>
        /// <param name="tilePrefabId">Tile prefab identifier.</param>
        /// <param name="worldVec">World vec.</param>
        ITile RenderTile(string tilePrefabId, Vector2 worldVec);
    }
}
