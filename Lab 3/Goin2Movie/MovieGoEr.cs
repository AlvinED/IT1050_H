using System;

namespace Goin2Movie
{
    class MovieGoEr
    {
        public int Child;
        public int Adult;
        public int Senoir;
   
        //Display methods
        public void DisplyNoCT()
        {
            Console.WriteLine("Enter the number children tickets.");
        }
        public void DisplyNoAT()
        {
            Console.WriteLine("Enter the number adult tickets.");
        }
        public void DisplyNoST()
        {
            Console.WriteLine("Enter the number senior tickets.");
        }

        // Get number of tickets
        public int GetNoCT()
        {
            int Child = int.Parse(Console.ReadLine());
            return Child;
        }
        public int GetNoAT()
        {
            int Adult = int.Parse(Console.ReadLine());
            return Adult;
        }
        public int GetNoST()
        {
            int Senior = int.Parse(Console.ReadLine());
            return Senior;
        }
    }
}
