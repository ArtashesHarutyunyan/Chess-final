using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_final
{
    internal class King
    {
        public bool[,] PossibleMoves = new bool[8, 8];
        public void CalculatePossibleMoves(int x, int y)
        {
            int fromRow = x;
            int fromCol = y;

            // Define the possible horizontal, vertical, and diagonal movements for a king
            int[] rowOffsets = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] colOffsets = { -1, 0, 1, -1, 1, -1, 0, 1 };

            for (int i = 0; i < 8; i++)
            {
                int newRow = fromRow + rowOffsets[i];
                int newCol = fromCol + colOffsets[i];

                // Check if the new position is within the bounds of the chessboard
                if (newRow >= 0 && newRow < 8 && newCol >= 0 && newCol < 8)
                {
                    PossibleMoves[newCol,newRow] = true;
                    
                }
            }
        }
    }
}
