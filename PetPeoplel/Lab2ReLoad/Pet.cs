using System;
namespace Lab2ReLoad
{
    class Pet
    {
        private string _name;
        private int _age;
        private string _species;
        public Person _Onwer;

        public Pet(string PTName, int PtAge, string PtSpecies, Person PtOwner)
        {
            _name = PTName;
            _age = PtAge;
            _species = PtSpecies;
            _Onwer = PtOwner;

        }
       
       public string GetPetInfo()
        {
            string PTName = this._name;
            int PtAge = this._age;
            string PtSpecies = this._species;
            string GetFullName;
            return PTName + " " + PtAge + " " + PtSpecies + " " + PtOwner;


        }       
    }
}
