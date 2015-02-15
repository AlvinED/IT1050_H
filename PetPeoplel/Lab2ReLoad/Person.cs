using System;

namespace Lab2ReLoad
{
    class Person
    {
        private String _givenName;
        private String _surName;
        public static Person Owner { get; set; }

        /// instantiate person
        public Person(String FirstName, String LastName)
        {
            _givenName = FirstName;
            _surName = LastName;
        }

        public String GetFullName()
        {
            String firstname = this._givenName;
            String lastname = this._surName;
            return firstname + " " + lastname;

        }
                      
    }
}
