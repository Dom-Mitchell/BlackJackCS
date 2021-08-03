using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BlackJackCS
{
    class Card
    {
        // Card objects
        public string Rank { get; set; }
        public string Suit { get; set; }

        // Method to determine the value of a card
        public int Value()
        {

            // Set cards equal to there values
            switch (Rank)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                    // Ranks equal to printed value
                    return int.Parse(Rank);

                case "Jack":
                case "Queen":
                case "King":
                    // Royalty all equal to 10
                    return 10;

                case "Ace":
                    return 11;

                default:
                    // Not a card
                    return 0;
            }

        }

        // Method to format the deck to show point value of a card
        override public string ToString()
        {
            // Format cards for readability
            return $"The {Rank} of {Suit}";
        }

    }

    class Hand
    {
        // Hand objects
        public List<Card> IndividualCards { get; set; } = new List<Card>();

        public void Receive(Card newCard)
        {
            // Add this card to the hand
            IndividualCards.Add(newCard);
        }

        public int TotalHandValue()
        {
            // Variables
            var HandValue = 0;

            // Find the hand value from the value of the card(s) added together
            foreach (var card in IndividualCards)
            {
                HandValue += card.Value();
            }

            // Returns total hand value
            return HandValue;
        }

        public void PrintCardsAndTotal(string handName)
        {
            // Prints cards for dealer OR player
            Console.WriteLine($"\n{handName}, your cards are:");
            Console.WriteLine(String.Join("\n", IndividualCards));

            // Prints total value of hand
            Console.WriteLine($"The total value of your hand is: {TotalHandValue()}");

        }

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
            // Variables used for while loops
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

        static List<Card> DeckCreation()
        {
            // Variables
            // 52 cards in a deck
            // 4 suits
            // 13 cards per suit
            var deck = new List<Card>();
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

            // Loop to make deck with suites and values/ranks
            foreach (var cardRanks in ranks)
            {
                foreach (var cardSuits in suits)
                {
                    // Formatting cards in deck & adding them to the list
                    var card = new Card() { Rank = cardRanks, Suit = cardSuits };
                    // Test Case
                    //Console.WriteLine($"{card.Rank} of {card.Suit}");
                    deck.Add(card);
                }
            }
            // Returns deck to card class
            return deck;
        }

        static List<Card> ShuffleDeck()
        {
            // Variables
            // index & deck
            var i = 0;
            var deck = DeckCreation();

            // Shuffling deck
            for (i = deck.Count - 1; i >= 0; i--)
            {
                // indexTwo equal to random # in range 0 to i
                var indexTwo = new Random().Next(0, i);

                // Swap i of deck with indexTwo
                var swapCards = deck[i];
                deck[i] = deck[indexTwo];
                deck[indexTwo] = swapCards;
            }

            // Print shuffled deck to screen
            // Test Case
            foreach (var shuffledCard in deck)
            {
                //Console.WriteLine($"{shuffledCard.Rank} of {shuffledCard.Suit}");
            }

            // Returns shuffled deck to card class
            return deck;
        }

        static Tuple<Hand, Hand> DealFirstTwoCards(List<Card> deck)
        {
            // Variables used for indexing List of Card
            var i = 0;
            var card = deck[i];

            // Variables to create hand for player & house
            var player = new Hand();
            var house = new Hand();

            // Give player starting cards
            for (i = 0; i < 2; i++)
            {
                card = deck[i];
                // Test Case
                //Console.WriteLine($"{card.Rank} of {card.Suit}");
                deck.Remove(card);
                player.Receive(card);

            }

            // Give house starting cards
            for (i = 0; i < 2; i++)
            {
                card = deck[i];
                // Test Case
                //Console.WriteLine($"{card.Rank} of  {card.Suit}");
                deck.Remove(card);
                house.Receive(card);
            }

            // Format both players cards into tuple to return house & player
            var playersCards = Tuple.Create(player, house);

            // Test Case
            //Console.WriteLine(deck.Count);

            // Returns both players starting cards
            return playersCards;
        }

        static void PlayGame()
        {
            // Variables used for while loop
            var usersChoice = "";
            var quitGame = false;

            // Logic to determine if user want to continue playing
            while (!quitGame)
            {
                Console.Clear();

                // Variables used to create & shuffle a deck of cards then deal 2 cards to start game
                var deck = ShuffleDeck();
                var hands = DealFirstTwoCards(deck);

                // Variables used to grab player & dealer first 2 cards
                var playerHand = hands.Item1;
                var dealerHand = hands.Item2;

                // Logic to determine if user has busted & when they choose to stand
                while (playerHand.TotalHandValue() < 21 && usersChoice.ToLower() != "stand" || usersChoice.ToLower() != "s")
                {
                    // Show Player there cards
                    playerHand.PrintCardsAndTotal("Player");

                    // Test Case
                    //playerHand.PrintCardsAndTotal("House");

                    // Prompt user to hit or stand
                    Console.WriteLine($"\nWould you like to HIT or STAND? (Hit/Stand");
                    usersChoice = Console.ReadLine();

                    // Logic to determine if user chose hit or stand
                    if (usersChoice.ToLower() == "h" || usersChoice.ToLower() == "hit")
                    {
                        // User decides to hit
                        Console.WriteLine($"\n\nYou have decided to HIT.");

                        // Take a new card out of deck
                        var newCard = deck[0];
                        deck.Remove(newCard);

                        // Put that new card into players hand & display player hand
                        playerHand.Receive(newCard);
                        playerHand.PrintCardsAndTotal("Player");

                        // Test Case
                        //Console.WriteLine(deck.Count);
                    }
                    // Logic to determine if user chose hit or stand
                    else if (usersChoice.ToLower() == "s" || usersChoice.ToLower() == "stand")
                    {
                        // User decided to stand
                        Console.WriteLine($"\n\nYou have decided to STAND.");

                        // Display players hand
                        playerHand.PrintCardsAndTotal("Player");

                        // Test Case
                        //Console.WriteLine(deck.Count);
                    }
                    else
                    {
                        // Prints message to screen if users answer wasn't valid
                        Console.WriteLine($"\nYour answer was invalid! Please try again.");
                    }

                    // Make dealer draw until they have 17 or more as there hand value
                    while (playerHand.TotalHandValue() <= 21 && dealerHand.TotalHandValue() <= 17)
                    {
                        // Take a card out of deck
                        var card = deck[0];
                        deck.Remove(card);

                        // Add that card to dealers hand
                        dealerHand.Receive(card);

                    }

                    // Display dealers hand
                    dealerHand.PrintCardsAndTotal("Dealer");

                    // Logic to determine different game outcomes
                    if (playerHand.TotalHandValue() > 21)
                    {
                        // User has busted
                        Console.WriteLine("\nYou have BUSTED, Dealer wins!");
                        break;
                    }
                    else if (dealerHand.TotalHandValue() > 21)
                    {
                        // Dealer has busted
                        Console.WriteLine("\nDealer has BUSTED, You win!");
                        break;
                    }
                    else if (dealerHand.TotalHandValue() > playerHand.TotalHandValue())
                    {
                        // Dealers hand value is greater than players
                        Console.WriteLine("\nDealer's hand is GREATER, Dealer wins!");
                        break;
                    }
                    else if (playerHand.TotalHandValue() > dealerHand.TotalHandValue())
                    {
                        // Players hand value is greater than dealers
                        Console.WriteLine("\nYour hand is GREATER, You win!");
                        break;
                    }
                    else
                    {
                        // Player and dealer have tied
                        Console.WriteLine("\nYou have TIED, Dealer wins!");
                        break;
                    }
                }

                // Prompt user to play again
                Console.WriteLine("\nWould you like to play again? (Yes/No)");
                var answer = Console.ReadLine();
                Console.WriteLine();

                // Logic to determine if user wanted to play again
                if (answer.ToLower() == "yes" || answer.ToLower() == "y")
                {
                    // User wanted to play again so game continues
                    quitGame = false;
                }
                else if (answer.ToLower() == "no" || answer.ToLower() == "n")
                {
                    // User wanted to quit so game ends
                    quitGame = true;
                }
                else
                {
                    // Prints message to screen if users answer wasn't valid
                    Console.WriteLine($"\nYour answer was invalid! Please try again.");
                }

            }

        }


        static void Main(string[] args)
        {
            // Call play game method
            PlayGame();
        }
    }
}
