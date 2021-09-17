using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;

namespace POOII_Module11_Paint
{
    [Description("Seuil luminance")]
    public class TraitementImageSeuilLuminance : ITraitementImage
    {
        [Browsable(false)]
        public ITraitementImage Suivant { get; set; }
        public byte Seuil { get; set; }

        public void TraiterImage(ImageManipulable p_image)
        {
            byte[] raw = p_image.Raw;
            int height = p_image.Height;
            int width = p_image.Width;
            int stride = p_image.Stride;
            for (int ligne = 0; ligne < height; ligne++)
            {
                for (int colonne = 0; colonne < width; colonne++)
                {
                    int debut = ligne * stride + colonne * 3;
                    byte luminance = (byte)((  raw[debut]
                                             + raw[debut + 1] 
                                             + raw[debut + 2]) / 3);
                    byte valeur = 0;
                    if (luminance > this.Seuil)
                    {
                        valeur = 255;
                    }
                    raw[debut] = valeur;
                    raw[debut + 1] = valeur;
                    raw[debut + 2] = valeur;
                }  
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
