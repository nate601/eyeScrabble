using System;
using static eyeScrabble.ConsoleUtils;

namespace eyeScrabble
{
    public static class Program
    {
        private static char[,] board = new char[7, 7];
        public static void Main()
        {
            ReadBoard();
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                }
            }
        }
        /// <summary>
        /// Reads the board input state position from the user. 
        /// </summary>
        private static void ReadBoard()
        {
            for (int x = 0; x < 7; x++)
            {
                char[] curLine;
                while (true)
                {
                    Print($"Line #{x}: ");
                    curLine = Console.ReadLine().ToCharArray();
                    if (curLine.Length == 7)
                    {
                        break;
                    }
                }

                for (int i = 0; i < curLine.Length; i++)
                {
                    board[x, i] = curLine[i];
                }
            }
        }
    }
    public static class ConsoleUtils
    {
        public static void PrintL(object obj)
        {
            Console.WriteLine(obj);
        }
        public static void Print(object obj)
        {
            Console.Write(obj);
        }
    }

}
