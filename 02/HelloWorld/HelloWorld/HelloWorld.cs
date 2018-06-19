using System;
using static System.Console;

namespace BrainCSharp
{
    class HelloWorld
    {
        // 프로그램 실행이 시작되는 곳
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("사용법 : HelloWorld.exe <이름>");
                return;
            }
            
            WriteLine("Hello, {0}!", args[0]); // Hello, World를 프롬프트에 출력
        }
    }
}
