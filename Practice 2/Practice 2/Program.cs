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

            int sum1 = griggie.AddTwoIntegers(9, 2);
            int sum2 = griggie.AddTwoIntegers(5, 9);
            int sum3 = griggie.AddTwoIntegers(7, 7);



           System.Console.WriteLine("The Name of griggie is: " + griggie.GetFullName());
            System.Console.WriteLine("The result of the integers that griggie added together is: " + sum1 + " " + sum2 + " " +  sum3);
            System.Console.ReadKey();


        }
    }
}
