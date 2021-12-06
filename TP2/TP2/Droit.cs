using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TP2
{
    public class Droit  : Point
    {
		private Point  A, B;
		public void setPoint(Point C)
		{
			A = C;
		}
		public Point getPoint()
		{
			return A;
		}
		public Droit(Point C, Point D)
		{
			A = C;
			B = D;
		}



		private static Boolean Intersection(Point X, Point Y, Point C, Point D)
		{
			//  AB  a1x + b1y = c1 
			double a1 = X.y - Y.y;
			double b1 = X.x - Y.x;
			double c1 = a1 * (X.x) + b1 * (Y.y);

			//  CD  a2x + b2y = c2 
			double a2 = C.y - D.y;
			double b2 = C.x - D.x;
			double c2 = a2 * (C.x) + b2 * (C.y);

			double determinant = a1 * b2 - a2 * b1;
			double firstcord = ((b1 * c2) - (b2 * c1) / determinant);
			double secondcord = ((a2 * c1) - (a1 * c2) / determinant);
				
			if (determinant == 0)
			{
				return false;
			}
			else
			{
				
				return true;
			}
		}
		public Boolean apartenance(Point C, Point D)
		{
			double a2 = C.y - D.y;
			double b2 = C.x - D.x;
			double c2 = a2 * (C.x) + b2 * (C.y);

			return false;
		}

	}
		



    }
}
