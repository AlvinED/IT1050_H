using System;


namespace AlDeeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What time is it Mister Clock");
            Console.Write("Hit any key to continue ...");
            Console.ReadKey();
            Console.WriteLine("");
            Console.Write(DateTime.Now);
            Console.ReadKey();

        }
    }
}
