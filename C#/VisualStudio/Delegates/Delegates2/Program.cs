﻿using System;


namespace Delegates1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();

            Action<string> action = PrintMessage;

            animal.Move(20, action);

            Console.ReadKey();
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}