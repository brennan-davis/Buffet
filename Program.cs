namespace Buffet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Goofy Goobers! We offer an all-you-can-eat Ice Cream Buffet for only $9.99 per person! We do have a party limit of 6 Goobers. How many Goofy Goobers will be dining in your party today?");
            Console.Write("Party Size: ");
            int partySize = int.Parse(Console.ReadLine());

            if(partySize  <= 6)
            {
                Console.WriteLine("---\nPlease, follow me to your table.\n---");

                Console.WriteLine("Hello, my name is Patrick Starr and I'll be your server today. Please know water is free, but we do charge $2.00 extra for soda and $3.00 extra for an ice cream float.\n---");

                int soda = 0;
                int iceCreamFloat = 0;
                int water = 0;

                for (int i = 0; i < partySize; i++)
                {
                    Console.WriteLine($"So, Goofy Goober {i + 1}, what will you have to drink?");
                    string drink = "water";
                    bool validDrink = true;
                    do
                    {
                        drink = Console.ReadLine();
                        if (drink.ToLower() == "soda")
                        {
                            soda++;
                        }
                        else if (drink.ToLower() == "ice cream float")
                        {
                            iceCreamFloat++;
                        } else if(drink.ToLower() == "water")
                        {
                            water++;
                        } else
                        {
                            Console.WriteLine("Sorry, that drink isn't available on our menu, please choose either water, soda, or an ice cream float.");
                            validDrink = false;
                        };
                    } while (validDrink == false);
                    Console.WriteLine($"{char.ToUpper(drink[0]) + drink.Substring(1).ToLower()}, great choice!\n");
                }

                Console.WriteLine($"Wonderful! So that's gonna be {water} waters, {soda} sodas, and {iceCreamFloat} ice cream floats. I'll be right back! Go ahead and grab your spoons and get ready for the goofy goober song and buffet!");
                Console.WriteLine("\n--- 45 Minutes Later ---\n");

                double buffets = partySize * 9.99;
                double sodas = soda * 2.00;
                double floats = iceCreamFloat * 3.00;
                double total = buffets + sodas + floats;

                Console.WriteLine($"We hope you all had the goofiest of times! Your bill total is ${total}.");
            } else
            {
                Console.WriteLine("\nI'm sorry, we don't have the space to accomodate that many Goobers at once. Maybe try making reservations at Weenie Hut Junior's next door.");
            }
        }
    }
}