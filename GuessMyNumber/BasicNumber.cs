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

        public void NumberPicker()
        {
            Console.WriteLine("What number do you want?");
            int chosenNumber = Convert.ToInt32(Console.ReadLine());
        }
    }
}
