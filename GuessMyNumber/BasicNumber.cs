using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class BasicNumber
    {
        int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int chosenNumber;
        

        public void NumberPicker()
        {
            Console.WriteLine("What number do you want?");
            int pickedNumber = Convert.ToInt32(Console.ReadLine());
            chosenNumber = pickedNumber;
        }


        public void Bisector(int[] num)
        {
            if (chosenNumber == (num.Length / 2) )
            {
                Console.WriteLine($"The number has been found! {chosenNumber} was the number");
            }
            if (chosenNumber > (num.Length / 2))
            {
                Console.WriteLine($"{ num.Length / 2} is too low!");
                int[] newr = new int[(num.Length / 2) - 1];
                for (int i = 0; i < newr.Length; i++)
                {
                    newr[i] = num[i + num.Length / 2];
                }
                Bisector(newr);
            }
            if (chosenNumber < (num.Length/ 2))
            {
                Console.WriteLine($"{num.Length / 2} is too high!");
                int[] newr = new int[(num.Length / 2) - 1];
                for (int i = 0; i < newr.Length; i++)
                {
                    newr[i] = num[i];
                }
                Bisector(newr);
            }
        }
    }
}
