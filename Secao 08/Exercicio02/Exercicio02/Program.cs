﻿using Exercicio02.Entities;
using System;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[]args)
        {
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit this wonderful country!",
                12
                );

            p1.AddCommet(c1);
            p1.AddCommet(c2);

            Comment c3 = new Comment("Good night!");
            Comment c4 = new Comment("May the Force be with you!");

            Post p2 = new Post(
                DateTime.Parse("21/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5
                );

            p2.AddCommet(c3);
            p2.AddCommet(c4);



            Console.WriteLine(p1);
            Console.WriteLine(p2);


        }
    }
}