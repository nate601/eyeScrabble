using System;

namespace eyeScrabble
{
    public static class Program
    {
        private static char[,] board = new char[7, 7];
        public static void Main()
        {
            ReadBoard();
            DisplayBoard();
        }

        /// <summary>
        /// Displays the board matrix
        /// </summary>
        private static void DisplayBoard()
        {
            for (int x = 0; x < 7; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    Console.Write(board[x, y] + " ");
                }
                Console.Write(Environment.NewLine);
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
                    Console.Write($"Line #{x}: ");
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
}
