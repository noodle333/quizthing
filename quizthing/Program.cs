﻿using System;

namespace quizthing
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = 0;
            string p_answer1;
            string p_answer2;
            string p_answer3;

            int a = 1;
            int b = 1;
            int c = 1;

            Console.WriteLine("THIS IS A 3 QUESTION QUIZ. A QUESTION WILL BE ASKED AND YOU WILL CHOOSE ONE OF THE FOLLOWING ALTERNATIVES.");
            while (a == 1)
            {
                Console.WriteLine("WHAT IS THE RESULT OF √144 + √169?");
                Console.WriteLine("A: 25 | B: 28 | C: 16");
                p_answer1 = Console.ReadLine().ToLower();
                if (p_answer1 == "a")
                {
                    Console.WriteLine("CORRECT.");
                    points = points + 1;
                    a = a - 1;
                }
                else if (p_answer1 == "b" || p_answer1 == "c")
                {
                    Console.WriteLine("INCORRECT.");
                    a = a - 1;
                }
                else
                {
                    Console.WriteLine("INCORRECT INPUT TRY AGAIN.");
                }
            }
            while (b == 1)
            {
                Console.WriteLine("WHICH COUNTRY HAS THE LARGEST POPULATION?");
                Console.WriteLine("A: JAPAN | B: RUSSIA | C: BRAZIL");
                p_answer2 = Console.ReadLine().ToLower();
                if (p_answer2 == "c")
                {
                    Console.WriteLine("CORRECT.");
                    points = points + 1;
                    b = b - 1;
                }
                else if (p_answer2 == "a" || p_answer2 == "b")
                {
                    Console.WriteLine("INCORRECT");
                    b = b - 1;
                }
                else
                {
                    Console.WriteLine("INCORRECT INPUT TRY AGAIN.");
                }
            }
            while (c == 1)
            {
                Console.WriteLine("WHO IS THE MAIN CREATOR OF THE GAME UNDERTALE?");
                Console.WriteLine("A: MICHEAL JACKSON | B: BRADLEY COOPER | C: TOBY FOX");
                p_answer3 = Console.ReadLine().ToLower();
                if (p_answer3 == "c")
                {
                    Console.WriteLine("CORRECT.");
                    points = points + 1;
                    c = c - 1;
                }
                else if (p_answer3 == "a" || p_answer3 == "b")
                {
                    Console.WriteLine("INCORRECT.");
                    c--;
                }
                else
                {
                    Console.WriteLine("INCORRECT INPUT TRY AGAIN.");
                }
            }
            if (points == 0 || points == 1)
            {
                Console.WriteLine("BAD SCORE STUDY UP BRO. YOU FINISHED WITH " + points + " / 3 POINTS.");

            }
            else if (points == 2)
            {
                Console.WriteLine("ALMOST A PERFECT SCORE. YOU FINISHED WITH " + points + " / 3 POINTS.");
            }
            else
            {
                Console.WriteLine("A PERFECT SCORE! YOU FINISHED WITH " + points + " / 3 POINTS.");
            }
            Console.ReadLine();
        }
    }
}
