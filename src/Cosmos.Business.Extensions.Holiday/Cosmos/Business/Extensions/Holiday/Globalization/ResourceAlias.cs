using System;

namespace Cosmos.Business.Extensions.Holiday.Globalization
{

    /// <summary>
    /// Alias for <see cref="ResourceType"/>
    /// </summary>
    [Flags]
    public enum ResourceAlias
    {
        /// <summary>
        /// Date
        /// </summary>
        D = ResourceType.Date,

        /// <summary>
        /// Name
        /// </summary>
        N = ResourceType.Name,

        /// <summary>
        /// Chinese
        /// </summary>
        C = ResourceType.Chinese,

        /// <summary>
        /// Easter
        /// </summary>
        E = ResourceType.Easter,

        /// <summary>
        /// Orthodox
        /// </summary>
        O = ResourceType.Orthodox,

        /// <summary>
        /// Jewish
        /// </summary>
        J = ResourceType.Jewish,

        /// <summary>
        /// Muslim
        /// </summary>
        M = ResourceType.Muslim,

        /// <summary>
        /// User custom
        /// </summary>
        U = ResourceType.User,

        /// <summary>
        /// Build-in default
        /// </summary>
        B = ResourceType.BuildInDefault,

        /// <summary>
        /// All
        /// </summary>
        A = ResourceType.All
    }
}