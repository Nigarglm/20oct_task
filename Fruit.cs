using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20oct_task
{
    public abstract class Fruit
    {
        public int Price { get; set; }
        public string Sort { get; set; }

        public abstract void Taste();
    }
}
