//Make a program that gives a numbered list.
//0. PIKACHU
//1. CHARMELEON
//2. GEODUDE
//3. GYARADOS
//4. BUTTERFREE
//5. MANKEY
//Then, choose a number of them or (-1) to quit.And then, choose a number to exchange with.
//For choice out of bounds or same set of inputs, display "Try Again!". 

using System;
using System.Runtime.CompilerServices;
[assembly: InternalsVisibleTo("Array_02.Tests")]

namespace Array_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pokeTrader = new PokeTrader();
            pokeTrader.ContinousTrade();
        }
    }

    public class PokeTrader
    {
        string[] pokelist = new string[6]
        {
            "PIKACHU",
            "CHARMELEON",
            "GEODUDE",
            "GYARADOS",
            "BUTTERFREE",
            "MANKEY"
        };

        public string[] Pokelist => pokelist;

        public void ContinousTrade()
        {
            var ContinuePlaying = true;
            while (ContinuePlaying)
            {
                ContinuePlaying = Trade();
            }
        }

        public bool Trade()
        {
            ShowPokeList();

            int firstnumber = GetFirstNumber();
            if (firstnumber == -1)
                return false;

            int secondnumber = GetSecondNumber(firstnumber);
            if (secondnumber == -1)
                return false;

            ExchangePokemon(firstnumber, secondnumber);

            return true;
        }
        internal void ShowPokeList()
        {
            Console.WriteLine("Exchange Pokemon");
            for (int i = 0; i < Pokelist.Length; i++)
            {
                Console.WriteLine(i + ". " + Pokelist[i]);
            }
        }

        private int GetFirstNumber()
        {
            var firstInput = GetFirstChoice();
            firstInput = ValidateChoice(firstInput);
            var firstnumber = int.Parse(firstInput);
            return firstnumber;
        }

        private int GetSecondNumber(int firstnumber)
        {
            var secondInput = GetSecondChoice(firstnumber);
            secondInput = ValidateChoice(secondInput);
            var secondnumber = int.Parse(secondInput);
            return secondnumber;
        }

        internal string GetFirstChoice()
        {
            Console.Write("Choose a Pokemon (or -1 to quit):");
            var Input = Console.ReadLine();
            return Input;
        }
        internal string GetSecondChoice(int numberFirstPokemon)
        {
            Console.Write("Choose a Pokemon to exchange with " + Pokelist[numberFirstPokemon] + ":");
            var Input = Console.ReadLine();
            return Input;
        }

        internal string ValidateChoice(string firstInput)
        {
            var IsValidChoice = this.IsValidChoice(firstInput);
            while (!IsValidChoice)
            {
                Console.WriteLine("Try Again!");
                ShowPokeList();
                firstInput = GetFirstChoice();
                IsValidChoice = this.IsValidChoice(firstInput);
            }
            return firstInput;
        }

        private bool IsValidChoice(string input)
        {
            var number = int.Parse(input);
            if (number < -1 || number > 5)
                return false;
            else
                return true;
        }

        public void ExchangePokemon(int firstnumber, int secondnumber)
        {
            var temp = pokelist[firstnumber];
            pokelist[firstnumber] = pokelist[secondnumber];
            pokelist[secondnumber] = temp;
        }
    }
}
