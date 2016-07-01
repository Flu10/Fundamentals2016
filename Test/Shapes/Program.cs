using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle gigi = new Rectangle(2, 4);

            Console.WriteLine((int)gigi.Type);

            Console.WriteLine("numar instantiere "+Rectangle.NumberOfInstances);
            gigi.Length = 2;
            gigi.Width = 5;
            Console.WriteLine(gigi.ToString());
            var rectangle = new Rectangle(2,3);
            Console.WriteLine(Rectangle.NumberOfInstances);
            Console.Read();
        }
    }
}
