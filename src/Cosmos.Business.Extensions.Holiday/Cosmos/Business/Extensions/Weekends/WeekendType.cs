namespace Cosmos.Business.Extensions.Weekends
{
    /// <summary>
    /// Type of weekend
    /// </summary>
    public enum WeekendType
    {
        /// <summary>
        /// Universal
        /// </summary>
        Universal = 1,
        
        /// <summary>
        /// Semi universal
        /// </summary>
        SemiUniversal = 2,
        
        /// <summary>
        /// Friday sunday
        /// </summary>
        FridaySunday = 3,
        
        /// <summary>
        /// Friday only
        /// </summary>
        FridayOnly = 4,
        
        /// <summary>
        /// Saturday only
        /// </summary>
        SaturdayOnly = 5,
        
        /// <summary>
        /// Sunday only
        /// </summary>
        SundayOnly = 6
    }
}