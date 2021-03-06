﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class ComputerPlays
    {
        int chosenNumber;

        int guessCount = 1;

        public void NumberPicker()
        {
            Console.WriteLine("What do you want me to guess?");
            try
            {
                int pickedNumber = Convert.ToInt32(Console.ReadLine());
                if (pickedNumber > 1000 || pickedNumber < 1)
                {
                    Console.WriteLine("Number out of bounds! Try again");
                    NumberPicker();
                }
                chosenNumber = pickedNumber;
            }
            catch
            {
                Console.WriteLine("invalid entry");
                NumberPicker();

            }
        }

        public int[] Numbers()
        {
            int[] cpr = new int[1000];
            for (int i = 0; i < cpr.Length; i++)
            {
                cpr[i] = i + 1;
            }
            return cpr;
        }

        public void Game(int[] num)
        {
            
                int[] newr = new int[(num.Length / 2) + (num.Length % 2)];
                if (num.Length == 1)
                {
                    if (num[0] == chosenNumber)
                        Console.WriteLine($"The number has been found! {chosenNumber} was the number. It took me {guessCount} guesses");
                    return;
                }
                if (chosenNumber == (num[(num.Length / 2) - 1]))
                {
                    Console.WriteLine($"The number has been found! {chosenNumber} was the number. It took me {guessCount} guesses");
                    return;
                }
                if (chosenNumber > (num[(num.Length / 2) - 1]))
                {
                    Console.WriteLine($"{num[(num.Length / 2) - 1]} is too low!");
                    guessCount++;
                    for (int i = 0; i < newr.Length; i++)
                    {
                        newr[i] = num[i + num.Length / 2];
                    }

                }
                if (chosenNumber < (num[(num.Length / 2) - 1]))
                {
                    Console.WriteLine($"{num[(num.Length / 2) - 1]} is too high!");
                    guessCount++;

                    for (int i = 0; i < newr.Length; i++)
                    {
                        newr[i] = num[i];
                    }

                }
                Game(newr);
            
        }
    }
}
