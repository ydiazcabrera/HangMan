using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class RandomPlayer : Player
    {
        public Random R { get; set; }

        public override char Guess()
        {
            this.R = R;

            List<char> alphabet = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};
            int selection = R.Next(0, 27);
            return alphabet[selection];

            
        }
    }
}
