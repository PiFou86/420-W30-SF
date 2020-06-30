using Module06_Formats_Echanges_PreparationCours.Depots;
using Module06_Formats_Echanges_PreparationCours.Depots.JSON;
using Module06_Formats_Echanges_PreparationCours.Depots.XML.FormatAttributs;
using Module06_Formats_Echanges_PreparationCours.Depots.XML.FormatElements;
using Module06_Formats_Echanges_PreparationCours.Entites;
using System;
using System.Collections.Generic;
using System.IO;

namespace Module06_Formats_Echanges_PreparationCours
{
    class Program
    {
        static void Main(string[] args)
        {
            Dessin dessin = GenererDessin();

            string nomFichier = "donnee"; //Path.GetTempFileName();


            DepotDessin ddAttributs = new DepotDessinXMLFormatAttributs(nomFichier + "_attributs.xml");
            ddAttributs.EnregistrerDessin(dessin);
            Dessin dessinLuAttributs = ddAttributs.LireDepot();

            DepotDessin ddElements = new DepotDessinXMLFormatElements(nomFichier + "_elements.xml");
            ddElements.EnregistrerDessin(dessin);
            Dessin dessinLuElement = ddElements.LireDepot();
            
            DepotDessin ddJSON = new DepotDessinJSON(nomFichier + ".json");
            ddJSON.EnregistrerDessin(dessin);
            Dessin dessinLuJSON = ddJSON.LireDepot();

        }

        public static Dessin GenererDessin()
        {
            Dessin dessin = new Dessin();
            dessin.AjouterForme(
                new Polygone(new List<Point2D>()
                {
                    new Point2D() { X = -1, Y = -1 },
                    new Point2D() { X = 1, Y = -1 },
                    new Point2D() { X = 0, Y = 1 },
                }
                )
            );

            dessin.AjouterForme(
                new Polygone(new List<Point2D>()
                {
                    new Point2D() { X = 0, Y = 0 },
                    new Point2D() { X = 2, Y = 2 },
                    new Point2D() { X = 0, Y = 4 },
                    new Point2D() { X = -2, Y = -2 },
                }
                )
            );

            dessin.AjouterForme(new Cercle(new Point2D() { X = 0, Y = 0 }, 5));

            return dessin;
        }
    }
}
