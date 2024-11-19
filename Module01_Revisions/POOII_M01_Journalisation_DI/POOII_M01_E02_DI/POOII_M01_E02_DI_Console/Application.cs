using POOII_M01_E02_DI_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOII_M01_E02_DI_Console
{
    internal class Application
    {
        private IJournal m_journal;
        public Application(IJournal journal) {
            this.m_journal = journal;
        }

        public void Run()
        {
            this.m_journal.Information("Démarrage de l'application");
            this.m_journal.Avertissement("Attention, il va y avoir une erreur");
            this.m_journal.Erreur("Erreur 42");
        }
    }
}
