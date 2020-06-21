namespace Cosmos.Business.Extensions.Holiday.Globalization
{
    /// <summary>
    /// Resource type switcher
    /// </summary>
    public static class ResourceTypeSwitcher
    {
        /// <summary>
        /// Switch
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static ResourceType Switch(int num)
        {
            switch (num)
            {
                case 0: return ResourceType.All;
                case 1: return ResourceType.Date;
                case 2: return ResourceType.Name;
                case 3: return ResourceType.Chinese;
                case 4: return ResourceType.Easter;
                case 5: return ResourceType.Orthodox;
                case 6: return ResourceType.Jewish;
                case 7: return ResourceType.Muslim;
                case 99: return ResourceType.User;
                case 100: return ResourceType.BuildInDefault;
                default: return ResourceType.All;
            }
        }

        /// <summary>
        /// Switch
        /// </summary>
        /// <param name="alias"></param>
        /// <returns></returns>
        public static ResourceType Switch(ResourceAlias alias)
        {
            switch (alias)
            {
                case ResourceAlias.A: return ResourceType.All;
                case ResourceAlias.D: return ResourceType.Date;
                case ResourceAlias.N: return ResourceType.Name;
                case ResourceAlias.C: return ResourceType.Chinese;
                case ResourceAlias.E: return ResourceType.Easter;
                case ResourceAlias.O: return ResourceType.Orthodox;
                case ResourceAlias.J: return ResourceType.Jewish;
                case ResourceAlias.M: return ResourceType.Muslim;
                case ResourceAlias.U: return ResourceType.User;
                case ResourceAlias.B: return ResourceType.BuildInDefault;
                default: return ResourceType.All;
            }
        }

        /// <summary>
        /// Switch
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static ResourceAlias SwitchAlias(int num)
        {
            switch (num)
            {
                case 0: return ResourceAlias.A;
                case 1: return ResourceAlias.D;
                case 2: return ResourceAlias.N;
                case 3: return ResourceAlias.C;
                case 4: return ResourceAlias.E;
                case 5: return ResourceAlias.O;
                case 6: return ResourceAlias.J;
                case 7: return ResourceAlias.M;
                case 99: return ResourceAlias.U;
                case 100: return ResourceAlias.B;
                default: return ResourceAlias.A;
            }
        }

        /// <summary>
        /// Switch
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static ResourceAlias SwitchAlias(ResourceType type)
        {
            switch (type)
            {
                case ResourceType.All: return ResourceAlias.A;
                case ResourceType.Date: return ResourceAlias.D;
                case ResourceType.Name: return ResourceAlias.N;
                case ResourceType.Chinese: return ResourceAlias.C;
                case ResourceType.Easter: return ResourceAlias.E;
                case ResourceType.Orthodox: return ResourceAlias.O;
                case ResourceType.Jewish: return ResourceAlias.J;
                case ResourceType.Muslim: return ResourceAlias.M;
                case ResourceType.User: return ResourceAlias.U;
                case ResourceType.BuildInDefault: return ResourceAlias.B;
                default: return ResourceAlias.A;
            }
        }
    }
}