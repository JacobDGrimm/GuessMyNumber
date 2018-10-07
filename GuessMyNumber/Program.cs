using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic implimentation of bisection");

            BasicNumber BN = new BasicNumber();

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            BN.NumberPicker();
            BN.Bisector(arr);

            Console.WriteLine("Human guessing game! 1 - 1000");

            HumanPlays HP = new HumanPlays();

            HP.NumberPicker();
            HP.GuessingGame();

            Console.WriteLine("My turn! Computer guessing game!");

            ComputerPlays CP = new ComputerPlays();


            CP.NumberPicker();
            CP.Game(CP.Numbers());
            
        }
    }
}
