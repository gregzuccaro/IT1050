namespace ConsoleApp3
{
    class Order
    {
        public string FirstName = "";
        public string LastName = "";
        private int AdultMatinee = 0;
        private int ChildMatinee = 0;
        private int SeniorMatinee = 0;
        private int AdultEvening = 0;
        private int ChildEvening = 0;
        private int SeniorEvening = 0;
        private int SmallSoda = 0;
        private int LargeSoda = 0;
        private int Hotdog = 0;
        private int Popcorn = 0;
        private int Candy = 0;
        private string Matinee = "";


        public void GatherDataFromUser()
        {
            this.FirstName = Question.AskForString("What is your first name? ");
            this.LastName = Question.AskForString("What is your last name? ");
            this.Matinee = Question.AskForString("Matinee Time? Y or N");


            if (this.Matinee == "Y")
            {
                this.AdultMatinee = Question.AskForInteger("How many adult matinee tickets? ");
                this.ChildMatinee = Question.AskForInteger("How many child matinee tickets? ");
                this.SeniorMatinee = Question.AskForInteger("How many senior matinee tickets? ");
            }

            else
            {
                this.AdultEvening = Question.AskForInteger("How many adult evening tickets? ");
                this.ChildEvening = Question.AskForInteger("How many child evening tickets? ");
                this.SeniorEvening = Question.AskForInteger("How many senior evening tickets? ");
            }



            this.SmallSoda = Question.AskForInteger("How many orders of small sodas ? ");
            this.LargeSoda = Question.AskForInteger("How many orders of large sodas? ");
            this.Hotdog = Question.AskForInteger("How many orders hot dogs? ");
            this.Popcorn = Question.AskForInteger("How many orders of popcorn? ");
            this.Candy = Question.AskForInteger("How many orders of candy? ");
         


        }

        public double GetTotalCost()
        {
            double totalCost = 0;

            totalCost += this.AdultMatinee * Cost.AdultTicketPriceMatinee;
            totalCost += this.ChildMatinee * Cost.ChildTicketPriceMatinee;
            totalCost += this.SeniorMatinee * Cost.SeniorTicketPriceMatinee;

            totalCost += this.AdultEvening * Cost.AdultTicketPriceEvening;
            totalCost += this.ChildEvening * Cost.ChildTicketPriceEvening;
            totalCost += this.SeniorEvening * Cost.SeniorTicketPriceEvening;



            totalCost += this.SmallSoda * Cost.SmallSodaPrice;
            totalCost += this.LargeSoda * Cost.LargeSodaPrice;
            totalCost += this.Hotdog * Cost.HotDogPrice;
            totalCost += this.Popcorn * Cost.PopcornPrice;
            totalCost += this.Candy * Cost.CandyPrice;

            if (this.Popcorn >= 1 && this.LargeSoda >= 1)
            {
                System.Console.WriteLine("Congrats, you have qualified for $2 off one movie ticket! ");
                totalCost -= 2;
            }

            if(this.AdultEvening >= 1 && this.ChildEvening >= 1 || this.SeniorEvening >= 1)
            {

                System.Console.WriteLine("Congrats, you have qualified for one free popcorn ! ");
                this.Popcorn += 1;

            }

            if(this.Candy == 3)
            {
                System.Console.WriteLine("Congrats, you have qualified for a 4th candy for free! ");
                this.Candy += 1;
            }




            System.Console.WriteLine("====== Order Summary ====== ");
            System.Console.WriteLine();
            System.Console.WriteLine("Adult Ticket Matinee: " + this.AdultMatinee);
            System.Console.WriteLine("Senior Ticket Matinee: " + this.SeniorMatinee);
            System.Console.WriteLine("Child Ticket Matinee: " + this.ChildMatinee);
            System.Console.WriteLine("Adult Ticket Evening: " + this.AdultEvening);
            System.Console.WriteLine("Senior Ticket Evening: " + this.SeniorEvening);
            System.Console.WriteLine("Child Ticket Evening: " + this.ChildEvening);

            System.Console.WriteLine("Small Soda: " + this.SmallSoda);
            System.Console.WriteLine("Large Soda: " + this.LargeSoda);
            System.Console.WriteLine("Hot Dog: " + this.Hotdog);
            System.Console.WriteLine("Popcorn: " + this.Popcorn);
            System.Console.WriteLine("Candy: " + this.Candy);
            System.Console.WriteLine();
            System.Console.WriteLine("Order Cost: $" + totalCost);
            System.Console.WriteLine("===========================");
            System.Console.WriteLine();
            return totalCost;
        }



    }
}
