using System;

namespace POOII_Module11_Paint
{
    public interface ITraitementImage : ICloneable
    {
        public void TraiterImage(ImageManipulable p_image);
        public ITraitementImage Suivant { get; set; }
    }
}
