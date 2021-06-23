using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRAW
{
    class OperatorsInfo
    {
        public static void Operators()
        {
            TextWriter.LogoCsharp(22, 2, ConsoleColor.DarkRed);
            MenuBoxDrawEX.DrawBox(1, 30, 98, 47, ConsoleColor.Black, ConsoleColor.DarkGreen, false);
            Console.ResetColor();
            MenuWriter.TextFileWriter(3, 32, "OperatorsInformation.txt");
            TextWriter.Text(2, 30, " OPERATORS INFORMATION : ");
            int num = MenuBoxDrawEX.ChooseListBoxItem(new string[5]
            {
        "Mathematical",
        "Logical",
        "Bitwise shifting",
        "Relational",
        "(Go Back)"
            }, 1, 11, ConsoleColor.Black, ConsoleColor.Green);
            Console.ResetColor();
            switch (num)
            {
                case 1:
                    Console.Clear();
                    OperatorsInfo.MathOperators();
                    break;
                case 2:
                    Console.Clear();
                    OperatorsInfo.LogicalOperators();
                    break;
                case 3:
                    Console.Clear();
                    OperatorsInfo.BitwiseOperator();
                    break;
                case 4:
                    Console.Clear();
                    OperatorsInfo.RelationalOperators();
                    break;
                case 5:
                    CSharpInformation.CsharpMenu();
                    break;
                default:
                    OperatorsInfo.Operators();
                    break;
            }
        }

        public static void SideBoxMathOperators()
        {
            MenuBoxDrawEX.DrawBox(21, 10, 98, 29, ConsoleColor.Black, ConsoleColor.DarkGreen, false);
            Console.ResetColor();
            TextWriter.Text(25, 10, ": Quick overview of Math operators :");
            TextWriter.Text(25, 12, "Mathematic : ");
            TextWriter.TextColor(38, 12, " + ,  - ,  * ,  / ,  = , % , ++ , -- ", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(25, 14, "x   7   7");
            TextWriter.TextColor(27, 14, "=", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.TextColor(31, 14, "+", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(25, 15, "x   7   7");
            TextWriter.TextColor(27, 15, "=", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.TextColor(31, 15, "-", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(25, 16, "x   7   7");
            TextWriter.TextColor(27, 16, "=", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.TextColor(31, 16, "*", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(25, 17, "x   7   7");
            TextWriter.TextColor(27, 17, "=", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.TextColor(31, 17, "/", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(25, 18, "x   7");
            TextWriter.TextColor(27, 18, "=", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(25, 19, "x   y");
            TextWriter.TextColor(27, 19, "%", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(25, 20, "x   ");
            TextWriter.TextColor(26, 20, "++", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(27, 21, "x");
            TextWriter.TextColor(25, 21, "++", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(25, 22, "x   ");
            TextWriter.TextColor(26, 22, "--", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(27, 23, "x");
            TextWriter.TextColor(25, 23, "--", ConsoleColor.Magenta, ConsoleColor.Black);
        }

        public static void MathOperators()
        {
            OperatorsInfo.SideBoxMathOperators();
            OperatorsInfo.Operators();
        }

        public static void SideBoxLogicalOperators()
        {
            MenuBoxDrawEX.DrawBox(21, 10, 98, 29, ConsoleColor.Black, ConsoleColor.DarkGreen, false);
            Console.ResetColor();
            TextWriter.Text(25, 10, ": Quick overview of Logical operators :");
            TextWriter.Text(25, 12, "Expressions : ");
            TextWriter.TextColor(38, 12, " & , && , | , || , ^ , ! , ~ ", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(25, 14, "a b");
            TextWriter.TextColor(26, 14, "&", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(25, 15, "a  b");
            TextWriter.TextColor(26, 15, "&&", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(25, 16, "a b");
            TextWriter.TextColor(26, 16, "|", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(25, 17, "a  b");
            TextWriter.TextColor(26, 17, "||", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(25, 18, "x y");
            TextWriter.TextColor(26, 18, "^", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(26, 19, "x");
            TextWriter.TextColor(25, 19, "!", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(26, 20, "x");
            TextWriter.TextColor(25, 20, "~", ConsoleColor.Magenta, ConsoleColor.Black);
        }

        public static void LogicalOperators()
        {
            OperatorsInfo.SideBoxLogicalOperators();
            OperatorsInfo.Operators();
        }

        public static void SideBoxBitwiseOperators()
        {
            MenuBoxDrawEX.DrawBox(21, 10, 98, 29, ConsoleColor.Black, ConsoleColor.DarkGreen, false);
            Console.ResetColor();
            TextWriter.Text(25, 10, ": Quick overview of Bitwise operators :");
            TextWriter.Text(25, 12, "Expressions : ");
            TextWriter.TextColor(38, 12, " >> , << ", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(25, 14, "a  b");
            TextWriter.TextColor(26, 14, ">>", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(25, 15, "a  b");
            TextWriter.TextColor(26, 15, "<<", ConsoleColor.Magenta, ConsoleColor.Black);
        }

        public static void BitwiseOperator()
        {
            OperatorsInfo.SideBoxBitwiseOperators();
            OperatorsInfo.Operators();
        }

        public static void SideBoxRelationalOperators()
        {
            MenuBoxDrawEX.DrawBox(21, 10, 98, 29, ConsoleColor.Black, ConsoleColor.DarkGreen, false);
            Console.ResetColor();
            TextWriter.Text(25, 10, ": Quick overview of Relational operators :");
            TextWriter.Text(25, 12, "Expressions : ");
            TextWriter.TextColor(38, 12, " == , != , < , > , <= , >= ", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(25, 14, "a  b");
            TextWriter.TextColor(26, 14, "==", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(25, 15, "a  b");
            TextWriter.TextColor(26, 15, "!=", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(25, 16, "a b");
            TextWriter.TextColor(26, 16, "<", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(25, 17, "a b");
            TextWriter.TextColor(26, 17, ">", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(25, 18, "x  y");
            TextWriter.TextColor(26, 18, "<=", ConsoleColor.Magenta, ConsoleColor.Black);
            TextWriter.Text(25, 19, "x  y");
            TextWriter.TextColor(26, 19, ">=", ConsoleColor.Magenta, ConsoleColor.Black);
        }

        public static void RelationalOperators()
        {
            OperatorsInfo.SideBoxRelationalOperators();
            OperatorsInfo.Operators();
        }
    }
}

