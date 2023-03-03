using System;

namespace TiposVarios
{
    class Program
    {
        static void Main(string[] args)
        {
            int i= 1;
            uint u = 2U;
            long l = 3L;

            Console.WriteLine(i + " " + u + " " + l);

            char dot = '\u002E';
            char comma = '\u002C';

            Console.WriteLine(dot + " " + comma);

            double real1 = 3.1415;
            float real2 = 3.1415f;
            decimal real3 = 3.1415m;

            Console.WriteLine(real1 + " " + real2 + " " + real3);
        }

    }
}
