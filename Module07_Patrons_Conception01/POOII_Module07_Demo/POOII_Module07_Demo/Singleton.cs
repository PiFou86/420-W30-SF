using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module07_Demo
{
    public static class Singleton<TypeObjet> where TypeObjet : new()
    {
        private static TypeObjet _instance;
        private static object _lock = new object();

        public static TypeObjet Instance
        {
            get
            {
                if (_instance is null)
                {
                    lock (_lock)
                    {
                        if (_instance is null)
                        {
                            _instance = new TypeObjet();
                        }
                    }
                }

                return _instance;
            }
        }
    }
}
