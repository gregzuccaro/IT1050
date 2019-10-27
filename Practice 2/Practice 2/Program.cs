namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person griggie = new Person();
            griggie.FirstName = "Greg";
            griggie.LastName = "Zuccaro";
            griggie.Age = 29;

            Person sissie = new Person();
            sissie.FirstName = "Patricia";
            sissie.LastName = "Zuccaro";
            sissie.Age = 27;


            griggie.Speak("I am the smartest person in the world.");
            sissie.Speak("No that is not true.");
            System.Console.ReadKey();



        }
    }
}
