using Module06_Exercice01_Correction_Partielle.Entites;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;
using Module06_Exercice01_Correction_Partielle.TraitementLot.ModifierPaysMajusculesClients;

namespace Module06_Exercice01_Correction_PartielleTests
{
    public class ModifierPaysMajusculesClientsTraitementLotTests
    {
        [Fact]
        public void Executer_2Clients3Adresses2AModifier_TousEnMaj()
        {
            Mock<IDepotClients> mockDepot = new Mock<IDepotClients>();
            mockDepot.Setup(m => m.ListerClients()).Returns(new List<Client>()
            {
                new Client(Guid.NewGuid(), "Nom1", "Prenom1", new List<Adresse>()
                {
                    new Adresse(Guid.NewGuid(), 100, "", "ODO", "Voie", "CP", "Muni", "Etat", "Pays1"),
                    new Adresse(Guid.NewGuid(), 100, "", "ODO", "Voie", "CP", "Muni", "Etat", "PAYS2"),
                }),
                new Client(Guid.NewGuid(), "Nom2", "Prenom2", new List<Adresse>()
                {
                    new Adresse(Guid.NewGuid(), 100, "", "ODO", "Voie", "CP", "Muni", "Etat", "Pays3"),
                })
            });
            List<Client> clientsModifies = new List<Client>();
            mockDepot.Setup(m => m.ModifierClient(It.IsAny<Client>())).Callback<Client>(c => clientsModifies.Add(c));

            ModifierPaysMajusculesClientsTraitementLot mpmct = new ModifierPaysMajusculesClientsTraitementLot(mockDepot.Object);

            mpmct.Executer();

            mockDepot.Verify(m => m.ListerClients(), Times.Once);
            mockDepot.Verify(m => m.ModifierClient(It.IsAny<Client>()), Times.Exactly(2));
            mockDepot.VerifyNoOtherCalls();

            Assert.Equal(2, clientsModifies.Count);
            Assert.Equal(2, clientsModifies[0].Adresses.Count);
            Assert.Equal("PAYS1", clientsModifies[0].Adresses[0].Pays);
            Assert.Single(clientsModifies[1].Adresses);
            Assert.Equal("PAYS3", clientsModifies[1].Adresses[0].Pays);
        }
    }
}
