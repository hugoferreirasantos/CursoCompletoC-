using System;

namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 20;
            Object obj = x;

            Console.WriteLine(obj);
            Console.WriteLine(obj.GetType());
        }
    }
}