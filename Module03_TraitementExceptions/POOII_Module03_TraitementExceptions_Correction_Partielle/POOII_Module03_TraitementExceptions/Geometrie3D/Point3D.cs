using POOII_Module03_TraitementExceptions.Matrices;
using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module03_TraitementExceptions.Geometrie3D
{
    public class Point3D : Matrice2D
    {
        public Point3D(float p_x, float p_y, float p_z) : base(3, 1)
        {
            this.X = p_x;
            this.Y = p_y;
            this.Z = p_z;
            this.W = 1.0f;
        }

        public float X { get { this.Normaliser(); return this[0, 0]; } set => this[0, 0] = value; }                                      
        public float Y { get { this.Normaliser(); return this[1, 0]; } set => this[1, 0] = value; }                                      
        public float Z { get { this.Normaliser(); return this[2, 0]; } set => this[2, 0] = value; }                                      
        public float W { get { this.Normaliser(); return this[3, 0]; } set => this[3, 0] = value; }

        public void Normaliser()
        {
            if (this.W != 1.0f)
            {
                this.X /= this.W;
                this.Y /= this.W;
                this.Z /= this.W;
                this.W = 1.0f;
            }
        }
    }
}
