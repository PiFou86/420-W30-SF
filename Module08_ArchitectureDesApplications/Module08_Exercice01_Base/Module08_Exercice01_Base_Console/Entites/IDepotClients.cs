using System;
using System.Collections.Generic;

namespace Module08_Exercice01_Base_Console.Entites
{
    public interface IDepotClients
    {
        void AjouterClient(Client p_client);
        List<Client> ListerClients();
        Client? ObtenirClient(Guid p_clientId);
        void ModifierClient(Client p_client);
    }
}
