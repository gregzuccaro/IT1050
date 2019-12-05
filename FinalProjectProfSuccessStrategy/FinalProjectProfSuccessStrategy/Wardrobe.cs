namespace FinalProjectProfSuccessStrategy
{
    class Wardrobe
    {
        //VARIABLES

        //name - member variables

        private string firstName;
        private string lastName; 

        //foot wear - member variables
        private int flipFlops;
        private int tennisShoes;
        private int dressShoes;
        private int highHeels;
        private int crocks;
        private int sandals;
        private int boots;

         //pants - member variables
        private int jeans;
        private int kakis;        
        private int suitPants;
        private int sweatPants;
        private int swishPants;
        private int gymShorts;
        private int dressSkirt;
        private int fancyDress;

        //shirt - member variables
        private int blazer;
        private int collarShirt;
        private int teeShirt;
        private int tie;
        private int dressJacket;
        private int tuxedoShirt;

        //METHODS


        public void gatherDataFromUser()
        {
            this.firstName = Question.AskForString("Hello Sir or Ma'am, what is your first name? ");
            this.lastName = Question.AskForString("Thank you for that, what is your last name? ");


            this.flipFlops = Question.AskForInteger("If you are wearing flip flops press 1 if not press 0 ");
            this.tennisShoes = Question.AskForInteger("If you are wearing tennis shoes press 1 if not press 0 ");
            this.dressShoes = Question.AskForInteger("If you are wearing dress shoes press 1 if not press 0 ");
            this.highHeels = Question.AskForInteger("If you are wearing high heels press 1 if not press 0 ");
            this.crocks = Question.AskForInteger("If you are wearing crocks press 1 if not press 0 ");
            this.sandals = Question.AskForInteger("If you are wearing sandals press 1 if not press 0 ");
            this.boots = Question.AskForInteger("If you are wearing boots press 1 if not press 0 ");

            this.jeans = Question.AskForInteger("If you are wearing jeans press 1 if not press 0 ");
            this.kakis = Question.AskForInteger("If you are wearing kakis press 1 if not press 0 ");
            this.suitPants = Question.AskForInteger("If you are wearing suit pants press 1 if not press 0 ");
            this.sweatPants = Question.AskForInteger("If you are wearing sweat pants press 1 if not press 0 ");
            this.swishPants = Question.AskForInteger("If you are wearing swish pants press 1 if not press 0 ");
            this.gymShorts = Question.AskForInteger("If you are wearing gym shorts press 1 if not press 0 ");
            this.dressSkirt = Question.AskForInteger("If you are a dress skirt press 1 if not press 0 ");
            this.fancyDress = Question.AskForInteger("If you are wearing a fancy dress press 1 if not press 0 ");

            this.blazer = Question.AskForInteger("If you are wearing a blazer press 1 if not press 0 ");
            this.collarShirt = Question.AskForInteger("If you are wearing a collared shirt press 1 if not press 0 ");
            this.teeShirt = Question.AskForInteger("If you are wearing a tee-shirt press 1 if not press 0 ");
            this.tie = Question.AskForInteger("If you are wearing a tie press 1 if not press 0 ");
            this.dressJacket = Question.AskForInteger("If you are wearing a dress jacket press 1 if not press 0 ");
            this.tuxedoShirt = Question.AskForInteger("If you are wearing a tuxedo shirt press 1 if not press 0 ");
        }

        public double calculateValue()
        {
            double totalValue = 0;
            totalValue += this.flipFlops * Score.flipFlops;
            totalValue += this.tennisShoes * Score.tennisShoes;
            totalValue += this.dressShoes * Score.dressShoes;
            totalValue += this.highHeels * Score.highHeels;
            totalValue += this.crocks * Score.crocks;
            totalValue += this.sandals * Score.sandals;
            totalValue += this.boots * Score.boots;

            totalValue += this.jeans * Score.jeans;
            totalValue += this.kakis * Score.kakis;
            totalValue += this.suitPants * Score.suitPants;
            totalValue += this.sweatPants * Score.sweatPants;
            totalValue += this.swishPants * Score.swishPants;
            totalValue += this.gymShorts * Score.gymShorts;
            totalValue += this.dressSkirt * Score.dressSkirt;
            totalValue += this.fancyDress * Score.fancyDress;

            totalValue += this.blazer * Score.blazer;
            totalValue += this.collarShirt * Score.collarShirt;
            totalValue += this.teeShirt * Score.teeShirt;
            totalValue += this.tie * Score.tie;
            totalValue += this.dressJacket * Score.dressJacket;
            totalValue += this.tuxedoShirt * Score.tuxedoShirt;
            System.Console.WriteLine("Ok, " + this.firstName + " " + this.lastName + " Your total score is: " + totalValue);
            if (totalValue < 10)
            {
                System.Console.WriteLine("You are not dressed very well for work or your social occasion!");
            }
            else
            {
                System.Console.WriteLine("You are dressed very well! ");

            }



            return totalValue;




        }



    }
}
 