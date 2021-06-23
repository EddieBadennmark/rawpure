using System;

namespace ConsoleRAW
{
    internal class Program
    {
        private static string userPass;

        private static void Main(string[] args)
        {
            //Console.SetWindowSize(100, 50);
            //Console.SetBufferSize(100, 51);
            Console.CursorVisible = false;
            Program.NameEntry();
        }

        public static void MainMenu()
        {
            Console.Clear();
            Console.CursorVisible = false;
            TextWriter.LogoRaw(20, 3, ConsoleColor.DarkRed);
            Program.Info();
            MenuWriter.MainMenu();
        }

        private static void NameEntry()
        {
            Console.Clear();
            TextWriter.LogoRaw(20, 35, ConsoleColor.DarkBlue);
            MenuBoxDrawEX.DrawBox(40, 20, 60, 22, ConsoleColor.Black, ConsoleColor.Green, false);
            MenuBoxDrawEX.DrawBox(38, 18, 62, 24, ConsoleColor.Black, ConsoleColor.Green, false);
            Console.ResetColor();
            TextWriter.Text(40, 19, "Enter password :");
            Console.SetCursorPosition(42, 21);
            Console.CursorVisible = true;
            Program.userPass = Console.ReadLine();
            if (Program.userPass.Length < 2)
                Program.NameEntry();
            if (Program.userPass == "password" || Program.userPass == "raw")
                Program.MainMenu();
            else
                Program.NameEntry();
        }

        private static void Info()
        {
            MenuBoxDrawEX.DrawBox(2, 24, 98, 48, ConsoleColor.Black, ConsoleColor.DarkGreen, false);
            Console.ResetColor();
            MenuWriter.TextFileWriter(4, 26, "info.txt");
            TextWriter.TextColor(4, 24, " Notes : ", ConsoleColor.Red, ConsoleColor.Black);
        }
    }
}
