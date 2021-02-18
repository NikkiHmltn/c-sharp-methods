using System;

namespace C_Sharp_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSpecific("Hello hello hello");
        }
        //access modifier (static) return type method name (parameter1, parameter2)
        static void WriteSomething() => Console.WriteLine("Hello from the new method!");
        public static void WriteSpecific(string myText)
        {
            Console.WriteLine(myText);
            Console.Read();
        }
    }
}
