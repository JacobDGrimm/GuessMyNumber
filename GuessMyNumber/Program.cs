﻿using System;
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
            BasicNumber BN = new BasicNumber();

            BN.NumberPicker();
            BN.Bisector();
        }
    }
}
