# PEDA – BlackKJackCS

## P – Problem

<details>
<summary>Key</summary>
single player = the user <br/>
house = computer
</details>    

We want to play a single player (you the user) game of BlackJack against the house (computer), with the following requirements/constants:

<!--- (This is what we know) --->

Deck:

* The deck has to be 52 cards and it has ranks and suits
* Suits are "Clubs", "Diamonds", "Hearts", or "Spades"
* Ranks are "Ace/11", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack/10", "Queen/10", "King/10"
* "Ace" is **always** 11
* "King", "Queen", and "Jack"  are always 10

Both Player's Deck:
* House's (computer's) cards must always be hidden from player until time to reveal hand
* Player's (you the user's) cards must be visible to you

Player's Choices:
* Player has two choices they can either **hit** or **stand** depending on hand total
* If player has < 21, then player can hit or stand 
* If player has = 21, then player wins unless dealer ties. 
* All ties, dealer wins
* If player has > 21, then player busts, and dealer wins

Dealer's Choices:
* Dealer should be given option to **hit**, depending on hand total
* If dealer has < 17, then dealer can hit
* If dealers cards = 17 - 21, then dealer wins, unless dealer ties
* All ties, dealer wins
* If dealer has > 21, then dealer busts, and player wins

Gameplay:
* When player stands or bust the dealer will reveal its hand
* Player closer to 21 without going over wins
* Winner should display after each game for either the player or the house
* There should be a **replay** option  at the end of each game with a new deck of cards and hands

## E – Examples

If player is dealt 21 on first deal – player wins
Player’s hand has 5hearts & 10Clubs – card total is 15 o Player may STAND or HIT – HITS o Player dealt 5clubs – hand value is now 20 o Player hand value is now 20 and STANDS o Dealer cards are revealed o Dealer hand totals 16 with a 10diamonds & 6hearts o Dealer must hit and next card revealed o Dealer is dealt a 2clubs – hand total is now 18 o Dealer must stand and player wins

## D – Data Structure

We will need a deck of 52 cards as a string and parsed into int o Create ranks o Create suits o Merge ranks and suits into new card o Add new card to a deck
Shuffle cards
Create a class/method to add values to the cards using int
Deal two hands o 1st dealer – keep cards hidden o 2nd player – reveal cards
Assign the hands a value
Value for hand will display either STAND, HIT, or WINNER

## A – Algorithm

Create Cards a. List of ranks b. List of suits c. Merge these two list to create Newcards d. Add new cards a deck
Assign Cards a value
Create 2 hands a. 1 – player b. 1 – dealer
Deal cards into both hands a. Player cards shown b. Dealers cards hidden
Depending on card total a. Player will choose to stand i. Revealing dealer card b. Player will choose to hit i. Adding and showing new card to player’s hand
Player will bust if card value > 21 and BUSTED will display
Player will choose to HIT or STAND if card value is < 21
Player will win if card value = 21 and dealer does not tie, and WINNER will display c. Dealer will choose to HIT i. Adding and showing new card to dealers hand
If total card value is < 17 a. Dealer will bust if card value > 21 and BUSTED will display d. Dealer will choose to STAND i. If total card value is > 17 Dealer will STAND
Dealer will win if card value >17 & <= 21 and card value exceeds players card value
dealer wins all ties
WINNER will display e. At end of game - display option to play again i. Shuffle deck ii. Deal two new hands

## C - Code

<details>
<summary>Click here to see!</summary>
Not yet no sneak peeks for you!
</details>    