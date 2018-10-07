using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class ComputerPlays
    {
        int chosenNumber;

        public void NumberPicker()
        {
            Console.WriteLine("What do you want me to guess?");
            try
            {
                int pickedNumber = Convert.ToInt32(Console.ReadLine());
                if (pickedNumber > 10 || pickedNumber < 1)
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
    }
}
