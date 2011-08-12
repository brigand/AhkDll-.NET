using System;
using AhkWrapper;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {

            AhkDll.ThreadFromText( "" );

            while (true)
            {
                string action = Console.ReadLine();
                Console.WriteLine("Responce: {0}", AhkCode.IsExpression(action));
            }

            Console.ReadKey();
             
        }
    }
}
