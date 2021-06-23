using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRAW
{
    class MenuBoxDrawEX
    {
        public static int ChooseListBoxItem(
          string[] items,
          int ucol,
          int urow,
          ConsoleColor back,
          ConsoleColor fore)
        {
            int length1 = items.Length;
            int length2 = items[0].Length;
            for (int index = 1; index < length1; ++index)
            {
                if (items[index].Length > length2)
                    length2 = items[index].Length;
            }
            int[] numArray = new int[length1];
            for (int index = 0; index < length1; ++index)
                numArray[index] = length2 - items[index].Length + 1;
            int lcol = ucol + length2 + 3;
            int lrow = urow + length1 + 1;
            MenuBoxDrawEX.DrawBox(ucol, urow, lcol, lrow, back, fore, true);
            MenuBoxDrawEX.WriteColorString(" " + items[0] + new string(' ', numArray[0]), ucol + 1, urow + 1, fore, back);
            for (int index = 2; index <= length1; ++index)
                MenuBoxDrawEX.WriteColorString(items[index - 1], ucol + 2, urow + index, back, fore);
            int num = 1;
            while (true)
            {
                ConsoleKeyInfo consoleKeyInfo;
                do
                {
                    consoleKeyInfo = Console.ReadKey(true);
                    if (consoleKeyInfo.KeyChar == '\r')
                        return num;
                    if (consoleKeyInfo.Key == ConsoleKey.DownArrow)
                    {
                        MenuBoxDrawEX.WriteColorString(" " + items[num - 1] + new string(' ', numArray[num - 1]), ucol + 1, urow + num, back, fore);
                        if (num < length1)
                            ++num;
                        else
                            num = 1;
                        MenuBoxDrawEX.WriteColorString(" " + items[num - 1] + new string(' ', numArray[num - 1]), ucol + 1, urow + num, fore, back);
                    }
                }
                while (consoleKeyInfo.Key != ConsoleKey.UpArrow);
                MenuBoxDrawEX.WriteColorString(" " + items[num - 1] + new string(' ', numArray[num - 1]), ucol + 1, urow + num, back, fore);
                if (num > 1)
                    --num;
                else
                    num = length1;
                MenuBoxDrawEX.WriteColorString(" " + items[num - 1] + new string(' ', numArray[num - 1]), ucol + 1, urow + num, fore, back);
            }
        }

        public static void DrawBox(
          int ucol,
          int urow,
          int lcol,
          int lrow,
          ConsoleColor back,
          ConsoleColor fore,
          bool fill)
        {
            string str = fill ? new string(' ', lcol - ucol - 1) : "";
            MenuBoxDrawEX.SetColors(back, fore);
            try
            {
                Console.SetCursorPosition(ucol, urow);
                Console.Write('┌');
                for (int index = ucol + 1; index < lcol; ++index)
                    Console.Write('─');
                Console.Write('┐');
                for (int top = urow + 1; top < lrow; ++top)
                {
                    Console.SetCursorPosition(ucol, top);
                    Console.Write('│');
                    if (fill)
                        Console.Write(str);
                    Console.SetCursorPosition(lcol, top);
                    Console.Write('│');
                }
                Console.SetCursorPosition(ucol, lrow);
                Console.Write('└');
                for (int index = ucol + 1; index < lcol; ++index)
                    Console.Write('─');
                Console.Write('┘');
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }
        }

        public static void WriteColorString(
          string s,
          int col,
          int row,
          ConsoleColor back,
          ConsoleColor fore)
        {
            MenuBoxDrawEX.SetColors(back, fore);
            Console.SetCursorPosition(col, row);
            Console.Write(s);
        }

        public static void SetColors(ConsoleColor back, ConsoleColor fore)
        {
            Console.BackgroundColor = back;
            Console.ForegroundColor = fore;
        }
    }
}
