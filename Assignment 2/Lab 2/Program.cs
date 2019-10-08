using System;

namespace Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Spouse = new Person();

            Console.WriteLine("Enter your first name. ");
            p1.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your last name. ");
            p1.LastName = Console.ReadLine();
            Console.WriteLine("Enter your age. ");
            p1.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your spouse's first name. ");
            p1.Spouse.FirstName = Console.ReadLine();

            Person p2 = new Person();
            p2.Spouse = new Person();

            Console.WriteLine("Enter your first name. ");
            p2.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your last name. ");
            p2.LastName = Console.ReadLine();
            Console.WriteLine("Enter your age. ");
            p2.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your spouse's first name. ");
            p2.Spouse.FirstName = Console.ReadLine();
          



        }
    }
}
