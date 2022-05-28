namespace ex02_lazyloading
{
    public sealed class Cache
    {
        private static Cache cache;

        private  Cache()
        {

        }

       // [System.Runtime.CompilerServices.MethodImpl( System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
        public static Cache getInstance()
        {
            lock(cache)
            {
                if (cache == null)
                {
                    cache = new Cache();
                }
                return cache;
            }
        }

    }
}