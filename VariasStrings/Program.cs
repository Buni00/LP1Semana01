using System;

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

            string x = "String "+ "conc" + "atizada";
            string xy = x + "e com texto adicionado!";

            int docesCompra = 3;
            int docesComi =2;
            string y = $"comprei {docesCompra} doces e comi {docesComi}";

            Console.WriteLine(a +"\n"+ b +"\n"+ c + "\n" + d);

            Console.WriteLine(x +"\n"+ xy +"\n"+ y + "\n" + z + "\n" + last);
        }
    }
}
