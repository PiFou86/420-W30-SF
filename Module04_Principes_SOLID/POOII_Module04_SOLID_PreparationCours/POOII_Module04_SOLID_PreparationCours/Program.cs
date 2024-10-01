using POOII_Module04_SOLID_PreparationCours.ATM;
using System;

namespace POOII_Module04_SOLID_PreparationCours;

class Program
{
    static void Main(string[] args)
    {
        ExempleATM.Demo();
    }

    #region "Pour coloration"
    private System.Collections.Generic.IEnumerable<IFormeGeometrique> FormesGeometriques { get; set; }
    private void OCP_V01()
    {
        // ...
        ICalculInteret ci = null;
        decimal montant = 0;
        // ...
        if (ci is CalculInteretFixe)
        {
            CalculInteretFixe cif = (CalculInteretFixe)ci;
            cif.CalculerMontantInteretFixe(montant);
        }
        else if (ci is CalculInteretVariable)
        {
            CalculInteretVariable civ = (CalculInteretVariable)ci;
            civ.CalculerMontantInteretVariable(montant);
        }
    }

    private void OCP_V01_s01()
    {
        // ...
        ICalculInteretV2 ci = null;
        decimal montant = 0;
        // ...
        ci.CalculerMontantInteret(montant);
    }

    private void OCP_V02()
    {
        // ...
        foreach (IFormeGeometrique formeGeometrique in this.FormesGeometriques)
        {
            switch (formeGeometrique)
            {
                case Rectangle r:
                    r.DessinerRectangle();
                    break;
                case Cercle c:
                    c.DessinerCercle();
                    break;
                default:
                    break;
            }
        }
        // ...
    }

    private void OCP_V02_s01()
    {
        // ...
        foreach (IFormeGeometrique formeGeometrique in this.FormesGeometriques)
        {
            formeGeometrique.Dessiner();
        }
        // ...
    }

    private interface ICalculInteretV2
    {
        void CalculerMontantInteret(decimal montant);
    }

    private interface IFormeGeometrique
    {
        void Dessiner();
    }

    private class ICalculInteret
    {

    }

    private class CalculInteretFixe : ICalculInteret
    {
        internal void CalculerMontantInteretFixe(decimal montant)
        {
            throw new NotImplementedException();
        }
    }

    private class CalculInteretVariable : ICalculInteret
    {
        internal void CalculerMontantInteretVariable(decimal montant)
        {
            throw new NotImplementedException();
        }
    }

    private class Rectangle : IFormeGeometrique
    {
        public void Dessiner()
        {
            throw new NotImplementedException();
        }

        internal void DessinerRectangle()
        {
            throw new NotImplementedException();
        }
    }

    private class Cercle : IFormeGeometrique
    {
        public void Dessiner()
        {
            throw new NotImplementedException();
        }

        internal void DessinerCercle()
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
