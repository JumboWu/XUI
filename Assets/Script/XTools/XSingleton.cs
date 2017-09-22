namespace X.Tools
{
    public class XSingleton<T> where T  : class, new()
    {
        private static T _Instance;
        

        protected XSingleton()
        {
        }

        public static T Instance
        {
            get
            {
                if (null == _Instance)
                {
                    _Instance = new T();
                }

                return _Instance;
            }
        }

        public static void Destroy()
        {
            _Instance = null;
        }
    }
}
