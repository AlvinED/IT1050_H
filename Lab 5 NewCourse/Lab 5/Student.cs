﻿using System;

namespace Lab_5
{
    class Student
    {
        private string _nAme;
        public int sIDnumber;

        public static void CreateStudent()
        {
            Student makeStudent = new Student();
            Console.WriteLine("enter student name - ");
            makeStudent._nAme = Console.ReadLine();
            Console.WriteLine("enter student ID number - ");
            makeStudent.sIDnumber = int.Parse(Console.ReadLine());
              
        }



    }
}