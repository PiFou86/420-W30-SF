using System;
using System.Collections.Generic;
using System.Linq;

// https://www.meme-arsenal.com/memes/dfb5aafc6f6044fa2ff9c5ecfedbbc1b.jpg
namespace POOII_Module05_Demeter_TellDontAsk_Console;

class Program
{
    static void Main(string[] args)
    {
        Polygone p = new Polygone()
        {
            Sommets = new List<Point3d>() {
                new Point3d() { X = -2, Y = -2, Z = 1},
                new Point3d() { X = 2, Y = -2, Z = 1},
                new Point3d() { X = 2, Y = 2, Z = 1},
                new Point3d() { X = -2, Y = 2, Z = 1},
            }
        };

        double a = airee(p);
        affichage_forme_g(p);
        Console.Out.WriteLine($"Aire : {a}");

        Cercle c = new Cercle()
        {
            Centre = new Point3d() { X = 1, Y = 2, Z = 3 },
            Rayon = 1
        };

        double a2 = airee(c);
        affichage_forme_g(c);
        Console.Out.WriteLine($"Aire : {a2}");
    }

    public static double dist(Point3d a, Point3d b)
    {
        double d = Math.Sqrt(Math.Pow(a.X - b.X, 2)
            + Math.Pow(a.Y - b.Y, 2)
            + Math.Pow(a.Z - b.Z, 2)
            );

        return d;
    }

    public static double airee(object obj)
    {
        switch (obj)
        {
            case Cercle c:
                return Math.Pow(c.Rayon * c.Rayon, 0.5) * Math.PI;

            case Polygone p:
                float s = 0;
                List<object> lstT = trigle(p.Sommets);
                foreach (object i in lstT)
                {
                    Triangle t = (Triangle)i;
                    s += (float)aTriangle(t);
                }
                return s;


            default:
                return -1;
        }
    }

    public static double aTriangle(object obj)
    {
        Triangle t = obj as Triangle;
        // https://en.wikipedia.org/wiki/Heron%27s_formula
        double s = (
                dist(
                new Point3d()
                {
                    X = t.Point1X,
                    Y = t.Point1Y,
                    Z = t.Point1Z
                },
                new Point3d()
                {
                    X = t.Point2X,
                    Y = t.Point2Y,
                    Z = t.Point2Z
                }
                )
                +
                dist(
                new Point3d()
                {
                    X = t.Point1X,
                    Y = t.Point1Y,
                    Z = t.Point1Z
                },
                new Point3d()
                {
                    X = t.Point3X,
                    Y = t.Point3Y,
                    Z = t.Point3Z
                }
                )
                +
                dist(
                new Point3d()
                {
                    X = t.Point2X,
                    Y = t.Point2Y,
                    Z = t.Point2Z
                },
                new Point3d()
                {
                    X = t.Point3X,
                    Y = t.Point3Y,
                    Z = t.Point3Z
                }
                )
               ) * .5;

        return Math.Sqrt(s
            * (s - dist(
                new Point3d()
                {
                    X = t.Point1X,
                    Y = t.Point1Y,
                    Z = t.Point1Z
                },
                new Point3d()
                {
                    X = t.Point2X,
                    Y = t.Point2Y,
                    Z = t.Point2Z
                }
                ))
            * (s - dist(
                new Point3d()
                {
                    X = t.Point1X,
                    Y = t.Point1Y,
                    Z = t.Point1Z
                },
                new Point3d()
                {
                    X = t.Point3X,
                    Y = t.Point3Y,
                    Z = t.Point3Z
                }
                ))
            * (s - dist(
                new Point3d()
                {
                    X = t.Point2X,
                    Y = t.Point2Y,
                    Z = t.Point2Z
                },
                new Point3d()
                {
                    X = t.Point3X,
                    Y = t.Point3Y,
                    Z = t.Point3Z
                }
                ))
                );
    }

    public static void affichage_forme_g(object obj)
    {
        switch (obj)
        {
            case Cercle c:
                Console.Out.WriteLine($"C -> Centre({c.Centre.X},{c.Centre.Y},{c.Centre.Z}) ; Rayon : {c.Rayon}");
                break;

            case Polygone p:
                p.AffConsole();
                break;
            default:
                break;
        }
    }

    private static List<object> trigle(List<Point3d> sommets)
    {
        HashSet<object> r = new HashSet<object>();
        for (int i = 0; i < sommets.Count; i++)
        {
            r.Add(new Triangle()
            {
                Point1X = sommets[i].X,
                Point1Y = sommets[i].Y,
                Point1Z = sommets[i].Z,

                Point2X = sommets[(i + 1) % sommets.Count].X,
                Point2Y = sommets[(i + 1) % sommets.Count].Y,
                Point2Z = sommets[(i + 1) % sommets.Count].Z,

                Point3X = bary(sommets).Item1,
                Point3Y = bary(sommets).Item2,
                Point3Z = bary(sommets).Item3,
            });
        }

        return r.ToList();
    }

    private static Tuple<double, double, double> bary(List<Point3d> ss)
    {
        double v1 = 0, v2 = 0, v3 = 0;

        foreach (var item in ss)
        {
            v1 += item.Y;
            v2 += item.Z;
            v3 += item.X;
        }

        return new Tuple<double, double, double>(v3 / ss.Count, v1 / ss.Count, v2 / ss.Count);
    }
}
