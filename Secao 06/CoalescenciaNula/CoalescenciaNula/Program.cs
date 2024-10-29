using System;
using System.Threading.Tasks.Dataflow;

namespace CoalescenciaNula
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? z = 50.0;
            double? y = x ?? 5.0;
            double? a = z ?? 0.0;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(a);
        }
    }
}