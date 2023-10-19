using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20oct_task
{
    public class Orange:Fruit
    {
        public int VitaminC { get; set; }

        public override void Taste()
        {
            Console.WriteLine("Biraz shirin ve biraz tursh dadir.");
        }
    }
}
