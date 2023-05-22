using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_final;

public class Rook
{
    public bool[,] PossibleMoves = new bool[8, 8];
    //public bool IsValidMove(char figure,string from, string to)
    //{

    //    int fromRow = 8 - int.Parse(from[1].ToString());
    //    int fromCol = from[0] - 'A';
    //    int toRow = 8 - int.Parse(to[1].ToString());
    //    int toCol = to[0] - 'A';

    //    if (fromRow - toRow == 0 || fromCol - toCol == 0)
    //    {
    //        return true;
    //    }
    //    else
    //    {
    //        return false;
    //    }

    //}

    public  void CalculatePossibleMoves(int x,int y)
    {
        int fromRow = x;
        int fromCol = y;

        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                PossibleMoves[col, row] = (row == fromRow || col == fromCol) && (row != fromRow || col != fromCol);

            }
        }

    }

}




