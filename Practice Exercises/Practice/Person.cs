namespace Practice
{
    class Person
    {
        //Member Variable Declaration
        //Instance Variable Declaration

        public string FirstName;
        public string MiddleIntitial;
        public string LastName;

        public string GetFullName();
        {
            return this.FirstName + " " + this.MiddleInitial + ". " + this.LastName;


        }

    }
}
