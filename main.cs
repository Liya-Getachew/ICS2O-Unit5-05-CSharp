// Created by: liya getachew
// Created on: Nov 29 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function tells the user if they're eligible for discount
        string day;
        int age;

        Console.WriteLine("Insert your the day today and your age to see if you're eligible for discount.");
        Console.WriteLine();

        Console.WriteLine("Your age: ");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        Console.WriteLine("today is: ");
        day = Console.ReadLine();
        Console.WriteLine();

        if ((day == "Tuesday" || day == "Thursday") || (age > 12 && age < 25))
        {
            Console.WriteLine("You're eligible for a discount");
        }
        else
        {
            Console.WriteLine("You aren't eligible.");
        }

        Console.WriteLine("\nDone.");
    }
}