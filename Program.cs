namespace Topic_7._2___Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Favourite Food
            for (int i = 1; i <= 10; i = i + 1)
                Console.WriteLine(i + "." + " Pizza is delicious");
                Console.WriteLine();
            // Counting Machine
            int count;
            Console.WriteLine("What number would you like me to count to?");
            Int32.TryParse(Console.ReadLine(), out count);
            Console.WriteLine();
            for (int i = 1; i <= count; i = i + 1)
                Console.WriteLine(i);
            Console.WriteLine();

            // Counting Machine Revisited
            int start, finish, increase;
            Console.WriteLine("Count from:");
            Int32.TryParse(Console.ReadLine(), out start);
            Console.WriteLine("Count to:");
            Int32.TryParse(Console.ReadLine(), out finish);
            Console.WriteLine("Count by:");
            Int32.TryParse(Console.ReadLine(), out increase);
            Console.WriteLine();
            for (int i = start; i <= finish; i = i + increase)
                Console.WriteLine(i);

           
        }
    }
}
