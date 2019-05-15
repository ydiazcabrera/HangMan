using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class HumanPlayer : Player
    {
        public override char Guess()
        {
            Console.WriteLine("Input a guess.");
            char guess = char.Parse(Console.ReadLine());
            return guess;
        }
    }
}
