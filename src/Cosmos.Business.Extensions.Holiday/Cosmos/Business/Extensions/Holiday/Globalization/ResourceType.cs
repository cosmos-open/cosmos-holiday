using System;

namespace Cosmos.Business.Extensions.Holiday.Globalization
{
    /// <summary>
    /// Resource Type
    /// </summary>
    [Flags]
    public enum ResourceType
    {
        /// <summary>
        /// Date
        /// </summary>
        Date,

        /// <summary>
        /// Name
        /// </summary>
        Name,

        /// <summary>
        /// Chinese
        /// </summary>
        Chinese,

        /// <summary>
        /// Easter
        /// </summary>
        Easter,

        /// <summary>
        /// Orthodox
        /// </summary>
        Orthodox,

        /// <summary>
        /// Jewish
        /// </summary>
        Jewish,

        /// <summary>
        /// Muslim
        /// </summary>
        Muslim,

        /// <summary>
        /// User custom
        /// </summary>
        User,

        /// <summary>
        /// Build-in default
        /// </summary>
        BuildInDefault,

        /// <summary>
        /// All
        /// </summary>
        All = Date | Name | Chinese | Easter | Orthodox | Jewish | Muslim | User | BuildInDefault
    }

}