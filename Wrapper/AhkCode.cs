using System;

namespace AhkWrapper
{
    class AhkCode
    {
        public static bool IsExpression(string CodeLine) {
            // Position of the first comma
            int FirstComma = CodeLine.IndexOf( ',' );

            // Position of the first open parenthesis
            int FirstOpenPar = CodeLine.IndexOf( '(' );

            // Check if it's a command versus a function
            bool IsCommand = (FirstComma < FirstOpenPar || FirstOpenPar == -1) && FirstComma != -1; //|| (FirstComma == -1);


            // Check if it's a traditional assignment
            //  Example: Var = Literal Value
            //  False Example: Var := "Quoted Value"
            bool IsTraditional = CodeLine.Contains( ":=" ) == false && CodeLine.Contains("=") == true;

            // True if it's an expression
            return IsCommand == false && IsTraditional == false;
        }
    }
}
