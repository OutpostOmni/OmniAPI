using OmniAPI.Util;
using OmniAPI.World.Generation;
using OmniAPI.World.Generation.Features;
using System.Collections.Generic;
using UnityEngine;

namespace OmniAPI.World {
    public interface IRegion {
        /// <summary>
        /// Gets the profiles.
        /// </summary>
        /// <value>The profiles.</value>
        Dictionary<int, ChunkProfile>.ValueCollection Profiles { get; }

        /// <summary>
        /// Add a chunk profile.
        /// </summary>
        /// <param name="profile">Profile.</param>
        void Add(ChunkProfile profile);

        /// <summary>
        /// Add a feature pattern to cache.
        /// </summary>
        /// <param name="worldX">World x.</param>
        /// <param name="worldY">World y.</param>
        /// <param name="pattern">Pattern.</param>
        void AddFeature(int worldX, int worldY, FeaturePattern pattern);

        /// <summary>
        /// Check if the region contains a profile for a given coordinate.
        /// </summary>
        /// <returns><c>true</c>, if contains profile, <c>false</c> otherwise.</returns>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        bool ContainsProfileForCoord(int x, int y);

        /// <summary>
        /// Gets the coordinate profile, if any.
        /// </summary>
        /// <returns>The coordinate profile.</returns>
        /// <param name="worldX">World x.</param>
        /// <param name="worldY">World y.</param>
        Optional<CoordinateProfile> GetCoordinateProfile(int worldX, int worldY);

        /// <summary>
        /// Gets the coordinate profile, if any.
        /// </summary>
        /// <returns>The coordinate profile.</returns>
        /// <param name="worldVec">World vec.</param>
        Optional<CoordinateProfile> GetCoordinateProfile(Vector2 worldVec);

        /// <summary>
        /// Gets the feature entities, if any.
        /// </summary>
        /// <returns>The feature entities.</returns>
        /// <param name="worldX">World x.</param>
        /// <param name="worldY">World y.</param>
        Optional<List<EntityPopulationQueueEntry>> GetFeatureEntities(int worldX, int worldY);

        /// <summary>
        /// Gets the feature tile, if any.
        /// </summary>
        /// <returns>The feature tile.</returns>
        /// <param name="worldX">World x.</param>
        /// <param name="worldY">World y.</param>
        Optional<Tuple<string, byte>> GetFeatureTile(int worldX, int worldY);

        /// <summary>
        /// Gets the profile, if any.
        /// </summary>
        /// <returns>The profile.</returns>
        /// <param name="chunkX">Chunk x.</param>
        /// <param name="chunkY">Chunk y.</param>
        Optional<ChunkProfile> GetProfile(int chunkX, int chunkY);
    }
}
