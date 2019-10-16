using System;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            p1.GatherDataFromUser();
            p1.CreateSpouseIfMarried();
            p1.PrintNameAndAge();
            
            Person p2 = new Person();
            p2.GatherDataFromUser();
            p2.CreateSpouseIfMarried();
            p2.PrintNameAndAge();
        }
    }
}
