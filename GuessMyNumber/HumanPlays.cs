using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class HumanPlays
    {
        Random rnd = new Random();

        int numberToGuess;

        int guessCount = 1;

        public void NumberPicker()
        {
            numberToGuess = rnd.Next(1, 1001);
        }

        public void GuessingGame()
        {
            Console.WriteLine("What's my number, human?");
            try
            {
                int humanGuess = Convert.ToInt32(Console.ReadLine());
                if (humanGuess > 1000 || humanGuess < 1)
                {
                    Console.WriteLine("That number is out of the limits of this game");
                    GuessingGame();
                }
                if (humanGuess == numberToGuess)
                {
                    Console.WriteLine($"Good job, human, you guessed my number in {guessCount} guesses!");
                    return;
                }
                if (humanGuess > numberToGuess)
                {
                    Console.WriteLine("You guessed too high, humman!");
                    guessCount++;
                    GuessingGame();
                }
                if (humanGuess < numberToGuess)
                {
                    Console.WriteLine("You guessed too low, human!");
                    guessCount++;
                    GuessingGame();
                }
            }
            catch
            {
                Console.WriteLine("Nice try, human. That isn't a number...");
            }
        }
    }
}
