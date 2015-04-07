using System;

namespace Lab4
{
    public class Person
    {
        public int Age;
        public string firstName;
        public string lastName;
        public Person Spouse;
        
        

        public static int Create(string prefix)  
        {
            Question.SetPromptPrefix(prefix); //added after a look at your soultion Donnie
            Person Hu = new Person(); 
            Hu.firstName = Question.AskForString("What is your frist name?");
            Hu.lastName = Question.AskForString("What is your last name?");
            Hu.Age = Question.AskForInteger("What your current age?");
            bool isMarried = Question.AskForBoolean("Are you married? Enter Y for yes");
           
            if (isMarried)
            {
                Person Spouse = new Person();
                Spouse.firstName = Question.AskForString("What is your spouse's frist name?");
                Spouse.lastName = Hu.lastName;
                Spouse.Age = Question.AskForInteger("What your spouse's current age?");
               
                return Hu.Age + Spouse.Age;
             }
            else
            {
                return Hu.Age;
            }
          }
     }
}