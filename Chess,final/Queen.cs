using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_final
{
    internal class Queen
    {
        public bool[,] PossibleMoves = new bool[8, 8];
        public void CalculatePossibleMoves(int x, int y)
        {
            int fromRow = x;
            int fromCol = y;

            // Calculate possible moves for a rook-like movement (horizontal and vertical)
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    PossibleMoves[col, row] = (row == fromRow || col == fromCol) && (row != fromRow || col != fromCol);
                }
            }

            // Calculate possible moves for a bishop-like movement (diagonal)
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    int rowDiff = Math.Abs(row - fromRow);
                    int colDiff = Math.Abs(col - fromCol);

                    PossibleMoves[col, row] |= rowDiff == colDiff && row != fromRow && col != fromCol;
                }
            }
        }
    }
}
