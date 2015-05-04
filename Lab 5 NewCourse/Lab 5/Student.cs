using System;

namespace Lab_5
{
    class Student
    {
        private string _nAme;
        public int sIDnumber;
        public Student(string _nAme, int sIDnumber);

        public Student  CreateStudent()
        {
            Student makeStudent = new Student();
            Console.WriteLine("enter student name - ");
            makeStudent._nAme = Console.ReadLine();
            Console.WriteLine("enter student ID number - ");
            makeStudent.sIDnumber = int.Parse(Console.ReadLine());
            return makeStudent;
              
        }



    }
}
