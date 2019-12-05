namespace PetProject
{
    class PetOwner
    {
        //initialize member variables

        private string fullName;
        private int age;
        private Pet pet1;
        private Pet pet2;
        private Pet pet3;

 
        //constructor

        public PetOwner(string name, int Age, Pet Pet1, Pet Pet2, Pet Pet3)
        {
            name = this.fullName;
            Age = this.age;
            Pet Pet1 = this.pet1;
            Pet Pet2 = this.pet2;
            Pet Pet3 = this.pet3;


        }





        //methods



        public void GetName()
        {
            System.Console.WriteLine("The Pet Owner's name is " + this.fullName);
        }

        public int GetAge()
        {
            System.Console.WriteLine("The Pet Owner's age is " + this.age);
            return this.age;
        }


        public void PrintAllInfo()
        {
            System.Console.WriteLine(this.name + this.age + pet1 + pet2 + pet3);

        }








    }
}
