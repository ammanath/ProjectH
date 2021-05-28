using System;
using System.Collections.Generic;
using System.Threading;



namespace ProjectH
{
    class Program
    {
        static void Main(string[] args)
        {
            string guess;

            Thread t = new Thread(Print1);
            t.Start();

            Random rnd = new Random();
            int genNext;
            for (int i = 0; i < 100; i++)
            {
                genNext = rnd.Next(30, 700);
                Thread.Sleep(100);
                Console.Write(genNext);
            }

            Console.ReadLine();
        }

        private static void Print1()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(100);
                Console.Write('X');
            }
            
        }
    }
}
