namespace Ex04_billpughs_singletonhelper
{
    public sealed class Cache
    {

        internal static class SingleTonHelper
        {
            static public Cache instance = new Cache();
        }

        public Cache()
        {

        }

        public static Cache getInstance()=> SingleTonHelper.instance;

    }
}