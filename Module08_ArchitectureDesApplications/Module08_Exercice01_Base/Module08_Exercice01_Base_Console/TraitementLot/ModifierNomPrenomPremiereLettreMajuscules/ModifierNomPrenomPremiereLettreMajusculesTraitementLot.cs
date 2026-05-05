using Module08_Exercice01_Base_Console.Entites;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Module08_Exercice01_Base_Console.TraitementLot.ModifierNomPrenomPremiereLettreMajuscules
{
    public class ModifierNomPrenomPremiereLettreMajusculesTraitementLot : ITraitementLot
    {
        private readonly IDepotClients m_depotClients;

        public ModifierNomPrenomPremiereLettreMajusculesTraitementLot(IDepotClients p_depotClients)
        {
            if (p_depotClients is null)
            {
                throw new ArgumentNullException(nameof(p_depotClients), "Le dépôt de clients ne peut pas être null.");
            }

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
