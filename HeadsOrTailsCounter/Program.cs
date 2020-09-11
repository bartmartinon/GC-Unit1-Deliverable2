using System;

namespace HeadsOrTailsCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Heads or Tails Counter!");
            bool done = false;
            while (!done)
            {
                // Initialize Variables
                string headsOrTailsGuess = "none";
                int numberOfFlips = 0;
                int correctCount = 0;
                Random rnd = new Random();

                // Collect first user input: "heads" or "tails"
                Console.Write("Guess which will have more: heads or tails? ");
                headsOrTailsGuess = Console.ReadLine();

                // Check if first input is valid, if not continue the loop to "reset"
                if (!(headsOrTailsGuess.Equals("heads")) && !(headsOrTailsGuess.Equals("tails")))
                {
                    Console.WriteLine("Error: Please enter 'heads' or 'tails'");
                    continue;
                }

                // Collect second user input: number of flips
                Console.Write("How many times shall we flip a coin? ");
                numberOfFlips = int.Parse(Console.ReadLine());

                // Check if second input is valid, if not continue the loop to "reset"
                if (numberOfFlips < 1)
                {
                    Console.WriteLine("Error: Please enter a positive integer");
                    continue;
                }

                Console.WriteLine("----------");

                // Begin flipping procedure
                for (int i = 0; i < numberOfFlips; i++)
                {
                    // Flip a coin with a Random
                    int flip = rnd.Next(2);
                    if (flip == 0) // 0 is heads, increment correctCount if guess matches
                    {
                        Console.WriteLine("heads");
                        if ((headsOrTailsGuess.Equals("heads"))) correctCount++;
                    }
                    else if (flip == 1) // 1 is tails, increment correctCount if guess matches
                    {
                        Console.WriteLine("tails");
                        if ((headsOrTailsGuess.Equals("tails"))) correctCount++;
                    }
                }

                Console.WriteLine("----------");

                // Tally results
                double percentageCorrect = (double)correctCount / (double)numberOfFlips;
                int score = (int)(percentageCorrect * 100);

                // Display results to console
                Console.WriteLine("Your guess, " + headsOrTailsGuess + ", came up " + correctCount + " time(s).");
                Console.WriteLine("That's " + score + "%");

                // Ask user if they want to stop playing (if so, end the loop)
                Console.Write("Quit? (Y/N) ");
                string donePlaying = Console.ReadLine();
                if (donePlaying.Equals("Y"))
                {
                    Console.WriteLine("Thank you for playing!");
                    done = true;
                }

                Console.WriteLine("----------");
            }
        }
    }
}