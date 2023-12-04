int Wallet = 500;
Console.WriteLine("You have 500 dollars to start.");
Console.WriteLine("What are you betting on? Choose either red or black, or select numbers.");

string betInput = Console.ReadLine().ToLower();
Console.WriteLine("How much are you betting?");
string betSum = Console.ReadLine().ToLower() ;
int BetAmount = Convert.ToInt32(betSum);

Random rand = new Random();
int winningNumber = rand.Next(0, 37);
int betWinRedBlack = BetAmount * 2;


if (Wallet >= BetAmount && BetAmount > 0 && Wallet > 0)
{

    if (betInput == "red")
    {
        Console.WriteLine("Rolling...");
        double RedPotential = rand.NextDouble();

        if (RedPotential < 0.5)
        {
            Console.WriteLine("You have won " + betWinRedBlack + " dollars!"); Wallet += betWinRedBlack; Console.WriteLine("Money: " + Wallet);
        }
        else if (RedPotential > 0.5)
        {
            Console.WriteLine("You have lost " + BetAmount + " dollars!"); Wallet -= BetAmount; Console.WriteLine("Money: " + Wallet);

        }
    }

    if (betInput == "black")
    {
        Console.WriteLine("Rolling...");
        double BlackPotential = rand.NextDouble();
        if (BlackPotential > 0.5)
        {
            Console.WriteLine("You have won " + betWinRedBlack + " dollars!"); Wallet += betWinRedBlack; Console.WriteLine("Money: " + Wallet);
        }
        else if (BlackPotential < 0.5)
        {
            Console.WriteLine("You have lost " + BetAmount + " dollars!"); Wallet -= BetAmount; Console.WriteLine("Money: " + Wallet);
        }
    }
    if (betInput == "numbers")
    {
        Console.WriteLine("Which number?");
        string UserReply = Console.ReadLine();
        int userconverted = Convert.ToInt32(UserReply);
        Console.WriteLine("Rolling...");
        if (userconverted == winningNumber)

        {
            int betwin = BetAmount * 10;
            Console.WriteLine("You have won " + betwin + " dollars!"); Wallet += betwin; Console.WriteLine("Wallet: " + Wallet);
        }
        else
        {
            Console.WriteLine("Wrong number! You have lost " + BetAmount + " dollars! The correct number was " + winningNumber + "."); Wallet -= BetAmount; Console.WriteLine("Wallet: " + Wallet);
        }

    }
}
    bool falsetrue = false;
    while (!falsetrue)
    {

            Console.WriteLine("Do you wish to spin again?");
            string userReply = Console.ReadLine().ToLower();
            if (userReply == "yes")
            {
                Console.WriteLine("What are you betting on?");
                string betInput2 = Console.ReadLine();
                Console.WriteLine("How much are you betting?");
                string betSum2 = Console.ReadLine();
                int betAmount2 = Convert.ToInt32(betSum2);

                int betWinRedBlack2 = betAmount2 * 2;
                Random rand2 = new Random();
                int winningNumber2 = rand.Next(0, 37);

            if (Wallet >= betAmount2 && betAmount2 > 0 && Wallet > 0)
            {

            if (betInput2 == "red")
                {
                    Console.WriteLine("Rolling...");
                    double RedPotential2 = rand.NextDouble();

                    if (RedPotential2 < 0.5)
                    {
                        Console.WriteLine("You have won " + betWinRedBlack2 + " dollars!"); Wallet += betWinRedBlack2; Console.WriteLine("Money: " + Wallet);
                    }
                    else if (RedPotential2 > 0.5)
                    {
                        Console.WriteLine("You have lost " + betAmount2 + " dollars!"); Wallet -= betAmount2; Console.WriteLine("Money: " + Wallet);
                    }
                }


                if (betInput2 == "black")
                {
                    Console.WriteLine("Rolling...");
                    double BlackPotential2 = rand.NextDouble();
                    if (BlackPotential2 > 0.5)
                    {
                        Console.WriteLine("You have won " + betWinRedBlack2 + " dollars!"); Wallet += betWinRedBlack2; Console.WriteLine("Money: " + Wallet);
                    }
                    else if (BlackPotential2 < 0.5)
                    {
                        Console.WriteLine("You have lost " + betAmount2 + " dollars!"); Wallet -= betAmount2; Console.WriteLine("Money: " + Wallet);
                    }
                }


                if (betInput2 == "numbers")
                {

                    Console.WriteLine("Which number?");
                    string UserReply = Console.ReadLine();
                    int userconverted = Convert.ToInt32(UserReply);
                    Console.WriteLine("Rolling...");

                    if (userconverted == winningNumber2)
                    {
                        int betwin = betAmount2 * 10;
                        Console.WriteLine("You have won " + betwin + " dollars!"); Wallet += betwin; Console.WriteLine("Wallet: " + Wallet);
                    }
                    else
                    {
                        Console.WriteLine("Wrong number! You have lost " + betAmount2 + " dollars! The correct number was " + winningNumber2 + "."); Wallet -= betAmount2; Console.WriteLine("Wallet: " + Wallet);
                    }
                }
            }
            else if (userReply == "no")
            {
                falsetrue = true;
                Console.WriteLine("Be seeing you then.");
            }
        }

    }


                