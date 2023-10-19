using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20oct_task
{
    public class Pineapple:Fruit
    {
        public int VitaminE { get; set; }
        public int VitaminD { get; set; }

        public override void Taste()
        {
            Console.WriteLine("Nisbeten tursh dadir.");
        }
    }
}
