using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module07_Demo
{
    public class GenerateurIdentifiant
    {
        private int m_dernierIdentifiant;

        public int GenererIdentifiant()
        {
            return ++this.m_dernierIdentifiant;
        }
    }
}
