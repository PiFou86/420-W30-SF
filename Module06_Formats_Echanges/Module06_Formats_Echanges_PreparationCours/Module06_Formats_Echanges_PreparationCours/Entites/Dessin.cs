using System;
using System.Collections.Generic;
using System.Text;

namespace Module06_Formats_Echanges_PreparationCours.Entites
{
    public class Dessin
    {
        private List<Forme> m_formes;
        public List<Forme> Formes
        {
            get
            {
                return new List<Forme>(this.m_formes);
            }
        }

        public Dessin(IEnumerable<Forme> p_formes = null)
        {
            if (p_formes == null)
            {
                this.m_formes = new List<Forme>();
            }
            else
            {
                this.m_formes = new List<Forme>(p_formes);
            }
        }

        public void AjouterForme(Forme p_forme)
        {
            this.m_formes.Add(p_forme);
        }
    }
}
