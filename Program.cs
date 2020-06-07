using System;
using System.Linq;

namespace eyeScrabble
{
    public static class Program
    {
        private static char[,] board = new char[7, 7];

        public static void Main()
        {
            ReadBoard();
            DisplayBoard();
            if(CheckBoardValidity())
            {
                Console.WriteLine("Board state is valid.");
            }
            else
            {
                Console.WriteLine("Board state is not valid.");
            }
        }
        /// <summary>
        /// Check if the board state is valid
        /// </summary>
        /// <returns>
        /// True if the board state is valid, false if the board state is invalid
        /// </returns>
        private static bool CheckBoardValidity()
        {
            if (board is null)
            {
                return false;
            }
            int numberOfEmptySquares = 0;
            foreach (char item in board)
            {
                if (item == '*')
                {
                    numberOfEmptySquares++;
                }
            }
            if (numberOfEmptySquares != 1)
            {
                return false;
            }

            return true;
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
