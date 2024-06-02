using System;
using ConsoleCards;

namespace ProgrammingAssignment3
{
    // IMPORTANT: Only add code in the section
    // indicated below. The code I've provided
    // makes your solution work with the 
    // automated grader on Coursera

    /// <summary>
    /// Programming Assignment 3
    /// </summary>
    class Program
    {
        /// <summary>
        /// Programming Assignment 3
        /// </summary>
        /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            // loop while there's more input
            string input = Console.ReadLine();
            while (input[0] != 'q')
            {
                // Add your code between this comment
                // and the comment below. You can of
                // course add more space between the
                // comments as needed

                // declare a deck variables and create a deck object
                // DON'T SHUFFLE THE DECK
                Deck deck = new Deck();

                // deal 2 cards each to 4 players (deal properly, dealing
                // the first card to each player before dealing the
                // second card to each player)
                /*int totalPlayer = 4;
                for(int x = 1; x<=2; x++) { 
                    for(int i = 1; i <= totalPlayer; i++)
                    {
                        Card card = deck.TakeTopCard();
                        Console.WriteLine("Player" + i  +" "+x+ " " + card.Rank + " of " + card.Suit);
                    }
				}*/

                Card card1Player1 = deck.TakeTopCard();
				Card card1Player2 = deck.TakeTopCard();
				Card card1Player3 = deck.TakeTopCard();
				Card card1Player4 = deck.TakeTopCard();
				Card card2Player1 = deck.TakeTopCard();
				Card card2Player2 = deck.TakeTopCard();
				Card card2Player3 = deck.TakeTopCard();
				Card card2Player4 = deck.TakeTopCard();


				// deal 1 more card to players 2 and 3
				Card card3Player2 = deck.TakeTopCard();
				Card card3Player3 = deck.TakeTopCard();


				// flip all the cards over
                card1Player1.FlipOver();
				card1Player2.FlipOver();
				card1Player3.FlipOver();
				card1Player4.FlipOver();
				card2Player1.FlipOver();
				card2Player2.FlipOver();
				card2Player3.FlipOver();
				card2Player4.FlipOver();
				card3Player2.FlipOver();
				card3Player3.FlipOver();

                // print the cards for player 1
                Console.WriteLine(card1Player1.Rank + "," + card1Player1.Suit);
				Console.WriteLine(card2Player1.Rank + "," + card2Player1.Suit);

				// print the cards for player 2
				Console.WriteLine(card1Player2.Rank + "," + card1Player1.Suit);
				Console.WriteLine(card2Player2.Rank + "," + card1Player1.Suit);
				Console.WriteLine(card3Player2.Rank + "," + card1Player1.Suit);

				// print the cards for player 3
				Console.WriteLine(card1Player3.Rank + "," + card1Player1.Suit);
				Console.WriteLine(card2Player3.Rank + "," + card1Player1.Suit);
				Console.WriteLine(card3Player3.Rank + "," + card1Player1.Suit);

				// print the cards for player 4
				Console.WriteLine(card1Player4.Rank + "," + card1Player1.Suit);
				Console.WriteLine(card2Player4.Rank + "," + card1Player1.Suit);

				// Don't add or modify any code below
				// this comment
				input = Console.ReadLine();
            }
        }
    }
}
