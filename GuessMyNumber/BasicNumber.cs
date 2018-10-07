using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class BasicNumber
    {
        
        int chosenNumber;
        

        public void NumberPicker()
        {
            Console.WriteLine("What number do you want?");
            int pickedNumber = Convert.ToInt32(Console.ReadLine());
            chosenNumber = pickedNumber;
        }


        public void Bisector(int[] num)
        {
            int[] newr = new int[(num.Length / 2)];
            if (num.Length == 1)
            {
                if (num[0] == chosenNumber)
                    Console.WriteLine($"The number has been found! {chosenNumber} was the number");
                return;
            }
            if (chosenNumber == (num[(num.Length / 2) - 1]) )
            {
                Console.WriteLine($"The number has been found! {chosenNumber} was the number");
                return;
            }
            if (chosenNumber > (num[(num.Length / 2)-1]))
            {
                Console.WriteLine($"{num[(num.Length / 2)-1]} is too low!");
                
                for (int i = 0; i < newr.Length; i++)
                {
                    newr[i] = num[i + num.Length / 2];
                }
                
            }
            if (chosenNumber < (num[(num.Length/ 2)-1]))
            {
                Console.WriteLine($"{num[(num.Length / 2)-1]} is too high!");
                
                for (int i = 0; i < newr.Length; i++)
                {
                    newr[i] = num[i];
                }
                
            }
            Bisector(newr);
        }
    }
}
