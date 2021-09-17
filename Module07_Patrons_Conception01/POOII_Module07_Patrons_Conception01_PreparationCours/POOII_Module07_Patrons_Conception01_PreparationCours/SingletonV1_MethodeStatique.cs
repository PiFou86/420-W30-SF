using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module07_Patrons_Conception01_PreparationCours
{
    public class SingletonV1_MethodeStatique
    {
        private static SingletonV1_MethodeStatique _instance;

        public static SingletonV1_MethodeStatique ObtenirInstance()
        {
            if (_instance is null)
            {
                _instance = new SingletonV1_MethodeStatique();
            }

            return _instance;
        }

        public string ExempleMehodeDeVotreInstanceUnique()
        {
            return "Je suis une instance unique !";
        }
    }
}
