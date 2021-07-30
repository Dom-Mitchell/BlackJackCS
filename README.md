# PEDA – BlackKJackCS

<!--- Now I learned some markdown its very similar to html/css for webpages --->

## P – Problem

<details>
<summary>Key:</summary>
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

Rules:
* House's (computer's) cards must always be hidden from player until time to reveal hand
* Player's (you the user's) cards must be visible to you

Player's Choices:
* Player has two choices they can either **hit** or **stand** depending on hand total
* If player has <br 21, then player can hit or stand 
* If player has = 21, then player wins unless dealer ties. 
* All ties, dealer wins
* If player has > 21, then player busts, and dealer wins

Dealer's Choices:
* Dealer should be given option to **hit**, depending on hand total
* If dealer has <br 17, then dealer can hit
* If dealers cards = 17 - 21, then dealer wins, unless dealer ties
* All ties, dealer wins
* If dealer has > 21, then dealer busts, and player wins

Gameplay:
* When player stands or bust the dealer will reveal its hand
* Player closer to 21 without going over wins
* Winner should display after each game for either the player or the house
* There should be a **replay** option  at the end of each game with a new deck of cards and hands

## E – Examples

<details>
<summary>Example 1</summary>
Player is dealt 21 on first deal, so player wins <br/>
Unless dealer also has 21
</details>  

<details>
<summary>Example 2</summary>
Player’s hand has 5 of Hearts & 10 of Clubs, so card total is 15 <br/>
Player may <strong>stand</strong> or <strong>hit</strong> <br/>
Player <strong>hits</strong> player is dealt 5 of Clubs, so hand value is now 20 <br/>
Player's hand value is now 20, so player <strong>stands</strong> <br/>
Dealer's cards are revealed <br/>
Dealer's hand has 10 of Diamonds & 6 of Hearts, so card total is 16 <br/>
Dealer must <strong>hit</strong> <br/>
Dealer <strong>hits</strong> and is dealt 2 of Clubs <br/>
Dealer's hand value is now 18 <br/>
Dealer must stand </br>
Player wins!
</details>  

## D – Data Structure

We will need a deck of 52 cards as a string, then we will parse it into an int </br>
Create ranks </br>
Create suits </br>
Merge ranks and suits into new card </br>
Add new card to a deck </br>
Shuffle cards </br>
Create a class/method to add values to the cards using int </br>
Deal two hands 1st to dealer – keep cards hidden and 2nd to player – reveal cards </br>
Assign the hands a value </br>
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