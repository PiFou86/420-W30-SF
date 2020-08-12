using System;
using System.Collections.Generic;
using System.Text;

namespace Module08_Exercice01_Base_Console.Entites
{
    public interface IDepotClients
    {
        void AjouterClient(Client p_client);
        List<Client> ListerClients();
        Client RechercherClient(Guid p_guid);
        void ModifierClient(Client p_client);
    }
}
