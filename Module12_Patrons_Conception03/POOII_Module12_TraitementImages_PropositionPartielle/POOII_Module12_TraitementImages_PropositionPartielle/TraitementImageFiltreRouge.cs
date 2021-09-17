using System;
using System.ComponentModel;
using System.Linq;

namespace POOII_Module11_Paint
{
    [Description("Filtre rouge")]
    public class TraitementImageFiltreRouge : ITraitementImage
    {
        public TraitementImageFiltreRouge()
        {
            ;
        }

        [Browsable(false)]
        public ITraitementImage Suivant { get; set; }

        public override string ToString()
        {
            return UtilitaireTraitements.DescriptionTraitement(this);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void TraiterImage(ImageManipulable p_image)
        {
            byte[] raw = p_image.Raw;
            byte[] res = new byte[raw.Length];
            int width = p_image.Width;
            int height = p_image.Height;
            int stride = p_image.Stride;
            for (int colonne = 0; colonne < width; colonne++)
            {
                for (int ligne = 0; ligne < height; ligne++)
                {
                    int debut = ligne * stride + colonne * 3;
                    res[debut + 0] = 0; //bleu
                    res[debut + 1] = 0; //vert
                    res[debut + 2] = raw[debut + 2]; //rouge
                }
            }

            Array.Copy(res, raw, raw.Length);

            this.Suivant?.TraiterImage(p_image);
        }
    }
}
