using System;
using System.Collections.Generic;
using System.Text;

namespace TP2
{
    public  class Point
    {
        //fields
        public double x, y,z;
        //constructor
        public Point(double x, double y, double z)
        {
            this.x = x;
            this.x = y;
            this.x = z;
        }

        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        //setter#
        public  void Setx(double X) 
        {
            x = X;
        }
        public void Sety(double Y)
        {
            y = Y;
        }
        public void Setz(double Z)
        {
            z = Z;
        }
        //getters 
        public double getx()
        {
            return x;
        }
        public double gety()
        {
            return y;
        }
        public double getz()
        {
            return z;
        }
        // methods 


        public double Distance(Point vec1, Point vec2)
        {
            double horizontalD = Math.Pow((vec1.x - vec2.x), 2);
            double verticallD = Math.Pow((vec1.y - vec2.y), 2);
            double zedD = Math.Pow((vec1.z - vec2.z), 2);
            double distance= Math.Pow((horizontalD+ verticallD+ zedD),1/2);
            return distance;
        }
        public bool Egaliter(Point vec1, Point vec2)
        {
            bool count =true;
            if(vec1.x == vec2.x &&  vec1.y == vec2.y && vec1.z == vec2.z) 
            {
                count=true;
            }     
            return count;
        }
         //change location of any point 
        public double  changeX(Point  vec, double cordX)
        {
            return vec.x = cordX;

        }
        public double changeY(Point vec, double cordY)
        {
            return vec.y = cordY;
        }
        public double changeZ(Point vec, double cordZ)
        {
            return vec.z = cordZ;
        }

       

        private static void displayPoint(Point p)
        {
            Console.WriteLine("(" + p.x + ", " + p.y + ")");
        }

        private static void displayPoint(Point p)
        {
            Console.WriteLine("(" + p.x + ", " + p.y + ")");
        }





    }
}
