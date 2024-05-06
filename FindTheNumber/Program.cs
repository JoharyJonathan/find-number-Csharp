using System;

namespace FindTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Trouver le nombre";

            bool win = false;
            Random rand = new Random();
            int number = rand.Next(1, 101);
            int count = 0;

            while (!win)
            {
                try
                {
                    Console.WriteLine("Entrez un nombre entre 1 et 100");
                    int test = int.Parse(Console.ReadLine());

                    if (test == number)
                    {
                        count++;
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.WriteLine("Felicitations, vous avez trouver le nombre en " + count + " coups !");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;
                        win = true;
                    }
                    else if (test < number)
                    {
                        Console.WriteLine("Le nombre " + test + " est trop petit");
                        count++;
                    }
                    else if (test > number)
                    {
                        Console.WriteLine("Le nombre " + test + " est trop grand");
                        count++;
                    }
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Ce n'est pas un nombre");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            Console.Read();
        }
    }
}
