/* Class: CSE 1321L
 * Section: W1
 * Term: Spring 24
 * Instructor: Manosni Gundu
 * Name: Robert Conley
 * Lab: 2C
 */
using System;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
class Lab2C
{
    public static void Main()
    {


        //User input for width and length
        Console.Write("Enter a width:");
        double width = double.Parse(Console.ReadLine());

        Console.Write("Enter a length:");
        double height = double.Parse(Console.ReadLine());

        // calculations
        double area = width * height;
        double perimeter = 2 * (width + height);


        //displaying results

        Console.WriteLine("The area is " + area);
        Console.WriteLine("The perimeter is " + perimeter);
    }
}