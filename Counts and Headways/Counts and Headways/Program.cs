namespace Counts_and_Headways
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello and Welcome!");
            System.Console.Write("How many passengers were on the bus?       ");
            int numberOfPassengers = int.Parse(Console.ReadLine());

                   if (numberOfPassengers == 0)
                    {
                System.Console.WriteLine("The Bus is empty today!  Let's designate this as Category A which means that there were zero passengers on the bus. ");
                    }
                    else if (numberOfPassengers > 1 && numberOfPassengers < 5)
                    {
                System.Console.WriteLine("Wow, small turn-out today.  Let's designate this as Category B which means that there were a small number of passengers on the bus.");
                   else if (numberOfPassengers > 5 && numberOfPassengers < 10)
                      {
                    System.Console.WriteLine("OK, Medium turn-out today.  Let's designate this as Category C which means that there were a medium number of passengers on the bus.")
                        

                   else if (numberOfPassengers > 10)
                {
                        System.Console.WriteLine("All Aboard! A large turn-out today.  Let's designate this as Category D which means that there were a large number of passengers on the bus.");

                   


                }


            }





    }
}
