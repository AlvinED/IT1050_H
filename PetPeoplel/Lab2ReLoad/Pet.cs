using System;
namespace Lab2ReLoad
{
    class Pet
    {
        public string name;
        public int age;
        public string species;
        public Person Onwer;
        
        public string GetInFo()
        {
            return " " + name + " " + age +" " + species;

        }

           
    }
}
