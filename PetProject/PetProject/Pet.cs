namespace PetProject
{
    class Pet
    {
        //member variables
        private string name;
        private int age;
        private string breed;


        //constructor

        public Pet (string Name, int Age, string Breed)
        {
            Name = name;
            Age = age;
            Breed = breed;
        }



        //methods

        public void PrintInfo()
        {
            System.Console.WriteLine(this.name + this.age + this.breed);

        }





       




}
}