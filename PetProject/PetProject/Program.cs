using System;

namespace PetProject
{
    class Program
    {
        static void Main(string[] args)
        {


            PetOwner Donnie = new PetOwner("Donnie", 41, Loki);
            PetOwner Amber = new PetOwner("Amber", 41, Milo, Otis);



            PetOwner Donnie = new PetOwner("Donnie", 41, Loki);
            PetOwner Amber = new PetOwner("Amber", 41, Milo, Otis);

        


            Donnie.PrintAllInfo();
            Amber.PrintAllInfo();




            


        }
    }
}
