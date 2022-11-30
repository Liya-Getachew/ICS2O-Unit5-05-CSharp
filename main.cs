// Created by: liya getachew
// Created on: Nov 29 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function tells the user the type of their triangle
        int sideA;
        int sideB;
        int sideC;

        Console.WriteLine("Insert side lengths of a trianlge here and find out the type:");
        Console.WriteLine();

        Console.WriteLine("side A: ");
        sideA = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("side B: ");
        sideB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("side C: ");
        sideC = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        double angleA = Math.Acos((Math.Pow(sideB, 2) + Math.Pow(sideC, 2) - Math.Pow(sideA, 2)) / (2 * sideB * sideC)) * (180 / Math.PI);
        double angleB = Math.Acos((Math.Pow(sideC, 2) + Math.Pow(sideA, 2) - Math.Pow(sideB, 2)) / (2 * sideC * sideA)) * (180 / Math.PI);
        double angleC =
    Math.Acos((Math.Pow(sideA, 2) + Math.Pow(sideB, 2) - Math.Pow(sideC, 2)) / (2 * sideA * sideB)) * (180 / Math.PI);

        double sumOfAngles = Math.Round(angleA, 2) + Math.Round(angleB, 2) + Math.Round(angleC, 2);

        if (sumOfAngles == 180)
        {
            if (sideA == sideB && sideB == sideC && sideC == sideA)
            {
                Console.WriteLine("Your triangle is Equilateral.");
            }
             else if (sideA == sideB || sideB == sideC || sideC == sideA)
            {
                Console.WriteLine("Your triangle is Isosceles.");
            }
            else
            {
                Console.WriteLine("Your triangle is Scalene.");
            }
        }
        else
        {
            Console.WriteLine("That's no triangle.");
        }
        Console.WriteLine("\nDone.");
    }
}