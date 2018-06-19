using System;

namespace While
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int i = 10;

            do
            {
                Console.WriteLine($"a) i : {i--}");
            }
            while (i > 0);

            do
            {
                Console.WriteLine($"b) i : {i--}");
            }
            while (i > 0);
        }
    }
}
