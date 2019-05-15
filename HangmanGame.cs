﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManStarterKit
{
    class HangmanGame
    {
        //this is the word you're trying to guess
        public string word;
        public int tries = 0;
        public List<char> guessedLetters = new List<char>();
        public List<char> foundLetters = new List<char>();
        List<string> wordBank = new List<string>{"fish","apple","tree", "dog", "rides", "scrambled" };

        Player guesser;
        public HangmanGame(Player guesser)
        {
            this.guesser = guesser;
            Random r = new Random();
            int index = r.Next(0,wordBank.Count);
            word = wordBank[index];
           
            Setup();
        }

        public HangmanGame(Player guesser, string word)
        {
            this.guesser = guesser;
            this.word = word;
            Setup();
        }

        private void Setup()
        {
            for (int i = 0; i < word.Length; i++)
            {
                foundLetters.Add('_');
            }
            Run();
        }

        public void Run()
        {
            while (HasWon() == false)
            {
                Console.WriteLine();
                PrintProgress();
                Console.WriteLine("Please guess a letter");
                //This is where you'll want to call your player.guess() method
                /// char c = char.Parse(Console.ReadLine());
                char c = guesser.Guess();
                Console.WriteLine(c);
                PlayRound(c);
            }
            PrintProgress();
        }

        public bool HasWon()
        {
            for(int i = 0; i < word.Length; i++)
            {
                if(foundLetters[i] != word[i])
                {
                    return false;
                }
            }
            Console.WriteLine("You won! Good Job!");
            return true;
        }

        public void PlayRound(char guess)
        {
            tries++;
            if (guessedLetters.Contains(guess))
            {
                Console.WriteLine("You already guessed that!");
            }
            else if (word.Contains(guess))
            {
                Console.WriteLine("Found a letter!");
                // index = word.IndexOf(guess);

                for (int index =0; index < word.Length;index++)
                {
                    if (word[index]==guess)
                    {
                        foundLetters[index] = guess;
                        guessedLetters.Add(guess);
                    }
                }
            }
            else
            {
                Console.WriteLine("No Letter found...");
            }
            Console.ReadLine();
            Console.Clear();
             
        }

        public void PrintProgress()
        {
            foreach(char c in foundLetters)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            Console.WriteLine("You have guessed: {0} times", tries);
        }
    }
}
