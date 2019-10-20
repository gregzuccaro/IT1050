
namespace Assignment_2
{
    class Person
    {
        //variables
        public int Age;
        public string FirstName;
        public string LastName;
        public Person Spouse;

        public static double SumOfAllAges;

        //methods
        public string GetFullName()
        {
            string FullName = "";
            FullName = this.FirstName + " " + this.LastName;
            return FullName;
        }

        public void GatherDataFromUser()
        {
            this.FirstName = Question.AskForString("First Name");
            this.LastName = Question.AskForString("Last Name");
            this.Age = Question.AskForInteger("What is your age? ");
           
        }

        public void CreateSpouseIfMarried()
        {
            System.Console.Write("Are you married? (y/n) : ");

            if (System.Console.ReadLine().ToLower().StartsWith("y"))
            {
                this.Spouse = new Person();
                this.Spouse.GatherDataFromUser();
                this.Spouse.Spouse = this;
            }

        public void PrintNameAndAge()
            {
                System.Console.WriteLine(this.GetFullName());
                System.Console.WriteLine(this.Age);

            }


        }




    }
}
