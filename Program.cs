using System;

namespace BlackJackCS
{
    class Hand
    {

    }
    class Card
    {

    }




    class Program
    {

        static string Greeting()
        {
            // Ask for users name & greet them
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();
            Console.WriteLine($"\nIts a pleasure to meet you, {userName}!");

            // Return users name
            return userName;

        }

        static void ExitMessage(string userName)
        {
            // Thank user for playing
            Console.WriteLine("\nThanks for playing our game!");
            Console.WriteLine($"Have a great day, {userName}!");
        }

        static void StartGame(string userName)
        {
            // Variable used for while loop
            var answer = false;
            var ready = false;

            // Loop to keep prompting the user until they have made a correct answer choice
            while (!answer)
            {
                // Ask user if they would like to play a game of Black Jack
                Console.WriteLine($"\n{userName}, would you like to play a game of Black Jack? (Yes/No)");
                var userAnswer = Console.ReadLine();

                // Logic to determine whether or not user wanted to play
                if (userAnswer.ToLower() == "yes" || userAnswer.ToLower() == "y")
                {
                    // Display rules
                    Console.WriteLine();
                    Rules();

                    while (!ready)
                    {
                        // Ask user if they are ready to start after displaying rules
                        Console.WriteLine("\nAre you ready to start? (Yes/No)");
                        var start = Console.ReadLine();

                        if (start.ToLower() == "yes" || start.ToLower() == "y")
                        {
                            // Display game & exit nested while loop
                            PlayGame();
                            ready = true;
                        }
                        else if (start.ToLower() == "no" || start.ToLower() == "n")
                        {
                            // Display rules
                            Console.WriteLine();
                            Rules();
                        }
                        else
                        {
                            // Display rules
                            Console.WriteLine();
                            Rules();

                            // Prints message to screen if users answer wasn't valid
                            Console.WriteLine($"\n{userName}, your answer was invalid! Please try again.");
                        }
                    }
                    // Exit while loop
                    answer = true;


                }
                else if (userAnswer.ToLower() == "no" || userAnswer.ToLower() == "n")
                {
                    // Diplay Exit message & exit while loop
                    ExitMessage(userName);
                    answer = true;
                }
                else
                {
                    // Prints message to screen if users answer wasn't valid
                    Console.WriteLine($"\n{userName}, your answer was invalid! Please try again.");
                }

            }
        }

        static void Rules()
        {
            // Rules screen
            Console.WriteLine("############################### Rules ###############################");
            Console.WriteLine("# 1) Aces always equal 11. King, Queen, and Jack are 10 all other   #");
            Console.WriteLine("# cards are equal to there printed value on the card itself.        #");
            Console.WriteLine("#                                                                   #");
            Console.WriteLine("# 2) First player with a hand value of 21 wins, unless there is a   #");
            Console.WriteLine("# tie then dealer wins.                                             #");
            Console.WriteLine("#                                                                   #");
            Console.WriteLine("# 3) You and the dealer will both be dealt 2 cards to begin with.   #");
            Console.WriteLine("# Your cards will be visible to you and you can either hit or stand #");
            Console.WriteLine("#                                                                   #");
            Console.WriteLine("# 4) Hitting will add a card from the deck to your hand and your    #");
            Console.WriteLine("# hand value will increase.                                         #");
            Console.WriteLine("#                                                                   #");
            Console.WriteLine("# 5) Standing will mean you reveal your cards and no longer have    #");
            Console.WriteLine("# the option to hit. Stand when your hand value is close to 21.     #");
            Console.WriteLine("#                                                                   #");
            Console.WriteLine("# 6) Whenever you stand, dealer reveals cards and hits until there  #");
            Console.WriteLine("# hand value is 17 or greater.                                      #");
            Console.WriteLine("#                                                                   #");
            Console.WriteLine("# 7) If you go over 21 then you bust and the dealer wins. Whenever  #");
            Console.WriteLine("# the game ends you will have to option to play again if you want.  #");
            Console.WriteLine("#####################################################################");
        }

        static void PlayGame()
        {

        }



        static void Main(string[] args)
        {
            var userName = Greeting();
            StartGame(userName);


        }
    }
}
