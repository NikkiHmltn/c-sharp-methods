using System;

namespace C_Sharp_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSpecific("Hello hello hello");
            Console.WriteLine(Add(15, 31));
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
    }
}
