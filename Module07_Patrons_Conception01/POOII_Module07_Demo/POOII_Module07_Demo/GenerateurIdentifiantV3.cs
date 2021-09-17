using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module07_Demo
{
    public class GenerateurIdentifiantV3 : SingletonV3<GenerateurIdentifiantV3>
    {
        private int m_dernierIdentifiant;

        public GenerateurIdentifiantV3() { ; }

        public int GenererIdentifiant()
        {
            return ++this.m_dernierIdentifiant;
        }
    }
}
