using System;

namespace Chess_final
{
    class Chessboard
    {
        
        public Chessboard()
        {
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    Board[row, col] = ' ';
                }
            }
        }

        public char[,] Board = new char[8, 8];


        public void DrawBoard()
        {
            int size = 8;
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };

            Console.Write(" ");
            for (int col = 0; col < size; col++)
            {
                Console.Write($" {letters[col]}");
            }
            Console.WriteLine();

            for (int row = 0; row < size; row++)
            {
                Console.Write(row + 1);

                for (int col = 0; col < size; col++)
                {
                    ConsoleColor color = (row + col) % 2 == 0 ? ConsoleColor.White : ConsoleColor.Black;

                    Console.BackgroundColor = color;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write($" {Board[row, col]}");
                }

                Console.ResetColor();

                Console.WriteLine();
            }


        }
        public void PlaceFigure(char figure, int row, int col)
        {
            Board[col, row] = figure;
        }
        
        public void DrawPosiibleMoves(bool[,] possiblemoves)
        {
            int size = 8;
            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };

            Console.Write(" ");
            for (int col = 0; col < size; col++)
            {
                Console.Write($" {letters[col]}");
            }
            Console.WriteLine();

            for (int row = 0; row < size; row++)
            {
                Console.Write(row + 1);

                for (int col = 0; col < size; col++)
                {
                    ConsoleColor color = (row + col) % 2 == 0 ? ConsoleColor.White : ConsoleColor.Black;

                    Console.BackgroundColor = color;
                    Console.ForegroundColor = ConsoleColor.Red;
                    if (possiblemoves[row, col])
                    {
                        Console.BackgroundColor = ConsoleColor.Green;
                    }

                    Console.Write($" {Board[row, col]}");
                }

                Console.ResetColor();

                Console.WriteLine();
            }
        }

    }

}

