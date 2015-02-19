using System;
namespace Lab2ReLoad
{

    
    class Program
    {
        static void Main(string[] args)
        {
            // Owner
            Person p1 = new Person();
            p1.givenName = "John";
            p1.surName = "Spartan";
    
            Person p2 = new Person();
            p2.givenName = "Cee";
            p2.surName = "Harns";

            //Pets
            Pet pt1 = new Pet();
            pt1.age = 10;
            pt1.name = "Jack";
            pt1.species = "Lab";
            pt1.Onwer = p1;
            
            Pet pt2 = new Pet();
            pt2.age = 3;
            pt2.name = "Sprat";
            pt2.species = "Sheltie";
            pt2.Onwer = p2;
           
            Pet pt3 = new Pet();
            pt3.age = 5;
            pt3.name = "NoFat";
            pt3.species = "German Shepherd";
            pt3.Onwer = p2;

            Console.WriteLine(" Owner          Pet Info");
            Console.WriteLine(p1.GetFullName() + "  "+ pt1.GetInFo());
            Console.WriteLine(p2.GetFullName() + "     " + pt2.GetInFo());
            Console.WriteLine(p2.GetFullName() + "     " + pt3.GetInFo());
            Console.ReadLine();






            
        }
    }
}
