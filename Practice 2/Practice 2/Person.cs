namespace Practice_2
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }

     public void Speak(string whatToSay)
        {
            string output = this.FirstName;
            output += " ";
            output += this.LastName;
            output += " says, '";
            output += whatToSay;
            output += " ' ";

            System.Console.WriteLine(output);


        }


    }


}
