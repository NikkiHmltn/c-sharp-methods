﻿using System;

namespace C_Sharp_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSpecific("Hello hello hello");
            Console.WriteLine(Add(15, 31));
            Console.WriteLine(Add(Add(1, 2), Add(3, 4)));
            Console.WriteLine(Mult(2, 8));
            Console.WriteLine(Div(25, 13));
            Console.WriteLine(GreetFriend("Steph"));
            Console.WriteLine(GreetFriend("Ruben"));
            Console.WriteLine(GreetFriend("Simone"));
            Console.Read();
        }
        //access modifier (static) return type method name (parameter1, parameter2)
        static void WriteSomething() => Console.WriteLine("Hello from the new method!");
        public static void WriteSpecific(string myText)
        {
            Console.WriteLine(myText);
            
        }
        public static int Add(int param1, int param2)
        {
            return param1 + param2;
        }
        public static int Mult(int param1, int param2)
        {
            return param1 * param2;
        }
        public static double Div(double param1, double param2)
        {
            return param1 / param2;
        }
        public static string GreetFriend(string param){
            string friend = "Hi " + param + ", my friend!";
            return friend;
        }
    }
}
