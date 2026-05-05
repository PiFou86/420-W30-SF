using Module08_Exercice01_Base_Console.Entites;
using Module08_Exercice01_Base_Console.TraitementLot.ModifierNomPrenomPremiereLettreMajuscules;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace Module08_Exercice01_Base_ConsoleTests
{
    public class ModifierNomPrenomPremiereLettreMajusculesTraitementLotTests
    {
        [Fact]
        public void Constructeur_DepotNull_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ModifierNomPrenomPremiereLettreMajusculesTraitementLot(null!));
        }

        [Fact]
        public void Executer_3Clients_2AModifier_ModifieSeulementCeuxNecessaires()
        {
            Guid clientId1 = Guid.NewGuid();
            Guid clientId2 = Guid.NewGuid();
            Guid clientId3 = Guid.NewGuid();

            Mock<IDepotClients> mockDepot = new Mock<IDepotClients>();
            mockDepot.Setup(m => m.ListerClients()).Returns(new List<Client>()
            {
                new Client(clientId1, "nom1", "prenom1", new List<Adresse>()
                {
                    CreerAdresse("Pays1"),
                    CreerAdresse("PAYS2"),
                }),
                new Client(clientId2, "Nom2", "Prenom2", new List<Adresse>()
                {
                    CreerAdresse("Pays3"),
                }),
                new Client(clientId3, "Nom3", "jean-jacques", new List<Adresse>()
                {
                    CreerAdresse("Pays4"),
                }),
            });

            List<Client> clientsModifies = new List<Client>();
            mockDepot.Setup(m => m.ModifierClient(It.IsAny<Client>())).Callback<Client>(c => clientsModifies.Add(c));

            ModifierNomPrenomPremiereLettreMajusculesTraitementLot traitement =
                new ModifierNomPrenomPremiereLettreMajusculesTraitementLot(mockDepot.Object);

            traitement.Executer();

            mockDepot.Verify(m => m.ListerClients(), Times.Once);
            mockDepot.Verify(m => m.ModifierClient(It.Is<Client>(c => c.ClientId == clientId1)), Times.Once);
            mockDepot.Verify(m => m.ModifierClient(It.Is<Client>(c => c.ClientId == clientId3)), Times.Once);
            mockDepot.Verify(m => m.ModifierClient(It.Is<Client>(c => c.ClientId == clientId2)), Times.Never);
            mockDepot.VerifyNoOtherCalls();

            Assert.Equal(2, clientsModifies.Count);

            Client client1Modifie = Assert.Single(clientsModifies.FindAll(c => c.ClientId == clientId1));
            Assert.Equal("Nom1", client1Modifie.Nom);
            Assert.Equal("Prenom1", client1Modifie.Prenom);

            Client client3Modifie = Assert.Single(clientsModifies.FindAll(c => c.ClientId == clientId3));
            Assert.Equal("Nom3", client3Modifie.Nom);
            Assert.Equal("Jean-Jacques", client3Modifie.Prenom);
        }

        [Fact]
        public void Executer_ClientsDejaConformes_AucuneModification()
        {
            Mock<IDepotClients> mockDepot = new Mock<IDepotClients>();
            mockDepot.Setup(m => m.ListerClients()).Returns(new List<Client>()
            {
                new Client(Guid.NewGuid(), "Nom1", "Prenom1", new List<Adresse>() { CreerAdresse("PAYS1") }),
                new Client(Guid.NewGuid(), "Nom2", "Prenom2", new List<Adresse>() { CreerAdresse("PAYS2") }),
            });

            ModifierNomPrenomPremiereLettreMajusculesTraitementLot traitement =
                new ModifierNomPrenomPremiereLettreMajusculesTraitementLot(mockDepot.Object);

            traitement.Executer();

            mockDepot.Verify(m => m.ListerClients(), Times.Once);
            mockDepot.Verify(m => m.ModifierClient(It.IsAny<Client>()), Times.Never);
            mockDepot.VerifyNoOtherCalls();
        }

        [Fact]
        public void Executer_NomConformePrenomNonConforme_ModifieSeulementPrenom()
        {
            Guid clientId = Guid.NewGuid();

            Mock<IDepotClients> mockDepot = new Mock<IDepotClients>();
            mockDepot.Setup(m => m.ListerClients()).Returns(new List<Client>()
            {
                new Client(clientId, "Nom", "prenom", new List<Adresse>() { CreerAdresse("PAYS1") }),
            });

            List<Client> clientsModifies = new List<Client>();
            mockDepot.Setup(m => m.ModifierClient(It.IsAny<Client>())).Callback<Client>(c => clientsModifies.Add(c));

            ModifierNomPrenomPremiereLettreMajusculesTraitementLot traitement =
                new ModifierNomPrenomPremiereLettreMajusculesTraitementLot(mockDepot.Object);

            traitement.Executer();

            mockDepot.Verify(m => m.ListerClients(), Times.Once);
            mockDepot.Verify(m => m.ModifierClient(It.Is<Client>(c => c.ClientId == clientId)), Times.Once);
            mockDepot.VerifyNoOtherCalls();

            Client clientModifie = Assert.Single(clientsModifies);
            Assert.Equal("Nom", clientModifie.Nom);
            Assert.Equal("Prenom", clientModifie.Prenom);
        }

        [Fact]
        public void Executer_AucunClient_AucuneModification()
        {
            Mock<IDepotClients> mockDepot = new Mock<IDepotClients>();
            mockDepot.Setup(m => m.ListerClients()).Returns(new List<Client>());

            ModifierNomPrenomPremiereLettreMajusculesTraitementLot traitement =
                new ModifierNomPrenomPremiereLettreMajusculesTraitementLot(mockDepot.Object);

            traitement.Executer();

            mockDepot.Verify(m => m.ListerClients(), Times.Once);
            mockDepot.Verify(m => m.ModifierClient(It.IsAny<Client>()), Times.Never);
            mockDepot.VerifyNoOtherCalls();
        }

        private static Adresse CreerAdresse(string pays)
        {
            return new Adresse(Guid.NewGuid(), 100, string.Empty, "ODO", "Voie", "CP", "Muni", "Etat", pays);
        }
    }
}
