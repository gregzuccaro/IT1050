
namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {

            Person greggie = new Person();
            greggie.FirstName = "Gregory";
            greggie.MiddleInitial = "J";
            greggie.LastName = "Zuccaro";


            Person farley = new Person();
            farley.FirstName = "Brandon";
            farley.MiddleInitial = "A";
            farley.LastName = "Farley";

            Console.WriteLine(greggie.GetFullName());


        }
    }
}
