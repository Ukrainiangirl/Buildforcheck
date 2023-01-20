using System;
using System.Threading.Channels;

namespace Buildforcheck
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public int Sum(int a, int b)
        {
            if (a > 3)
                a = 4;
                return a + b;
        }

        public int Minus(int a, int b)
        {
            if (a > 3)
                a = 4;
            return a - b;
        }
    }

}
