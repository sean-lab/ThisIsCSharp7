using System;

namespace PatternMatching01
{
    class Program
    {
        static int Round(object o)
        {
            if (o is int i)
                return i;
            else if(o is float f)
            {
                int v = (int)f;
                if (Math.Abs(f - v) < 0.5)
                    return v;
                else
                    return v + (f < 0 ? -1 : 1);
            }
            return 0;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Round(1.2f));
            Console.WriteLine(Round(1.6f));
            Console.WriteLine(Round(-1.2f));
            Console.WriteLine(Round(-1.6f));
            Console.WriteLine(Round(5));
            Console.WriteLine(Round(6));
        }
    }
}
