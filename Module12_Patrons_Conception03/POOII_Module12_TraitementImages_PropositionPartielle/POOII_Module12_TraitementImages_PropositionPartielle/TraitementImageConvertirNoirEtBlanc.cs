using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace POOII_Module11_Paint
{
    [Description("Converion N&B")]
    public class TraitementImageConvertirNoirEtBlanc : ITraitementImage
    {
        [Browsable(false)]
        public ITraitementImage Suivant { get; set; }

        public void TraiterImage(ImageManipulable p_image)
        {
            //for (int ligne = 0; ligne < p_image.Height; ligne++)
            //{
            //    for (int colonne = 0; colonne < p_image.Width; colonne++)
            //    {
            //        Color couleurPixel = p_image[colonne, ligne];
            //        int luminance = (couleurPixel.R + couleurPixel.G + couleurPixel.B) / 3;
            //        Color nouvelleCouleur = Color.FromArgb(luminance, luminance, luminance);

            //        p_image[colonne, ligne] = nouvelleCouleur;
            //    }
            //}

            byte[] raw = p_image.Raw;
            for (int longueur = 0; longueur < raw.Length / 3; longueur++)
            {
                int l3 = longueur * 3;
                byte luminance = (byte)((raw[l3] + raw[l3 + 1] + raw[l3 + 2]) / 3);
                raw[l3] = luminance;
                raw[l3 + 1] = luminance;
                raw[l3 + 2] = luminance;
            }


            this.Suivant?.TraiterImage(p_image);
        }

        public override string ToString()
        {
            return UtilitaireTraitements.DescriptionTraitement(this);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
