namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            Order newOrder = new Order();
            newOrder.GatherDataFromUser();
            System.Console.WriteLine("Ok, " + newOrder.FirstName + " " + newOrder.LastName + " the total cost of your trip to the movies is: $" + newOrder.GetTotalCost());

            System.Console.ReadKey();

        }
    }
}
