namespace Assignment_3
{
    class Student
    {
        //Member variable declarations

        public string FirstName = null;
        public string LastName = null;
        public int Grade = 0;
        public Instructor Teacher = null;

        //Constructor
        public Student(string firstName, string lastName, int grade, Instructor teacher)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
            this.Teacher = teacher;
        }

        //methods

        public int SetGrade(Student student, int grade)
        {
            grade = this.Grade;
            System.Console.WriteLine(this.FirstName + " Assigned himself/herself the grade of: " + this.Grade);

            return this.Grade;

        }

        public void Print()
        {
        System.Console.WriteLine("Student Name: " + this.FirstName + " " + this.LastName + " Student Grade: " + this.Grade + " Teacher "+ this.Teacher);

            }

    }

}
