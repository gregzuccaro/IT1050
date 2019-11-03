namespace Assignment_3
{
    class Student
    {
        //Member variable declarations

        public string FirstName;
        public string LastName;
        public int Grade;
        public Instructor Teacher;

        //Constructor
        public Student(string firstName, string lastName, int grade, Instructor teacher)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
            this.Teacher = teacher;
        }

        //methods

        public void SetGrade(int grade)
        {
            grade = this.Grade;
            System.Console.WriteLine(this.FirstName + " Assigned himself/herself the grade of: " + this.Grade);
        }

        public void Print()
        {
        System.Console.WriteLine("Student Name: " + this.FirstName + " " + this.LastName + " Student Grade: " + this.Grade + " Teacher "+ this.Teacher);

            }

    }

}
