using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module07_Demo
{
    public class GenerateurIdentifiantSingleton
    {
        private static GenerateurIdentifiantSingleton _instance;
        private static object _lock = new object();

        private int m_dernierIdentifiant;

        public static GenerateurIdentifiantSingleton Instance
        {
            get
            {
                if (_instance is null)
                {
                    lock (_lock)
                    {
                        if (_instance is null)
                        {
                            _instance = new GenerateurIdentifiantSingleton();
                        }
                    }
                }

                return _instance;
            }
        }

        public int GenererIdentifiant()
        {
            return ++this.m_dernierIdentifiant;
        }
    }
}
