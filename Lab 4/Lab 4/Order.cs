namespace Lab_4
{
    class Order
    {
        public string FirstName = "";
        public string LastName = "";
        private int Adult = 0;
        private int Child = 0;
        private int Senior = 0;
        private int SmallSoda = 0;
        private int LargeSoda = 0;
        private int Hotdog = 0;
        private int Popcorn = 0;
        private int Candy = 0;

        

        public void GatherDataFromUser()
        {

            this.FirstName = Question.AskForString("What is your first name? ");
            this.LastName = Question.AskForString("What is your last name? ");
            this.Adult = Question.AskForInteger("How many adult tickets? ");
            this.Child = Question.AskForInteger("How many child tickets? ");
            this.Senior = Question.AskForInteger("How many senior tickets? ");
            this.SmallSoda = Question.AskForInteger("How many orders of small sodas ? ");
            this.LargeSoda = Question.AskForInteger("How many orders of large sodas? ");
            this.Hotdog = Question.AskForInteger("How many orders hot dogs? ");
            this.Popcorn = Question.AskForInteger("How many orders of popcorn? ");
            this.Candy = Question.AskForInteger("How many orders of candy? ");
                                                                                                     
        }

        public double GetTotalCost()
        {
            double totalCost = 0;

            totalCost += this.Adult * Cost.AdultTicketPrice;
            totalCost += this.Child * Cost.ChildTicketPrice;
            totalCost += this.Senior * Cost.SeniorTicketPrice;
            totalCost += this.SmallSoda * Cost.SmallSodaPrice;
            totalCost += this.LargeSoda * Cost.LargeSodaPrice;
            totalCost += this.Hotdog * Cost.HotDogPrice;
            totalCost += this.Popcorn * Cost.PopcornPrice;
            totalCost += this.Candy * Cost.CandyPrice;
            if(this.Popcorn > 0 && this.LargeSoda > 0)
            {
                totalCost -= 2;
                System.Console.WriteLine("Congrats! You get 2 dollars off your total cost for purchasing a popcorn and large soda.  ");
            }
            System.Console.WriteLine("====== Order Summary ====== ");
            System.Console.WriteLine();
            System.Console.WriteLine("Adult Ticket: " + this.Adult);
            System.Console.WriteLine("Senior Ticket: " + this.Senior);
            System.Console.WriteLine("Child Ticket: " + this.Child);
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
