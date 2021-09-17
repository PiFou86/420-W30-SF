using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POOII_Module01_Revisions
{
    public class Piece
    {
        // Correction partielle portant sur l'algorithmique
        // Encapsultation non effectuée dans cette correction partielle (ie à faire !)
        public string Description { get; set; }
        public string NumeroSerie { get; set; }
        public string Reference { get; set; }
        public List<Piece> Pieces { get; set; }

        public Piece()
        {
            this.Pieces = new List<Piece>();
        }

        public List<PieceBOM> BOM()
        {
            List<Piece> pieces = new List<Piece>();
            this.ApplatirArbre_rec(this, pieces);

            List<PieceBOM> piecesResume =
                pieces
                .GroupBy(p => p.Reference)
                .Select(gp => new PieceBOM()
                {
                    Reference = gp.Key,
                    Description = gp.First().Description,
                    Nombre = gp.Count()
                })
                .OrderBy(pb => pb.Reference)
                .ToList();

            return piecesResume;
        }

        public override string ToString()
        {
            return this.ToString_rec(this, 0);
        }

        private string ToString_rec(Piece p_piece, int p_niveau)
        {
            string res = "".PadLeft(p_niveau * 2) + $"Pièce : {p_piece.Description}, part - #{p_piece.Reference}, numéro série -  #{p_piece.NumeroSerie}" + System.Environment.NewLine;

            foreach (Piece sousPiece in p_piece.Pieces)
            {
                res += this.ToString_rec(sousPiece, p_niveau + 1);
            }

            return res;
        }

        private void ApplatirArbre_rec(Piece p_piece, List<Piece> p_listeSortie)
        {
            p_listeSortie.Add(p_piece);

            foreach (Piece piece in p_piece.Pieces)
            {
                ApplatirArbre_rec(piece, p_listeSortie);
            }
        }
    }
}
