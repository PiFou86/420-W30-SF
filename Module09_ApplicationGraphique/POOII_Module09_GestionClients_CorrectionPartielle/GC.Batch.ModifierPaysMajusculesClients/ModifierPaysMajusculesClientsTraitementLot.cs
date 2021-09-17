using GC.Entites;
using System;
using System.Collections.Generic;

namespace GC.Batch.ModifierPaysMajusculesClients
{
    class ModifierPaysMajusculesClientsTraitementLot : ITraitementLot
    {
        private readonly IDepotClients m_depotClients;

        public ModifierPaysMajusculesClientsTraitementLot(IDepotClients p_depotClients)
        {
            this.m_depotClients = p_depotClients;
        }

        public void Executer()
        {
            List<Client> clients = this.m_depotClients.ListerClients();

            foreach (Client client in clients)
            {
                List<Adresse> adressessModidiees = new List<Adresse>();
                foreach (Adresse adresse in client.Adresses)
                {
                    if (adresse.Pays != adresse.Pays.ToUpper())
                    {
                        Adresse nouvelleAdresse = new Adresse(
                            adresse.AdresseId,
                            adresse.NumeroCivique,
                            adresse.InformationSupplementaire,
                            adresse.Odonyme,
                            adresse.TypeVoie,
                            adresse.CodePostal,
                            adresse.NomMunicipalite,
                            adresse.Etat,
                            adresse.Pays.ToUpper()
                        );
                        adressessModidiees.Add(nouvelleAdresse);
                    }
                }

                if (adressessModidiees.Count > 0)
                {
                    foreach (Adresse adresseModifiee in adressessModidiees)
                    {
                        client.AjouterModifierAdresse(adresseModifiee);
                    }
                    this.m_depotClients.ModifierClient(client);
                }

            }
        }
    }
}
