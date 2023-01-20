using System;
using System.Threading.Channels;

namespace Buildforcheck
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int c = Sum(2, 3);
            if (c == 0)
            {
                c = 10;
            }

            int d = Minus(10, 0);
            Console.WriteLine(c);
        }

        public static int Sum(int a, int b)
        {
            if (a > 3)
                a = a/0;
                return a + b;
        }

        public static int Minus(int a, int b)
        {
            if (a > 3)
                a = 4;
            return a - b;
        }
    }
}
