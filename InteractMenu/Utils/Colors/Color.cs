namespace InteractMenu.Utils.Colors
{
    public enum ColorsKeyEnum
    {
        Bad,
        Good
    }

    public struct ColorsKey
    {
        public ColorsKeyEnum value;

        private ColorsKey(ColorsKeyEnum bad)
        {
            value = bad;
        }

        public static ColorsKey Bad => new (ColorsKeyEnum.Bad);
        public static ColorsKey Good => new (ColorsKeyEnum.Good);
    }
    
    
}