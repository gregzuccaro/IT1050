using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Section 1 ====================================================================================================
            //Variable Declaration =========================================================================================

            string firstName;
            string middleName;
            string lastName;
            string fullName;

            
            System.Console.Write("What is your first name?");
            firstName = System.Console.ReadLine();

            System.Console.Write("What is your middle name?");
            middleName = System.Console.ReadLine();

            Console.Write("What is your last name?");
            lastName = System.Console.ReadLine();

            fullName = (firstName +" "+ middleName + " " + lastName);

            System.Console.WriteLine(fullName);

            //Section 2 ====================================================================================================
            //Variable Declaration ========================================================================================= 

            int heightFeet;
            double heightInches;
            double totalHeightCM;

        System.Console.Write("What is your height in feet? ");
            heightFeet = int.Parse(Console.ReadLine());

            System.Console.Write("How many inches beyond the base height in feet? ");
            heightInches = double.Parse(Console.ReadLine());

            totalHeightCM = ((heightFeet * 12) + heightInches) * 2.54;

                                             
            Console.WriteLine("Your total height in CM is " + totalHeightCM);

            //Section 3 ============================================================================================================
            //Variable Declaration =================================================================================================

            int age;
            bool isCitizen;
            bool canVote;

            System.Console.Write("How old are you? ");
            age = int.Parse(Console.ReadLine());

            System.Console.Write("Are you a citizen true or false? ");
            isCitizen = bool.Parse(Console.ReadLine());
            canVote = isCitizen && age >= 18;

            Console.WriteLine("Your voter eligibility is: " + canVote);



        }
    }
}
