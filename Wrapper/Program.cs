using System;
using AhkWrapper;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args) {

            AhkDll.ThreadFromText( "" );

            string action = "var := 300";

            Console.WriteLine( action );

            Console.WriteLine( AhkDll.Exec( action ) );

            /*
            string CodeLine = "msgbox := val";

            Console.WriteLine( "{0} is an expression = {1}", CodeLine, AhkCode.IsExpression( CodeLine ) );

            */


            Console.ReadKey();
             
        }
    }
}
