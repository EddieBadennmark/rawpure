using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRAW
{
    class CSharpInformation
    {
        public static void CsharpMenu()
        {
            Console.Clear();
            MenuWriter.TextFileWriter(3, 31, "CsharpInfo.txt");
            TextWriter.LogoCsharp(22, 2, ConsoleColor.DarkRed);
            MenuBoxDrawEX.DrawBox(18, 10, 97, 29, ConsoleColor.Black, ConsoleColor.DarkGreen, false);
            MenuBoxDrawEX.DrawBox(1, 30, 97, 47, ConsoleColor.Black, ConsoleColor.DarkGreen, false);
            Console.ResetColor();
            TextWriter.Text(19, 10, " C# (C Sharp) : ");
            TextWriter.Text(2, 30, " INFORMATION : ");
            int num = MenuBoxDrawEX.ChooseListBoxItem(new string[9]
            {
        "Operators",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "(Go Back)"
            }, 1, 11, ConsoleColor.Black, ConsoleColor.Green);
            Console.ResetColor();
            switch (num)
            {
                case 1:
                    Console.Clear();
                    OperatorsInfo.Operators();
                    break;
                case 2:
                    CSharpInformation.CsharpMenu();
                    break;
                case 3:
                    CSharpInformation.CsharpMenu();
                    break;
                case 4:
                    CSharpInformation.CsharpMenu();
                    break;
                case 5:
                    CSharpInformation.CsharpMenu();
                    break;
                case 6:
                    CSharpInformation.CsharpMenu();
                    break;
                case 7:
                    CSharpInformation.CsharpMenu();
                    break;
                case 8:
                    CSharpInformation.CsharpMenu();
                    break;
                case 9:
                    Program.MainMenu();
                    break;
                default:
                    Program.MainMenu();
                    break;
            }
        }
    }
}
