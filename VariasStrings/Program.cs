﻿using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Uma Plica \u0027";
            string b = "Uma nova linha \nlinha";
            string c = @"Uma Plica 0x0027 em Unicode";
            string d = @"Literalmente um \n";

            Console.WriteLine(a +"\n"+ b +"\n"+ c + "\n" + d);
        }
    }
}