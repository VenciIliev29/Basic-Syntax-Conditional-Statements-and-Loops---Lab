﻿using System;

namespace Submit_a_solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:f2}.");


        }
    }
}
