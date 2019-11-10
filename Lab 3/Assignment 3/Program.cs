using System;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor i1 = new Instructor("John", "Default", "English");
            Instructor i2 = new Instructor("Mike", "Default","Math");

            Student s1 = new Student("Jane", "Doe", 0, i1);
            Student s2 = new Student("Joe", "Doe", 0, i1);
            Student s3 = new Student("Melissa", "Doe", 0, i2);
            Student s4 = new Student("Matt", "Doe", 0, i2);

            s1.SetGrade(s2, 90);

            i1.SetStudentGrade(s1, 95);
            i1.SetStudentGrade(s2, 85);
            i2.SetStudentGrade(s3, 90);
            i2.SetStudentGrade(s4, 92);
       
          
            s1.Print();
            i1.PrintInfo();
            s2.Print();
            i1.PrintInfo();
            s3.Print();
            i2.PrintInfo();
            s4.Print();
            i2.PrintInfo();

            System.Console.ReadKey();
        }
    }
}
