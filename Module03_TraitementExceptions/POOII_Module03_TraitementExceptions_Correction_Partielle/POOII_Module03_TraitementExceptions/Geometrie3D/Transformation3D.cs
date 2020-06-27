using POOII_Module03_TraitementExceptions.Matrices;
using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module03_TraitementExceptions.Geometrie3D
{
    public static class Transformation3D
    {
        public static Matrice2D Translation(float p_x, float p_y, float p_z)
        {
            Matrice2D transformation = new Matrice2D(new float [,] {
                { 1.0f, 0.0f, 0.0f, p_x},
                { 0.0f, 1.0f, 0.0f, p_y},
                { 0.0f, 0.0f, 1.0f, p_z},
                { 0.0f, 0.0f, 0.0f, 1.0f},
            });

            return transformation;
        }

        public static Matrice2D MiseALEchelle(float p_sx, float p_sy, float p_sz)
        {
            Matrice2D transformation = new Matrice2D(new float[,] {
                { p_sx, 0.0f, 0.0f, 0.0f},
                { 0.0f, p_sy, 0.0f, 0.0f},
                { 0.0f, 0.0f, p_sz, 0.0f},
                { 0.0f, 0.0f, 0.0f, 1.0f},
            });

            return transformation;
        }
        public static Matrice2D RotationX(float p_theta)
        {
            float costheta = (float)Math.Cos(p_theta);
            float sintheta = (float)Math.Sin(p_theta);

            Matrice2D transformation = new Matrice2D(new float[,] {
                { 1.0f, 0.0f, 0.0f, 0.0f},
                { 0.0f, costheta, -sintheta, 0.0f},
                { 0.0f, sintheta, costheta, 0.0f},
                { 0.0f, 0.0f, 0.0f, 1.0f},
            });

            return transformation;
        }
        public static Matrice2D RotationY(float p_theta)
        {
            float costheta = (float)Math.Cos(p_theta);
            float sintheta = (float)Math.Sin(p_theta);

            Matrice2D transformation = new Matrice2D(new float[,] {
                { costheta, 0.0f, sintheta, 0.0f},
                { 0.0f, 1.0f, -0.0f, 0.0f},
                { -sintheta, 0.0f, costheta, 0.0f},
                { 0.0f, 0.0f, 0.0f, 1.0f},
            });

            return transformation;
        }
        public static Matrice2D RotationZ(float p_theta)
        {
            float costheta = (float)Math.Cos(p_theta);
            float sintheta = (float)Math.Sin(p_theta);

            Matrice2D transformation = new Matrice2D(new float[,] {
                { costheta, -sintheta, 0.0f, 0.0f},
                { sintheta, costheta, 0.0f, 0.0f},
                { 0.0f, 0.0f, 1.0f, 0.0f},
                { 0.0f, 0.0f, 0.0f, 1.0f},
            });

            return transformation;
        }
    }
}
