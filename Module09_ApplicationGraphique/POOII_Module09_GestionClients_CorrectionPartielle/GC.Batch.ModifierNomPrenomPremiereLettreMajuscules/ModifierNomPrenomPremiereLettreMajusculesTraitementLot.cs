using GC.Entites;
using System.Collections.Generic;
using System.Globalization;

namespace GC.Batch.ModifierNomPrenomPremiereLettreMajuscules
{
    class ModifierNomPrenomPremiereLettreMajusculesTraitementLot : ITraitementLot
    {
        private readonly IDepotClients m_depotClients;

        public ModifierNomPrenomPremiereLettreMajusculesTraitementLot(IDepotClients p_depotClients)
        {
            this.m_depotClients = p_depotClients;
        }

        public void Executer()
        {
            List<Client> clients = this.m_depotClients.ListerClients();

            foreach (Client client in clients)
            {
                string nomCorrect = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(client.Nom);
                string prenomCorrect = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(client.Prenom);
                if (client.Nom != nomCorrect || client.Prenom != prenomCorrect)
                {
                    Client clientModifie = new Client(
                        client.ClientId,
                        nomCorrect,
                        prenomCorrect, 
                        client.Adresses
                        );
                    this.m_depotClients.ModifierClient(clientModifie);
                }
            }
        }
    }
}
