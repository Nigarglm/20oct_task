namespace _20oct_task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit[] Basket = new Fruit[3];
            Basket[0] = new Apple() { Price = 3, Sort = "Fuji", VitaminA = 25, VitaminB = 10 };
            Basket[1] = new Pineapple() { Price = 7, Sort = "Queen", VitaminE = 20, VitaminD = 15 };
            Basket[2] = new Orange() { Price = 4, Sort = "Navel", VitaminC = 30 };

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

    }
}