namespace ex01_eagrelyintilization
{        public sealed class Cache
        {
            private static Cache cache = new Cache();

            private Cache()
            {

            }

            public static Cache getInstance() => cache;
        }
    }


