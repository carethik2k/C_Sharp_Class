using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program asks for "Count". You are using "CountChar"
            // Similarly when printing in reverse, it should say "String in reverse: " = -.25 Mark

            // When prompting for a character, why is it prompting on the next time ? = -.25 Mark

            // Looping is incorrect. If i enter a string, it should keep asking options till i quit once. 
            // Right now it performs for example 'Length' and asks for next string. = -1 Mark

            // if i simply hit 'Enter' instead of entering a character for countchar action it loops infinitely without any response.
            // Always make sure your code handles valid and invalid input = -.5 Mark

            //If i enter a valid string and then enter an invalid option, it says "Please enter a valid action"
            // But instead of asking the action again its prompting for a new string. = -0.5 Mark

            // Total = 7.5 Marks

            Operation.Operation1();
        }
    }
}
