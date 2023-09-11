namespace Enum
{
    enum Beverage 
    {
        Coffee,
        Tea,
        Water,
        Soda,
        Juice
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the awsome vending machine!");
            Console.WriteLine("Which beverage do you prefere? (Coffee, Tea, Water, Soda, Juice)");

            string userInput = Console.ReadLine();

            switch (userInput.ToLower())
            {
                case "coffee":
                    Respond(Beverage.Coffee);

                    break;

                case "tea":
                    Respond(Beverage.Tea);
                    break;

                case "water":
                    Respond(Beverage.Water);
                    break;

                case "soda":
                    Respond(Beverage.Soda);
                    break;

                case "juice":
                    Respond(Beverage.Juice);
                    break;


                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }

            Console.ReadKey();
        }

        static void Respond(Beverage drink)
        {
            switch (drink)
            {
                case Beverage.Coffee:
                    Console.WriteLine("You orderd coffee!");
                    break;
                case Beverage.Tea:
                    Console.WriteLine("You orderd tea!");
                    break;
                case Beverage.Water:
                    Console.WriteLine("You orderd water!");
                    break;
                case Beverage.Soda:
                    Console.WriteLine("You orderd soda!");
                    break;
                case Beverage.Juice:
                    Console.WriteLine("You orderd juice!");
                    break;
                
            }
        }
    }
}