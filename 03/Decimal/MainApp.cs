using System; 
 
namespace Decimal 
{ 
    class MainApp 
    { 
        static void Main(string[] args) 
        { 
            float   a = 3.1415_9265_3589_7932_3846_2643_3832_79f; 
            double  b = 3.1415_9265_3589_7932_3846_2643_3832_79; 
            decimal c = 3.1415_9265_3589_7932_3846_2643_3832_79m; 
 
            Console.WriteLine(a); 
            Console.WriteLine(b); 
            Console.WriteLine(c);             	
        } 
    } 
} 
