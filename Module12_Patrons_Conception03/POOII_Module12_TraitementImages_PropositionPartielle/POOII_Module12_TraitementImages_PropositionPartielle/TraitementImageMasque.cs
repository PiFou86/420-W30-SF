using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace POOII_Module11_Paint
{
    public abstract class TraitementImageMasque : ITraitementImage
    {
        [Browsable(false)]
        public ITraitementImage Suivant { get; set; }

        private int m_largeur = 3;
        public int Largeur
        {
            get
            {
                return this.m_largeur;
            }
            set {
                if (value < 1 || value % 2 != 1)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "La largeur doit être > 1 et impaire");
                }
                this.m_largeur = value;
            }
        }

        [Browsable(false)]
        public Func<byte[], byte> Transformation { get; set; }

        public TraitementImageMasque(Func<byte[], byte> p_transformation)
        {
            if (p_transformation is null)
            {
                throw new ArgumentNullException(nameof(p_transformation));
            }

            this.Largeur = 3;
            this.Transformation = p_transformation;
        }

        public void TraiterImage(ImageManipulable p_image)
        {
            byte[] raw = p_image.Raw;
            byte[] res = new byte[raw.Length];
            int stride = p_image.Stride;
            int width = p_image.Width;
            int height = p_image.Height;

            byte[] donneesCourantes = new byte[this.Largeur * this.Largeur];
            for (int colonne = 0; colonne < width; colonne++)
            {
                for (int ligne = 0; ligne < height; ligne++)
                {
                    for (int composante = 0; composante < 3; composante++)
                    {
                        int posDonneesCourantes = 0;
                        for (int masqueX = -this.Largeur / 2; masqueX <= this.Largeur / 2; masqueX++)
                        {
                            int posX = Math.Min(Math.Max(0, colonne + masqueX), width - 1);
                            for (int masqueY = -this.Largeur / 2; masqueY <= this.Largeur / 2; masqueY++)
                            {
                                int posY = Math.Min(Math.Max(0, ligne + masqueY), height - 1);
                                donneesCourantes[posDonneesCourantes] = raw[posY * stride + posX * 3 + composante];

                                ++posDonneesCourantes;
                            }
                        }
                        res[ligne * stride + colonne * 3 + composante] = this.Transformation(donneesCourantes);
                    }
                }
            }

            Array.Copy(res, raw, raw.Length);

            this.Suivant?.TraiterImage(p_image);
        }

        public override string ToString()
        {
            return UtilitaireTraitements.DescriptionTraitement(this);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
