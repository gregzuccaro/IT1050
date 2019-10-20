namespace Lab_2
{
    class Person
    {
        //Instance - Member variable declaration
        public int age;
        public string FirstName;
        public string LastName;
        public Person Spouse;

        public static double SumOfAllAges;

        public string GetFullName();
        {
        
        public string fullName = "";
            fullName += this.FirstName;
            fullName += " ";
            fullName += this.MiddleInitial;
            fullName += ". ";
            fullName += this.LastName;
            return fullName;


        }
        public void PrintNameAndAge()
        {
        System.Console.WriteLine(this.FirstName + " says, 'Hello'.");
        System.Console.WriteLine("My name is " + this.GetFullName());
        System.Console.WriteLine("My age is " + this.Age);


    }

    }


}
