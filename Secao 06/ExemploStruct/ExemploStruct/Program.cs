using System;

namespace ExemploStruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(); //Pode só declarar a variável do tipo: Point sem o New
            p.X = 10;
            p.Y = 20;
            Console.WriteLine(p);


        }
    }
}
