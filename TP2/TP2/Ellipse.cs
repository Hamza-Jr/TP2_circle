using System;
using System.Collections.Generic;
using System.Text;

namespace TP2
{
    internal class Ellipse
    {
        class Ellipse : Circle
        {
            private double height;
            public Ellipse(Point centre, double w, double h) : base(centre)
            {
                this.centre = centre;
                width = w;
                height = h;
            }
            public double width
            {
                get { return width; }
                set { width = value; }
            }
            public double width
            {
                get { return width; }
                set { width = value; }
            }
            public bool appartenance(double x, double y, double z)
            {
                if (((x - A) / X) * ((x - A) / X) + ((y - B) / Y) * ((y - B) / Y) + ((z - C) / Z) * ((z - C) / Z) <= ra * ra)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public double surface(Point centre, double h)
            {
                double s = Math.PI * Math.Pow(centre, 2) * h;
                return s;
            }
            public double circonf(Point centre, double h)
            {
                return (2 * Math.PI * center * h) + (2 * Math.PI * Math.Pow(centre, 2));
            }
        }
    }
}
