using System;
using System.Collections.Generic;

namespace Deliverable_2
{
    class Program
    {
        public static List<string> answers;
        static void Main(string[] args)
        {
            answers = new List<string>();
            ask();
            
        }
        static void ask()
        {
            Console.WriteLine("Speak, Human!:");
            string input1 = Console.ReadLine();
            string input = input1.ToLower();
            if (answers.Contains(input))
            {
                already();
                ask();
            } else
            {
                answers.Add(input);
                if (input == "hello")
                {
                    Console.WriteLine("Hi, good to see you");
                    ask();
                }
                else if (input == "bye")
                {
                    Console.WriteLine("Good Bye!");
                }
                else if (input == "sup")
                {
                    Console.WriteLine("I am Good");
                    ask();
                }
                else if (input == "hello there")
                {
                    Console.WriteLine("General Kenobi");
                    ask();
                }
            }
            
        }
        static void reAsk()
        {
            ask();
        }
        static void already()
        {
            Console.WriteLine("Im sorry but you already said that");
        }
    }
}
