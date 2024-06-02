using System;

namespace Exercise8
{
    /// <summary>
    /// Exercise 8 solution
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Demonstrates rolling and using two dice
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // initialize random number generator
            RandomNumberGenerator.Initialize();

            // create two dice
            Die dieOne = new Die();
            Die dieTwo = new Die();

            // tell the dice to roll themselves
            dieOne.Roll();
            dieTwo.Roll();
            // print the top sides and the sum of the dice
            int sumOfDieTopValue = dieOne.TopSide + dieTwo.TopSide;
            Console.WriteLine("First Die Top Side : " + dieOne.TopSide);
            Console.WriteLine("Second Die Top Side " + dieTwo.TopSide);
            

            Console.WriteLine("Sum of Dice: " + sumOfDieTopValue);
        }
    }
}
