using System;
using System.Collections.Generic;
using System.Text;

namespace Module06_Exercice01_Correction_Partielle.Entites
{
    public interface IDepotClients
    {
        void AjouterClient(Client p_client);
        List<Client> ListerClients();
        Client RechercherClient(Guid p_guid);
        void ModifierClient(Client p_client);
    }
}
