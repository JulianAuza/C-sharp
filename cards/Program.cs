﻿using System;

namespace cards
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Deck myDeck= new Deck();
            Console.WriteLine(myDeck.Deal());
             
        }
    }
}
