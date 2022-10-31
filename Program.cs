namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?\n");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine} Hello, {name}, on {currentDate}");
            Console.Write($"{Environment.NewLine} Press any key to exit");
            Console.ReadKey(true);
        }
    }
}