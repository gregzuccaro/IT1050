namespace Assignment_3
{
    class Instructor
    {
        //Member variable declarations

        private string FirstName = "null";
        private string LastName = "null";
        private string CourseName = "null";

        //Constructor
        public Instructor(string firstName, string lastName, string courseName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CourseName = courseName;
        }


        //methods
      
        public void SetStudentGrade(Student student, int grade)
        {
            student.Grade = grade;
            System.Console.WriteLine(this.FirstName + " assigned the grade of: " + student.Grade + " to student: " + student.FirstName);

        }

        public void PrintInfo()
        {
            System.Console.WriteLine("Instructor First Name: " + this.FirstName + " Instructor Last Name: " + this.LastName + " Instructor Course Name " + this.CourseName);


        }






    }
}
