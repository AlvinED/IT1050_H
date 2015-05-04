using System;

namespace Lab_5_Do_Over
{
    class Course
    {
        public string cName;
        public int cIDnumber;
        public int classSize;
        public Student[] eNrolled;

        public Course(string cName, int cIDnumber, int classSize)
        {
            this.cName = Console.ReadLine();
            this.cIDnumber = int.Parse(Console.ReadLine());
            this.classSize = int.Parse(Console.ReadLine());
            this.eNrolled = new Student[this.classSize];
            for (int i = 0; i < eNrolled.Length; i++)
            {
                Student
                eNrolled[i] = makeStudent;
            }

        }
    }
}
