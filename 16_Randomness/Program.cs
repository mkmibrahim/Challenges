﻿using System;

namespace _16_Randomness
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Player
    {
        Random rnd = new Random();
        public int RollDie()
        {
            return rnd.Next(1,18);
        }

        public double GenerateSpellStrength()
        {
            return rnd.NextDouble() * 100;
        }
    }

}