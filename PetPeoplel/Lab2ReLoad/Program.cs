using System;
namespace Lab2ReLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("John","Spartan");
            Person p2 = new Person("Cee", "Harns");
            Pet pt1 = new Pet("Jack", 2,"Collie",p1);
            Pet pt2 = new Pet("Sprat", 5, "Shelte", p2);
            Pet pt3 = new Pet("Lean", 5, "Pug", p2);
       
        }
    }
}
