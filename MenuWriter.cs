using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace ConsoleRAW
{
    internal class MenuWriter
    {
        public static void MainMenu()
        {
            Console.ResetColor();
            int num1 = MenuBoxDrawEX.ChooseListBoxItem(new string[10]
            {
       "Read me",
        "Calculator",
        "",
        "",
        "",
        "C# Information",
        "",
        "Todo list...",
        "",
        "(Exit)"
            }, 40, 11, ConsoleColor.Black, ConsoleColor.Green);
            Console.ResetColor();
            switch (num1)
            {
                case 1:
                    MenuWriter.ReadMe();
                    break;
                case 2:
                    MenuWriter.MainMenu();
                    break;
                case 3:
                    MenuWriter.MainMenu();
                    break;
                case 4:
                    MenuWriter.MainMenu();
                    break;
                case 5:
                    MenuWriter.MainMenu();
                    break;
                case 6:
                    Console.Clear();
                    CSharpInformation.CsharpMenu();
                    break;
                case 7:
                    MenuWriter.MainMenu();
                    break;
                case 8:
                    Console.Clear();
                    MenuWriter.Todo();
                    MenuWriter.MainMenu();
                    break;
                case 9:
                    MenuWriter.MainMenu();
                    break;
                case 10:
                    Console.Clear();
                    int num2 = MenuBoxDrawEX.ChooseListBoxItem(new string[2]
                    {
            "Yes",
            "No"
                    }, 23, 23, ConsoleColor.Black, ConsoleColor.Red);
                    if (num2 == 1)
                        Environment.Exit(0);
                    if (num2 == 2)
                        Console.ResetColor();
                    Program.MainMenu();
                    break;
                default:
                    MenuWriter.MainMenu();
                    break;
            }
        }

        public static void ReadMe()
        {
            Console.Clear();
            Console.ResetColor();
            TextWriter.TextColor(20, 20, "Nothing here...yet...", ConsoleColor.Red, ConsoleColor.Black);
            Thread.Sleep(1000);
            Console.Clear();
            Program.MainMenu();
        }

        public static void Todo()
        {
            TextWriter.TextColor(4, 24, " What needs to be done : ", ConsoleColor.DarkCyan, ConsoleColor.Black);
            TextWriter.LogoRaw(20, 3, ConsoleColor.DarkCyan);
            Console.ResetColor();
            MenuWriter.TextFileWriter(4, 26, "todo.txt");
        }

        public static void TextFileWriter(int x, int y, string filename)
        {
            Console.SetCursorPosition(x, y);
            StreamReader streamReader = new StreamReader(filename);
            string text = "";
            while (text != null)
            {
                text = streamReader.ReadLine();
                if (text != null)
                {
                    TextWriter.Text(x, y, text);
                    ++y;
                }
            }
            streamReader.Close();
        }
    }
}
