namespace Topic_2_Attempt_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // first math problem
            Console.WriteLine("How much money will I earn working for 8 hours, if I was working for $21/hour?");
            Console.WriteLine((21 * 8).ToString("C"));
            Console.WriteLine();
            // second math problem
            Console.WriteLine("If a dozen eggs cost $6, how much does each individual egg cost?");
            Console.WriteLine((6.00 / 12).ToString("C"));
            Console.WriteLine();
            // third math problem
            Console.WriteLine("What would the tax be on an item costing $79.99?");
            Console.WriteLine((79.99 * 1.13).ToString("C"));
            Console.WriteLine();
            // fourth math problem
            Console.WriteLine("How many centimetres are in 5 feet 6 inches");
            Console.WriteLine("There are 12 inches in 1 foot");
            Console.WriteLine("There are ~2.54 centimetres in 1 inch");
            Console.WriteLine("There are " + 5 * 12 + " inches in 5 feet");
            Console.WriteLine("There are " + (5 * 12 + 6) + " inches in 5 feet 6 inches");
            Console.WriteLine("Now to find out how many centimetres are in those amount of inches:");
            Console.WriteLine(Math.Round((5 * 12 + 6) * 2.54, 2));
        }
    }
}
