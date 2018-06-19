using System;
using System.Collections;
using static System.Console;

namespace InitializingHashtable
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // C# 5.0 이전 스타일의 컬렉션 초기자
            Hashtable ht = new Hashtable()
            {
                { "one", "하나" },
                { "two", "둘" },
                { "three", "셋" },
                {"four", "넷" },
                {"five", "다섯" }
            };

            foreach (object item in ht.Values)
                WriteLine(item);
            WriteLine();

            // C# 6.0 이후 스타일
            ArrayList list2 = new ArrayList(arr){ [1] = 111};
            foreach (object item in list2)
                WriteLine($"ArrayList : {item}");
            WriteLine();

            Stack stack2 = new Stack(arr) { [1] = 222 };
            foreach (object item in stack2)
                WriteLine($"Stack : {item}");
            WriteLine();

            Queue queue2 = new Queue(arr) { [1] = 333 };
            foreach (object item in queue2)
                WriteLine($"Queue : {item}");
            WriteLine();

            Hashtable ht2 = new Hashtable()
            {
                ["하나"] ="one",
                ["둘"]   = "two",
                ["셋"]   = "three",
                ["넷"]   ="four",
                ["다섯"] ="five"
            };

            foreach ( object item in ht2.Values)
                WriteLine( item ) ;
        }
    }
}
