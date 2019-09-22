using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring Variables  
            string firstName;
            string middleInitial;
            string lastName;
            string fullName;
            int age;
            bool isCitizen;
            bool canVote;
            int heightFeet;
            double heightinches;
            double totalHeightCM;

            Console.Write("What is your first name?");
            firstName = Console.ReadLine();
            Console.Write("What is your middle initial?");
            middleInitial = Console.ReadLine();
            Console.Write("What is your last name?");
            lastName = Console.ReadLine();
            fullName = firstName + " " + middleInitial + ". " + lastName;

            //part two

            Console.Write("How many feet tall are you, rounding off the inches?");
            heightFeet = int.Parse(Console.ReadLine());

            Console.Write("How many inches do you extend beyond that base height?");
            heightinches = double.Parse(Console.ReadLine());

            totalHeightCM = ((heightFeet * 12) + (heightinches)) * 2.54;
            //part three
            Console.Write("Nice to meet you " + fullName + "; what is your age, friend?");
            age = int.Parse(Console.ReadLine());
            Console.Write("Are you a US citizen?");
            isCitizen = bool.Parse(Console.ReadLine());
            canVote = isCitizen && age >= 18;

            Console.WriteLine(fullName);
            Console.WriteLine(totalHeightCM);
            Console.WriteLine(canVote);

            System.Threading.Thread.Sleep(10000);
        }
    }
}