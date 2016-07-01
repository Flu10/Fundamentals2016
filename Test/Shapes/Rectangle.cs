using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle:Shapes
    {
        private double length;
        private double width;
        public override double GetPerimetru()
        {
            return (length+width)*2;
        }
        public override ShapeType Type
        {
            get
            {
                return ShapeType.Rectangle;
            }
        }
        public override double CalculareArie()
        {
            return length * width;
        }
       
        public Rectangle(double length, double width)
        {
            NumberOfInstances++;
            this.length = length;
            this.width = width;

        }
        public static int NumberOfInstances;

        public double Width
        {
            get { return width; }
            set
            {
                if (value > length)
                    Console.WriteLine("Dreptunghiul nu e valid ");
                else
                    width = value;
            }

        }
        public double Length
        {
            get { return length; }
            set { length = value; }



        }


        public override string ToString()
        {
            return String.Format("Perimetru: {0}", 2 * (length + width));
        }
    }
}
