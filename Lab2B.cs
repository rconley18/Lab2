/* Class: CSE 1321L
 * Section: W1
 * Term: Spring 24
 * Instructor: Manosni Gundu
 * Name: Robert Conley
 * Lab: 2B
 */
using System;

class Lab2B
{
    static void Main()
    {
        PrintShape();
    }

    static void PrintShape()
    {
        int size = 5;

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size - i - 1; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < 2 * i + 1; k++)
            {
                if (k % 2 == 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("_");
                }
            }

            Console.WriteLine();
        }

        for (int i = size - 2; i >= 0; i--)
        {
            for (int j = 0; j < size - i - 1; j++)
            {
                Console.Write(" ");
            }

            for (int k = 0; k < 2 * i + 1; k++)
            {
                if (k % 2 == 0)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("_");
                }
            }

            Console.WriteLine();
        }
    }
}
