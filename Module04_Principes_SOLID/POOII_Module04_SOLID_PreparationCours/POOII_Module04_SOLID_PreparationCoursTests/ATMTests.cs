using System;
using Xunit;
using POOII_Module04_SOLID_PreparationCours.ATM;
using POOII_Module04_SOLID_PreparationCours.ATM.Comptes;
using POOII_Module04_SOLID_PreparationCours.ATM.Tiroir;
using POOII_Module04_SOLID_PreparationCours.ATM.Transactions;
using Moq;

namespace POOII_Module04_SOLID_PreparationCoursTests
{
    public class ATMTests
    {
        [Fact]
        public void ctor_TiroirNull_Excpetion()
        {
            Mock<ICreateurTransaction> createurTransaction = new Mock<ICreateurTransaction>();

            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => new ATM(null, createurTransaction.Object));
            Assert.Equal("p_tiroirArgent", ex.ParamName);
        }

        [Fact]
        public void ctor_CreateurTransactionNull_Excpetion()
        {
            Mock<ITiroirArgent> tiroirArgent = new Mock<ITiroirArgent>();

            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => new ATM(tiroirArgent.Object, null));
            Assert.Equal("p_createurTransaction", ex.ParamName);
        }

        [Fact]
        public void Retirer_CompteNull_Exception()
        {
            // Arrange
            ICompte compte = null;
            decimal montant = 100;
            Mock<ITiroirArgent> tiroirArgent = new Mock<ITiroirArgent>();
            Mock<ICreateurTransaction> createurTransaction = new Mock<ICreateurTransaction>();
            ATM atm = new ATM(tiroirArgent.Object, createurTransaction.Object);

            // Act
            // Assert
            Assert.Throws<ArgumentNullException>(() => atm.Retirer(compte, montant));
        }

        [Fact]
        public void Retirer_MontantNegatif_Exception()
        {
            // Arrange
            Mock<ICompte> compte = new Mock<ICompte>();
            decimal montant = -100;
            Mock<ITiroirArgent> tiroirArgent = new Mock<ITiroirArgent>();
            Mock<ICreateurTransaction> createurTransaction = new Mock<ICreateurTransaction>();
            ATM atm = new ATM(tiroirArgent.Object, createurTransaction.Object);

            // Act
            // Assert
            Assert.Throws<ArgumentException>(() => atm.Retirer(compte.Object, montant));
        }

        [Fact]
        public void Retirer_TransactionNonValide_AucuneAction()
        {
            // Arrange
            Mock<ICompte> compte = new Mock<ICompte>();
            decimal montant = 100;
            Mock<ITiroirArgent> tiroirArgent = new Mock<ITiroirArgent>();

            Mock<ITransaction> transaction = new Mock<ITransaction>();
            Mock<ICreateurTransaction> createurTransaction = new Mock<ICreateurTransaction>();
            createurTransaction.Setup(c => c.CreerTransactionRetirer(compte.Object, montant)).Returns(transaction.Object);
            ATM atm = new ATM(tiroirArgent.Object, createurTransaction.Object);
            transaction.Setup(t => t.EstValide()).Returns(false);

            // Act
            atm.Retirer(compte.Object, montant);

            // Assert
            transaction.Verify(t => t.EstValide(), Times.Once);
            transaction.VerifyNoOtherCalls();
            tiroirArgent.VerifyNoOtherCalls();
        }

        [Fact]
        public void Retirer_TransactionValideExceptionDurantTransaction_TransactionAnnulee()
        {
            // Arrange
            Mock<ICompte> compte = new Mock<ICompte>();
            decimal montant = 100;
            Mock<ITiroirArgent> tiroirArgent = new Mock<ITiroirArgent>();

            Mock<ITransaction> transaction = new Mock<ITransaction>();
            Mock<ICreateurTransaction> createurTransaction = new Mock<ICreateurTransaction>();
            createurTransaction.Setup(c => c.CreerTransactionRetirer(compte.Object, montant)).Returns(transaction.Object);
            ATM atm = new ATM(tiroirArgent.Object, createurTransaction.Object);
            transaction.Setup(t => t.EstValide()).Returns(true);
            transaction.Setup(t => t.ExecuterTransaction()).Throws<Exception>();

            // Act
            atm.Retirer(compte.Object, montant);

            // Assert
            transaction.Verify(t => t.EstValide(), Times.Once);
            transaction.Verify(t => t.ExecuterTransaction(), Times.Once);
            transaction.Verify(t => t.Annuler(), Times.Once);
            transaction.VerifyNoOtherCalls();
            tiroirArgent.VerifyNoOtherCalls();
        }

        public void Retirer_TransactionValideExceptionDurantLaDistributionArgent_TransactionAnnulee()
        {
            // Arrange
            Mock<ICompte> compte = new Mock<ICompte>();
            decimal montant = 100;
            Mock<ITiroirArgent> tiroirArgent = new Mock<ITiroirArgent>();

            Mock<ITransaction> transaction = new Mock<ITransaction>();
            Mock<ICreateurTransaction> createurTransaction = new Mock<ICreateurTransaction>();
            createurTransaction.Setup(c => c.CreerTransactionRetirer(compte.Object, montant)).Returns(transaction.Object);
            ATM atm = new ATM(tiroirArgent.Object, createurTransaction.Object);
            transaction.Setup(t => t.EstValide()).Returns(true);
            tiroirArgent.Setup(t => t.DistribuerArgent(montant)).Throws<Exception>();

            // Act
            atm.Retirer(compte.Object, montant);

            // Assert
            transaction.Verify(t => t.EstValide(), Times.Once);
            transaction.Verify(t => t.ExecuterTransaction(), Times.Once);
            transaction.Verify(t => t.Annuler(), Times.Once);
            transaction.VerifyNoOtherCalls();
            tiroirArgent.Verify(tiroirArgent => tiroirArgent.DistribuerArgent(montant), Times.Once);
            tiroirArgent.VerifyNoOtherCalls();
        }

        public void Retirer_TransactionValideFonctionnementTiroirOk_ArgentDistribue()
        {
            // Arrange
            Mock<ICompte> compte = new Mock<ICompte>();
            decimal montant = 100;
            Mock<ITiroirArgent> tiroirArgent = new Mock<ITiroirArgent>();

            Mock<ITransaction> transaction = new Mock<ITransaction>();
            Mock<ICreateurTransaction> createurTransaction = new Mock<ICreateurTransaction>();
            createurTransaction.Setup(c => c.CreerTransactionRetirer(compte.Object, montant)).Returns(transaction.Object);
            ATM atm = new ATM(tiroirArgent.Object, createurTransaction.Object);
            transaction.Setup(t => t.EstValide()).Returns(true);

            // Act
            atm.Retirer(compte.Object, montant);

            // Assert
            transaction.Verify(t => t.EstValide(), Times.Once);
            transaction.Verify(t => t.ExecuterTransaction(), Times.Once);
            transaction.VerifyNoOtherCalls();
            tiroirArgent.Verify(tiroirArgent => tiroirArgent.DistribuerArgent(montant), Times.Once);
            tiroirArgent.VerifyNoOtherCalls();
        }
    }
}
