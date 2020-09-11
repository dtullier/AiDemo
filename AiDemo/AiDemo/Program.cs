using System;
using System.Collections.Generic;

namespace EightPuzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            PromptForAlgorithm();
        }

        public static void PromptForAlgorithm()
        {
            Console.WriteLine("Which algorithm would you like to use?");
            var algs = new List<string> { "BFS", "DFS", "A*" };
            for(var i = 0; i < algs.Count; i++)
            {
                Console.WriteLine($"{i}: {algs[i]}");
            }
            var alg = Console.ReadKey().KeyChar;
            Console.WriteLine();

            switch (alg)
            {
                case '0':
                    Console.WriteLine(algs[0]);
                    BfSearch();
                    break;
                case '1':
                    Console.WriteLine(algs[1]);
                    break;
                case '2':
                    Console.WriteLine(algs[2]);
                    break;
                default:
                    Console.WriteLine("You broke it...");
                    break;
            }
        }

        public static void BfSearch()
        {

        }
    }
}
