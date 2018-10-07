using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class BasicNumber
    {
        int[] num = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int chosenNumber;
        

        public void NumberPicker()
        {
            Console.WriteLine("What number do you want?");
            int pickedNumber = Convert.ToInt32(Console.ReadLine());
            chosenNumber = pickedNumber;
        }


        public void Bisector()
        {
            if (chosenNumber == (num.Length / 2) )
            {
                Console.WriteLine($"The number has been found! {chosenNumber} was the number");
            }
            if (chosenNumber > (num.Length / 2))
            {
                Console.WriteLine($"{ num.Length / 2} is too low!");
            }
            if (chosenNumber < (num.Length/ 2))
            {
                Console.WriteLine($"{num.Length / 2} is too high!");
            }
        }
    }
}
