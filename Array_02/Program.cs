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

namespace Array_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            var pokeTrader = new PokeTrader();

            var ContinuePlaying = true;
            while (ContinuePlaying)
            {
                ContinuePlaying = pokeTrader.Trade();
            }
            

            Console.ReadLine();
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

        public string[] Pokelist
        {
            get { return pokelist; }
        }

        public bool Trade()
        {
            ShowPokeList();
            var firstInput = this.GetFirstChoice();
            var IsValidChoice = this.IsValidChoice(firstInput);

            while (!IsValidChoice)
            {
                Console.WriteLine("Try Again!");
                ShowPokeList();
                firstInput = GetFirstChoice();
                IsValidChoice = this.IsValidChoice(firstInput);
            }

            var firstnumber = int.Parse(firstInput);
            if (firstnumber == -1)
                return false;

            var secondInput = this.GetSecondChoice(firstnumber);
            IsValidChoice = this.IsValidChoice(secondInput);

            while (!IsValidChoice)
            {
                Console.WriteLine("Try Again!");
                ShowPokeList();
                secondInput = GetFirstChoice();
                IsValidChoice = this.IsValidChoice(secondInput);
            }

            var secondnumber = int.Parse(secondInput);
            ExchangePokemon(firstnumber, secondnumber);

            return true;
        }

        private void ShowPokeList()
        {
            Console.WriteLine("Exchange Pokemon");
            for (int i = 0; i < Pokelist.Length; i++)
            {
                Console.WriteLine(i + ". " + Pokelist[i]);
            }
        }

        private string GetFirstChoice()
        {
            Console.Write("Choose a Pokemon (or -1 to quit):");
            var Input = Console.ReadLine();
            return Input;
        }

        private string GetSecondChoice(int numberFirstPokemon)
        {
            Console.Write("Choose a Pokemon to exchange with "+ Pokelist[numberFirstPokemon] + ":");
            var Input = Console.ReadLine();
            return Input;
        }



        private bool IsValidChoice(string input)
        {
            var number = int.Parse(input);
            if (number <-1 || number > 5)
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
