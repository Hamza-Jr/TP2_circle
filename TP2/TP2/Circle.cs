using System;
using System.Collections.Generic;
using System.Text;

namespace TP2
{
    
        class Circle : Point
        {
            private Point centre;
            private double rayon;

            public double Rayon
            {
                get { return rayon; }
                set { rayon = value; }
            }

            public Point Centre
            {
                get { return centre; }
                set { centre = value; }
            }

            public Circle(Point centre, double rayon) : base(x, y, z)
            {
                this.centre = centre;
                this.rayon = rayon;
            }
            public double Surface()
            {
                return Math.PI * rayon * rayon;
            }

            public double circonferance()
            {
                return Math.PI * 2 * rayon;
            }

            public double Distance(Point centre)
            {
                double Distance = Math.Sqrt(Math.Pow(centre.X - p.X, 2) + Math.Pow(centre.Y - p.Y, 2) + Math.Pow(centre.Z - p.Z, 2));
                return Distance;
            }

            public bool appartient(Point Pt)
            {
                if (Pt.Distance(centre) <= rayon)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public bool inters(Point p)
            {
                if ()
                    return true;
                else
                    return false;
            }
        }
}
