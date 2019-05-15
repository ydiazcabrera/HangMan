using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HangManStarterKit
{
    class BruteForcePlayer : Player
    {
        int count = -1;
        public override char Guess()
        {

            ArrayList alphabet = new ArrayList(){ 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            
                        
                count ++;
                Console.WriteLine(alphabet[count]);
                return Convert.ToChar(alphabet[count]);

                //char brute= Convert.ToChar(alphabet[i]);
                //count = alphabet.Count;
                
            
        }
    }
}
