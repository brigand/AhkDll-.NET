using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AhkWrapper;

namespace Wrapper_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoHotkey.ThreadFromText("");

            while (true)
            {
                string action = Console.ReadLine();
                Console.WriteLine("Responce: {0}", AhkCode.IsExpression(action));
            }

            Console.ReadKey();

        }
    }
}