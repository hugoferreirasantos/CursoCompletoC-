using Enum01.Entities;
using Enum01.Entities.Enums;
using System;

namespace Enum01
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order 
            { 
                Id = 1000,
                Moment = DateTime.Now,
                Status = OrderSatus.PendingPayment
            };

            Console.WriteLine(order);

            //Conversão de Enum para String:

            string txt = OrderSatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            //Conversão de String para Enum:

            OrderSatus os = Enum.Parse<OrderSatus>("Delivered");

            Console.WriteLine(os);
        }
    }
}