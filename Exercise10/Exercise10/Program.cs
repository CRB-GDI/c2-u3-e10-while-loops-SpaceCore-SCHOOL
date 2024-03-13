namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************");
            Console.WriteLine("Menu:");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("**************");
            Console.WriteLine("Make your selection now!");
            int response = int.Parse(Console.ReadLine());
            if (response == 1)
            {
                Console.WriteLine("Starting a new game!");
            }
            if (response == 2)
            {
                Console.WriteLine("File loading!");
            }
            if (response == 3)
            {
                Console.WriteLine("Loading settings...");
            }
            if (response == 4)
            {
                Console.WriteLine("Closing game.");
            }

            }
        }
    }
