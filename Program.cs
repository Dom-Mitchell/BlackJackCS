using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BlackJackCS
{
    class Card
    {

        // public string Deck { get; set; }
        public string Suit { get; set; }
        public string Face { get; set; }

        static void Value()
        {

        }

        // static List<string> ShuffleDeck()
        // {
        //     // Variables
        //     // index & deck
        //     var i = 0;
        //     var deck = DeckCreation();

        //     // Shuffling deck
        //     for (i = deck.Count - 1; i >= 0; i--)
        //     {
        //         // indexTwo equal to random # in range 0 to i
        //         var indexTwo = new Random().Next(0, i);

        //         // Swap i of deck with indexTwo
        //         var swapCards = deck[i];
        //         deck[i] = deck[indexTwo];
        //         deck[indexTwo] = swapCards;
        //     }

        //     // Print shuffled deck to screen
        //     // Test Case
        //     foreach (var shuffledCard in deck)
        //     {
        //         //Console.WriteLine($"{shuffledCard}");
        //     }

        //     // Returns shuffled deck
        //     return deck;
        // }





    }

    class Hand
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
            // Variable used for while loops
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
            // Variable used for while loop
            var quitGame = false;

            while (!quitGame)
            {
                //DealCards();
                var handValue = 0;
                Console.WriteLine($"\nWould you like to HIT or STAND? You hand value is {handValue}");
                var usersChoice = Console.ReadLine();


                if (usersChoice.ToLower() == "h" || usersChoice.ToLower() == "hit")
                {
                    //DealCards();
                    Console.WriteLine($"\nYou have decided to HIT. Your new hand value is {handValue}");
                }
                else if (usersChoice.ToLower() == "s" || usersChoice.ToLower() == "stand")
                {
                    Console.WriteLine($"\nYou have decided to STAND. Your hand value is {handValue}");
                }
                else
                {
                    // Prints message to screen if users answer wasn't valid
                    Console.WriteLine($"\nYour answer was invalid! Please try again.");
                }
                quitGame = true;

            }

        }

        static List<Card> DeckCreation()
        {
            // Variables
            // 52 cards in a deck
            // 4 suits
            // 13 cards per suit
            // var deck = new List<Card>();
            var suits = new List<string>();
            var ranks = new List<string>();
            var i = 0;

            // Loop to add values to suites list
            for (i = 0; i < 4; i++)
            {
                // Logic to check if the suites are already in list
                if (!suits.Contains("Clubs") || !suits.Contains("Diamonds") || !suits.Contains("Hearts") || !suits.Contains("Spades"))
                {
                    suits.Add("Clubs");
                    suits.Add("Diamonds");
                    suits.Add("Hearts");
                    suits.Add("Spades");
                }
            }

            // Loop to add values to ranks list
            for (i = 0; i < 13; i++)
            {
                // Logic to check if the ranks are already in list
                if (!ranks.Contains("Ace") || !ranks.Contains("2") || !ranks.Contains("3") || !ranks.Contains("4") || !ranks.Contains("5") || !ranks.Contains("6") || !ranks.Contains("7") || !ranks.Contains("8") || !ranks.Contains("9") || !ranks.Contains("10") || !ranks.Contains("Jack") || !ranks.Contains("Queen") || !ranks.Contains("King"))
                {
                    ranks.Add("Ace");
                    ranks.Add("2");
                    ranks.Add("3");
                    ranks.Add("4");
                    ranks.Add("5");
                    ranks.Add("6");
                    ranks.Add("7");
                    ranks.Add("8");
                    ranks.Add("9");
                    ranks.Add("10");
                    ranks.Add("Jack");
                    ranks.Add("Queen");
                    ranks.Add("King");
                }
            }


            var deck = new List<Card>();
            // Loop to make deck with suites and values/ranks
            foreach (var cardRanks in ranks)
            {
                foreach (var cardSuits in suits)
                {
                    // Formatting cards in deck & adding them to the list
                    var card = new Card() { Suit = string.Join(", ", suits), Face = string.Join(", ", ranks) };
                    // Test Case
                    //Console.WriteLine($"{card}");
                    deck.Add(card);
                }
            }

            // Returns deck fully formatted
            return deck;
        }



        static void Main(string[] args)
        {
            var userName = Greeting();
            StartGame(userName);


            // PlayGame();
        }
    }
}
