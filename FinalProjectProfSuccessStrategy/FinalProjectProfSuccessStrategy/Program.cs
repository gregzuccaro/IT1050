using System;

namespace FinalProjectProfSuccessStrategy
{
    class Program
    {
        static void Main(string[] args)
        {

            Wardrobe clothes = new Wardrobe();

            clothes.gatherDataFromUser();
            clothes.calculateValue();




        }
    }
}
