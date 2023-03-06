using Microsoft.Extensions.DependencyInjection;
using Scorer.Services;
using System;
using System.Linq;
using System.Collections.Generic;

namespace Scorer
{
    public  class Program
    {
        public static void Main(string[] args)
        {
            GameScorer gameScorer = new GameScorer();
            
            int finalScore = 0;

            int turn = 7; // count of categories

            while (turn > 0)
            {
            GetOrder:
                try
                {
                    Console.WriteLine("Enter Your Order: ");
                    var orderString = Console.ReadLine();

                    finalScore += gameScorer.ProcessEachRound(orderString);

                    turn--;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Duplicate category, choose another one. ");
                    goto GetOrder;
                }

            }

            Console.WriteLine("Final Score:{0} ",finalScore);
        }
    }
}
