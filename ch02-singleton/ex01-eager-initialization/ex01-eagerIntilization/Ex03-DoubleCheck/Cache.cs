namespace Ex03_DoubleCheck
{
    public sealed class Cache
    {
        static Cache cache;

        private Cache()
        {

        }

        public static Cache getInstance()
        {
            if(cache == null)
            {
                lock (cache)
                {
                    if(cache == null)
                    {
                        cache = new Cache();
                    }
                }
            }
            return cache;
        }
    }
}