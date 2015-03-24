using System;

namespace Lab4
{
    public class Person
    {
        public int age;
        public string firstName;
        public string lastName;
        public Person Spouse;
        public int sAge;

        public string Create()
        {
            string firstName = Question.AskForString("What is your frist name?");
            string lastName = Question.AskForString("What is your last name?");
            int age = Question.AskForInteger("What your current age?");
            bool y = Question.AskForBoolean("Are you married?");
            if (y)
            {
                string Spouse = Question.AskForString("What is your Spouse frist name?");
                int sAge = Question.AskForInteger("What your Spouse age?");
                return firstName + lastName + age + Spouse + sAge;
            }
            else
            {
                return  firstName + lastName + age;
            }
        }

        
    }
}