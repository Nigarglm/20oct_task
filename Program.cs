namespace _20oct_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit[] Basket = new Fruit[3];
            Basket[0] = new Apple() { Price = 2, Sort = "Gala", VitaminA = 20, VitaminB = 15 };
            Basket[1] = new Pineapple() { Price = 5, Sort = "Queen", VitaminE = 10, VitaminD = 5 };
            Basket[2] = new Orange() { Price = 3, Sort = "Navel", VitaminC = 25 };

            foreach (Fruit fruit in Basket)
            {
                Type type = fruit.GetType();
                Console.WriteLine($"Type: {type.Name}");

                var fields = type.GetFields();
                foreach (var field in fields)
                {
                    var value = field.GetValue(fruit);
                    Console.WriteLine($"{field.Name}: {value}");
                }

                fruit.Taste();
                Console.WriteLine();
            }
        }


        public abstract class Fruit
        {
            public int Price { get; set; }
            public string Sort { get; set; }

            public abstract void Taste();
        }

        public class Apple : Fruit
        {
            public int VitaminA { get; set; }
            public int VitaminB { get; set; }

            public override void Taste()
            {
                Console.WriteLine("Apple taste is sweet and slightly tart.");
            }
        }

        public class Pineapple : Fruit
        {
            public int VitaminE { get; set; }
            public int VitaminD { get; set; }

            public override void Taste()
            {
                Console.WriteLine("Pineapple taste is sweet and tangy.");
            }
        }

        public class Orange : Fruit
        {
            public int VitaminC { get; set; }

            public override void Taste()
            {
                Console.WriteLine("Orange taste is tangy and sweet.");
            }
        }



    }
}