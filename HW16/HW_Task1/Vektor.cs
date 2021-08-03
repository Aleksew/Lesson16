using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Task1
{
    public struct Vektor
    {
        public Point start;
        public Point finish;

        public Vektor(Point start, Point finish)
        {
            this.start = start;
            this.finish = finish;
        }

        public static Vektor operator +(Vektor v1, Vektor v2)
        {
            int x1 = v1.finish.x - v1.start.x;
            int y1 = v1.finish.y - v1.start.y;

            int x2 = v1.finish.x + (v2.finish.x - v2.start.x);
            int y2 = v1.finish.y + (v2.finish.y - v2.start.y);

            return new Vektor(new Point(v1.start.x, v1.start.y), new Point(x2, y2));
        }
        public static Vektor operator -(Vektor v1, Vektor v2)
        {
            int x1 = v1.finish.x + v1.start.x;
            int y1 = v1.finish.y + v1.start.y;

            int x2 = v1.finish.x - (v2.finish.x - v2.start.x);
            int y2 = v1.finish.y - (v2.finish.y - v2.start.y);

            return new Vektor(new Point(v1.start.x, v1.start.y), new Point(x2, y2));
        }
        public static double operator *(Vektor v1, Vektor v2)
        {
            int x1 = v1.finish.x - v1.start.x;
            int y1 = v1.finish.y - v1.start.y;

            int x2 = v2.finish.x - v2.start.x;
            int y2 = v2.finish.y - v2.start.y;

            return (x1 * x2) + (y1 * y2);
        }
    }
}
