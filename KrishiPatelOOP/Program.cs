using System;
using System.Collections.Generic;
using System.ComponentModel;
using static CMP1903M_A01_2223.Card;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {   // Creates a pack
            Pack pack = new Pack();
            //Prints out deck
            Console.WriteLine("Complete Deck");
            pack.PrintPack();
            //Shuffles the deck
            Console.WriteLine("////////////////////////////////////////////////////////////////////////");
            pack.ShuffleCardPack();
            //Prints out shuffled deck
            Console.WriteLine("SHUFFLE COMMENCING");
            pack.PrintPack();
        }
    }
}
