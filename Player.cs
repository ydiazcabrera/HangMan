using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HangManStarterKit
{
    abstract class Player
    {
        public abstract char Guess();
    }
}

//Build Specifications: Take the following starter kit and build out 3 different players, each with different strategies.The Players must all be children from the player abstract class or interface. Each will need to overwrite and create their own version of GenerateGuess.

//GenerateGuess method:
//The HumanPlayer will ask for user input and return that as it’s guess
//The RandomPlayer will return a random letter from the alphabet
//The BruteForcePlayer will guess every Letter in sequence starting at a and ending at z. This player will keep guessing until it wins. 


//Throughout the game track how many times they try and print that number once they’ve won. 


//Also, note that, the hangman game has a bug: when you are trying to guess a word with multiple letters, say “apple”, it won’t reveal the second p.How would you fix the game that such that the first time you guess P, both Ps in apple appear?

