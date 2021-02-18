using System;

namespace C_Sharp_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            tryCatch();
            WriteSomething();
            WriteSpecific("Hello hello hello");
            Console.WriteLine(Add(15, 31));
            Console.WriteLine(Add(Add(1, 2), Add(3, 4)));
            Console.WriteLine(Mult(2, 8));
            Console.WriteLine(Div(25, 13));
            Console.WriteLine(GreetFriend("Steph"));
            Console.WriteLine(GreetFriend("Ruben"));
            Console.WriteLine(GreetFriend("Simone"));
            Console.WriteLine(Calculate());

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
        public static int Calculate()
        {
            Console.WriteLine("Please enter the first number");
            string num1input = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string num2input = Console.ReadLine();

            int num1 = int.Parse(num1input);
            int num2 = int.Parse(num2input);

            int result = num1 + num2;
            return result;

        }
        public static void tryCatch()
        {
            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();

            try
            {
                int userInputInt = int.Parse(userInput);
            }
            catch (Exception)
            {
                Console.WriteLine("Format exception, please enter a number next time!");
            }

            

            Console.ReadKey();
        }
    }
}
