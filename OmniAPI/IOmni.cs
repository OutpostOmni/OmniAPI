using OmniAPI.Game;
using OmniAPI.Services;
using OmniAPI.Util;

namespace OmniAPI {
    /// <summary>
    /// The primary application interface.
    /// </summary>
    public interface IOmni {
        /// <summary>
        /// Gets the game.
        /// If the game scene is not currently loaded, returns null.
        /// </summary>
        /// <value>The game.</value>
        IGame Game { get; }

        /// <summary>
        /// Get an application-level service, or a game-level service if a game is loaded.
        /// </summary>
        /// <returns>The optional service.</returns>
        /// <typeparam name="T">The service type.</typeparam>
        Optional<T> GetService<T>() where T : IService;
    }
}
