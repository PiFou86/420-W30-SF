using Module08_Exercice01_Base_Console.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Module08_Exercice01_Base_Console.TraitementLot.ModifierNomPrenomPremiereLettreMajuscules
{
    class ModifierNomPrenomPremiereLettreMajusculesTraitementLot : ITraitementLot
    {
        private readonly IDepotClients m_depotClients;

        public ModifierNomPrenomPremiereLettreMajusculesTraitementLot(IDepotClients p_depotClients)
        {
            this.m_depotClients = p_depotClients;
        }

        public void Executer()
        {
            List<Client> clients = this.m_depotClients.ListerClients();

            foreach (Client client in clients)
            {
                if (client.Nom != client.Nom.ToUpper() || client.Prenom != client.Prenom.ToUpper())
                {
                    Client clientModifie = new Client(
                        client.ClientId, 
                        client.Nom.ToUpper(), 
                        client.Prenom.ToUpper(), 
                        client.Adresses
                        );
                    this.m_depotClients.ModifierClient(clientModifie);
                }
            }
        }
    }
}
