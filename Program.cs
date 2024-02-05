namespace GenericListExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> fruitList = new List<string>();

            Console.WriteLine("How many fruits do you want to add to the list?");
            int amount = int.Parse(Console.ReadLine()!);

            for (int i = 0; i < amount ; i++)
            {
                Console.WriteLine($"Fruit number {i+1}:");
                string fruits = Console.ReadLine()!;
                fruitList.Add(fruits);
            }
            Console.Clear();
            Console.WriteLine("The fruits added are:");
            PrintList(fruitList);
        }

        static void PrintList<T>(List<T> fruitList)
        {
            foreach (var item in fruitList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
