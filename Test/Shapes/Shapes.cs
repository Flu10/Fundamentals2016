using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shapes
    {
        public abstract double CalculareArie();
        public virtual double GetPerimetru()
        {
            return 0;
        }
        public abstract ShapeType Type{ get; }
    }
}
