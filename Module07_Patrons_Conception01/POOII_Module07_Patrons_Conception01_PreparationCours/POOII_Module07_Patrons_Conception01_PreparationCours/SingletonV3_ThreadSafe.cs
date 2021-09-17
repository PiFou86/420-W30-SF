using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module07_Patrons_Conception01_PreparationCours
{
    public class SingletonV3_ThreadSafe
    {
        private static SingletonV3_ThreadSafe _instance;
        private static object _lock = new object();

        public static SingletonV3_ThreadSafe Instance
        {
            get
            {
                if (_instance is null)
                {
                    lock (_lock)
                    {
                        if (_instance is null)
                        {
                            _instance = new SingletonV3_ThreadSafe();
                        }
                    }
                }

                return _instance;
            }
        }

        public string ExempleMehodeDeVotreInstanceUnique()
        {
            return "Je suis une instance unique !";
        }
    }
}
