using System;

namespace Lab_5_Do_Over
{
    class Student
    {
        private string _nAme;
        public int sIDnumber;

        public Student(string _nAme, int sIDnumber)
        {
            this._nAme = Console.ReadLine();
            this.sIDnumber = int.Parse(Console.ReadLine());

        }


    }
}
