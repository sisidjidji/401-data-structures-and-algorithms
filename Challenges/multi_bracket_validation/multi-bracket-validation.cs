using Microsoft.VisualBasic;
using System;
using Data_Structures.stacks;
using System.Text;

namespace Challenges
{
    public class Multi_bracket_validation
    {

        public static bool MultiBracketValidation(string input)
        {
            int openCount = 0;
            int closCout = 0;


            Stack<string> stack = new Stack<string>();

            for (int i = 0; i <= input.Length-1 ; i++)
            {
                if (input[i] == '{' || input[i] == '(' || input[i] == '[')
                {
                    stack.Push(Char.ToString(input[i]));
                    openCount++;
                }
                else if (input[i] == '}' || input[i] == ')' || input[i] == ']')
                {

                    closCout++;
                    if (!(input[i] == '}' && stack.Peek() == "{" ||
                          input[i] == ')' && stack.Peek() == "(" ||
                          input[i] == ']' && stack.Peek() == "["))
                    {
                        return false;

                    }

                  

                }

               
            }
            if (openCount != closCout)
            {
                return false;
            }

            return true;
        }
    }
}

