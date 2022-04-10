namespace Ex04_Bill_Pughs_Static_Helper
{
    public sealed class Cache
    {
        internal static class SingleTonHelper
        {
            internal static Cache Instance = new Cache();
        }
        private Cache()
        {

        }

        public static Cache getInstance() => SingleTonHelper.Instance;


    }
}