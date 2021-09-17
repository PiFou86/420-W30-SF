using System;
using System.Collections.Generic;

namespace POOII_Module01_Revisions
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoPieces();
        }


        public static void DemoPieces()
        {
            Piece valveEau = new Piece()
            {
                Description = "Valve à eau",
                NumeroSerie = "0481",
                Reference = "1234",
                Pieces = new List<Piece>()
                {
                    new PieceMoulee()
                    {
                        Description = "Base",
                        NumeroSerie = "0474",
                        Reference = "1387",
                        Pieces = new List<Piece>()
                        {
                        }
                    },
                    new Piece()
                    {
                        Description = "Système d’activation",
                        NumeroSerie = "0574",
                        Reference = "1887",
                        Pieces = new List<Piece>()
                        {
                            new PieceMoulee()
                            {
                                Description = "Pin",
                                NumeroSerie = "0974",
                                Reference = "1687",
                                Pieces = new List<Piece>()
                                {

                                }
                            },
                            new PieceUsinee()
                            {
                                Description = "Plug",
                                NumeroSerie = "0964",
                                Reference = "1657",
                                Pieces = new List<Piece>()
                                {

                                }
                            },
                            new PieceUsinee()
                            {
                                Description = "Poigné",
                                NumeroSerie = "2547",
                                Reference = "3157",
                                Pieces = new List<Piece>()
                                {

                                }
                            },
                        }
                    },
                    new Piece()
                    {
                        Description = "Couvercle latérale",
                        NumeroSerie = "0374",
                        Reference = "1987",
                        Pieces = new List<Piece>()
                        {
                            new PieceUsinee()
                            {
                                Description = "Couvercle Monobloc",
                                NumeroSerie = "9874",
                                Reference = "1257",
                                Pieces = new List<Piece>()
                                {

                                }
                            },
                            new PieceAssemblage()
                            {
                                Description = "Visse M8",
                                NumeroSerie = "3774",
                                Reference = "8757",
                                Pieces = new List<Piece>()
                                {

                                }
                            },
                            new PieceAssemblage()
                            {
                                Description = "Visse M8",
                                NumeroSerie = "3774",
                                Reference = "8757",
                                Pieces = new List<Piece>()
                                {

                                }
                            },
                            new PieceAssemblage()
                            {
                                Description = "Visse M8",
                                NumeroSerie = "3774",
                                Reference = "8757",
                                Pieces = new List<Piece>()
                                {

                                }
                            },
                            new PieceAssemblage()
                            {
                                Description = "Visse M8",
                                NumeroSerie = "3774",
                                Reference = "8757",
                                Pieces = new List<Piece>()
                                {

                                }
                            },
                        }
                    },
                    new Piece()
                    {
                        Description = "Couvercle latérale",
                        NumeroSerie = "0374",
                        Reference = "1987",
                        Pieces = new List<Piece>()
                        {
                            new PieceUsinee()
                            {
                                Description = "Couvercle Monobloc",
                                NumeroSerie = "9874",
                                Reference = "1257",
                                Pieces = new List<Piece>()
                                {

                                }
                            },
                            new PieceAssemblage()
                            {
                                Description = "Visse M8",
                                NumeroSerie = "3774",
                                Reference = "8757",
                                Pieces = new List<Piece>()
                                {

                                }
                            },
                            new PieceAssemblage()
                            {
                                Description = "Visse M8",
                                NumeroSerie = "3774",
                                Reference = "8757",
                                Pieces = new List<Piece>()
                                {

                                }
                            },
                            new PieceAssemblage()
                            {
                                Description = "Visse M8",
                                NumeroSerie = "3774",
                                Reference = "8757",
                                Pieces = new List<Piece>()
                                {

                                }
                            },
                            new PieceAssemblage()
                            {
                                Description = "Visse M8",
                                NumeroSerie = "3774",
                                Reference = "8757",
                                Pieces = new List<Piece>()
                                {

                                }
                            },
                        }
                    }
                }
            };

            Console.Out.WriteLine(valveEau);

            Console.Out.WriteLine($"{"Description".PadRight(39)} {"Référence".PadRight(10)} {"Nombre".PadRight(10)}");
            foreach (PieceBOM pieceBOM in valveEau.BOM())
            {
                Console.Out.WriteLine(pieceBOM);
            }
        }
    }
}
