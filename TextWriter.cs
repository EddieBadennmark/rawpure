using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRAW
{
    public class TextWriter
    {
        public static void Text(int x, int y, string text)
        {
            try
            {
                Console.SetCursorPosition(x, y);
                Console.Write(text);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }

        public static void TextColor(int x, int y, string text, ConsoleColor fore, ConsoleColor back)
        {
            try
            {
                Console.ForegroundColor = fore;
                Console.BackgroundColor = back;
                Console.SetCursorPosition(x, y);
                Console.Write(text);
                Console.ResetColor();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }

        public static void TextArray(int x, int y, string[] text)
        {
            try
            {
                foreach (string str in text)
                {
                    Console.SetCursorPosition(x, y);
                    Console.Write(text.ToString());
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }

        public static void LogoRaw(int x, int y, ConsoleColor fore)
        {
            try
            {
                Console.ForegroundColor = fore;
                TextWriter.Text(x, y++, "██████╗  █████╗ ██╗    ██╗██████╗ ██╗   ██╗██████╗ ███████╗");
                TextWriter.Text(x, y++, "██╔══██╗██╔══██╗██║    ██║██╔══██╗██║   ██║██╔══██╗██╔════╝");
                TextWriter.Text(x, y++, "██████╔╝███████║██║ █╗ ██║██████╔╝██║   ██║██████╔╝█████╗  ");
                TextWriter.Text(x, y++, "██╔══██╗██╔══██║██║███╗██║██╔═══╝ ██║   ██║██╔══██╗██╔══╝  ");
                TextWriter.Text(x, y++, "██║  ██║██║  ██║╚███╔███╔╝██║     ╚██████╔╝██║  ██║███████╗");
                TextWriter.Text(x, y++, "╚═╝  ╚═╝╚═╝  ╚═╝ ╚══╝╚══╝ ╚═╝      ╚═════╝ ╚═╝  ╚═╝╚══════╝");
                Console.ResetColor();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }

        public static void LogoCsharp(int x, int y, ConsoleColor fore)
        {
            try
            {
                Console.ForegroundColor = fore;
                TextWriter.Text(x, y++, " ██████╗ ██╗ ██╗     ██╗███╗   ██╗███████╗ ██████╗ ");
                TextWriter.Text(x, y++, "██╔════╝████████╗    ██║████╗  ██║██╔════╝██╔═══██╗");
                TextWriter.Text(x, y++, "██║     ╚██╔═██╔╝    ██║██╔██╗ ██║█████╗  ██║   ██║");
                TextWriter.Text(x, y++, "██║     ████████╗    ██║██║╚██╗██║██╔══╝  ██║   ██║");
                TextWriter.Text(x, y++, "╚██████╗╚██╔═██╔╝    ██║██║ ╚████║██║     ╚██████╔╝");
                TextWriter.Text(x, y++, " ╚═════╝ ╚═╝ ╚═╝     ╚═╝╚═╝  ╚═══╝╚═╝      ╚═════╝ ");
                Console.ResetColor();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
            }
        }
    }
}
