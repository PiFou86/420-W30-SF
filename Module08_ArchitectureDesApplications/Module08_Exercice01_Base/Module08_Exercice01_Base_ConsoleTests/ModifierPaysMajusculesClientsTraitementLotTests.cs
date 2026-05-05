using Module06_Exercice01_Correction_Partielle.Entites;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;
using Module08_Exercice01_Base_Console.TraitementLot.ModifierPaysMajusculesClients;

namespace Module08_Exercice01_Base_ConsoleTests
{
    public class ModifierPaysMajusculesClientsTraitementLotTests
    {
        [Fact]
        public void Constructeur_DepotNull_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ModifierPaysMajusculesClientsTraitementLot(null!));
        }

        [Fact]
        public void Executer_3Clients4Adresses2AModifier_TousEnMaj()
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
                }),
                new Client(Guid.NewGuid(), "Nom3", "Prenom3", new List<Adresse>()
                {
                    new Adresse(Guid.NewGuid(), 100, "", "ODO", "Voie", "CP", "Muni", "Etat", "PAYS4"),
                })
            });
            List<Client> clientsModifies = new List<Client>();
            mockDepot.Setup(m => m.ModifierClient(It.IsAny<Client>())).Callback<Client>(c => clientsModifies.Add(c));

            ModifierPaysMajusculesClientsTraitementLot mpmct = new ModifierPaysMajusculesClientsTraitementLot(mockDepot.Object);

            mpmct.Executer();

            mockDepot.Verify(m => m.ListerClients(), Times.Once);
            mockDepot.Verify(m => m.ModifierClient(It.Is<Client>((c) => c.ClientId == clientsModifies[0].ClientId)), Times.Once);
            mockDepot.Verify(m => m.ModifierClient(It.Is<Client>((c) => c.ClientId == clientsModifies[1].ClientId)), Times.Once);
            mockDepot.VerifyNoOtherCalls();

            Assert.Equal(2, clientsModifies.Count);
            Assert.Equal(2, clientsModifies[0].Adresses.Count);
            Assert.Equal("PAYS1", clientsModifies[0].Adresses[0].Pays);
            Assert.Single(clientsModifies[1].Adresses);
            Assert.Equal("PAYS3", clientsModifies[1].Adresses[0].Pays);
        }

        [Fact]
        public void Executer_ClientsPaysDejaEnMajuscules_AucuneModification()
        {
            Mock<IDepotClients> mockDepot = new Mock<IDepotClients>();
            mockDepot.Setup(m => m.ListerClients()).Returns(new List<Client>()
            {
                new Client(Guid.NewGuid(), "Nom1", "Prenom1", new List<Adresse>()
                {
                    new Adresse(Guid.NewGuid(), 100, "", "ODO", "Voie", "CP", "Muni", "Etat", "PAYS1"),
                    new Adresse(Guid.NewGuid(), 100, "", "ODO", "Voie", "CP", "Muni", "Etat", "PAYS2"),
                }),
            });

            ModifierPaysMajusculesClientsTraitementLot traitement = new ModifierPaysMajusculesClientsTraitementLot(mockDepot.Object);

            traitement.Executer();

            mockDepot.Verify(m => m.ListerClients(), Times.Once);
            mockDepot.Verify(m => m.ModifierClient(It.IsAny<Client>()), Times.Never);
            mockDepot.VerifyNoOtherCalls();
        }

        [Fact]
        public void Executer_ClientSansAdresses_AucuneModification()
        {
            Mock<IDepotClients> mockDepot = new Mock<IDepotClients>();
            mockDepot.Setup(m => m.ListerClients()).Returns(new List<Client>()
            {
                new Client(Guid.NewGuid(), "Nom1", "Prenom1", new List<Adresse>()),
            });

            ModifierPaysMajusculesClientsTraitementLot traitement = new ModifierPaysMajusculesClientsTraitementLot(mockDepot.Object);

            traitement.Executer();

            mockDepot.Verify(m => m.ListerClients(), Times.Once);
            mockDepot.Verify(m => m.ModifierClient(It.IsAny<Client>()), Times.Never);
            mockDepot.VerifyNoOtherCalls();
        }

        [Fact]
        public void Executer_SeuleUneAdresseAModifier_ModifieUniquementCetteAdresse()
        {
            Guid clientId = Guid.NewGuid();
            Guid adresseId1 = Guid.NewGuid();
            Guid adresseId2 = Guid.NewGuid();

            Mock<IDepotClients> mockDepot = new Mock<IDepotClients>();
            mockDepot.Setup(m => m.ListerClients()).Returns(new List<Client>()
            {
                new Client(clientId, "Nom1", "Prenom1", new List<Adresse>()
                {
                    new Adresse(adresseId1, 100, "", "ODO", "Voie", "CP", "Muni", "Etat", "canada"),
                    new Adresse(adresseId2, 100, "", "ODO", "Voie", "CP", "Muni", "Etat", "MEXIQUE"),
                }),
            });

            List<Client> clientsModifies = new List<Client>();
            mockDepot.Setup(m => m.ModifierClient(It.IsAny<Client>())).Callback<Client>(c => clientsModifies.Add(c));

            ModifierPaysMajusculesClientsTraitementLot traitement = new ModifierPaysMajusculesClientsTraitementLot(mockDepot.Object);

            traitement.Executer();

            mockDepot.Verify(m => m.ListerClients(), Times.Once);
            mockDepot.Verify(m => m.ModifierClient(It.Is<Client>(c => c.ClientId == clientId)), Times.Once);
            mockDepot.VerifyNoOtherCalls();

            Client clientModifie = Assert.Single(clientsModifies);
            Assert.Equal(2, clientModifie.Adresses.Count);

            Adresse adresse1 = Assert.Single(clientModifie.Adresses.FindAll(a => a.AdresseId == adresseId1));
            Assert.Equal("CANADA", adresse1.Pays);

            Adresse adresse2 = Assert.Single(clientModifie.Adresses.FindAll(a => a.AdresseId == adresseId2));
            Assert.Equal("MEXIQUE", adresse2.Pays);
        }
    }
}
