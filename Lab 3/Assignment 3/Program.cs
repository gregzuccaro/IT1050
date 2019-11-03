using System;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor i1 = new Instructor("John", "Default", "English");
            Instructor i2 = new Instructor("Mike", "Default","Math");

            Student s1 = new Student("Jane", "Doe",75, i1);
            Student s2 = new Student("Joe", "Doe", 75, i1);
            Student s3 = new Student("Melissa", "Doe", 75, i2);
            Student s4 = new Student("Matt", "Doe", 75, i2);

            s2.SetGrade(100);

            i1.SetStudentGrade(s1, 95);
            i1.SetStudentGrade(s2, 85);
            i2.SetStudentGrade(s3, 90);
            i2.SetStudentGrade(s4, 92);

            i1.PrintInfo();
            
            s1.Print();
           

            s1.Print();
            s2.Print();
            s3.Print();
            s4.Print();

            System.Console.ReadKey();
        }
    }
}
