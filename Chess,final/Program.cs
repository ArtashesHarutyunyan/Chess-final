namespace Chess_final;


class Program
{
    public static void Main()
    {
        Chessboard board = new Chessboard();
        int firstindex = 0;
        int secondindex = 0;
        string Position;
        string PositionTo;
        int firstindexTo;
        int secondindexTo;

        while (true)
        {
            Console.Clear();

            board.DrawBoard();

            Console.WriteLine("Choose The Figure: R, N, B, Q, K");
            char selectedFigure = ChooseTheFigure();

            //Rook rook = new Rook();
            //Bishop bishop = new Bishop();
            //Queen queen = new Queen();
            //King king = new King();
            switch (selectedFigure)
            {
                case 'R':
                    Rook rook = new Rook();
                    Position = GetPosition();
                    firstindex = Position[0] - 'a';
                    secondindex = int.Parse(Position[1].ToString()) - 1;
                    board.PlaceFigure(selectedFigure, firstindex, secondindex);
                    rook.CalculatePossibleMoves(firstindex, secondindex);
                    board.DrawPosiibleMoves(rook.PossibleMoves);
                    PositionTo = GetSecondPosition();
                    firstindexTo = PositionTo[0] - 'a';
                    secondindexTo = int.Parse(PositionTo[1].ToString()) - 1;
                    if (rook.PossibleMoves[secondindexTo, firstindexTo])
                    {
                        board.PlaceFigure(' ', firstindex, secondindex);
                        board.PlaceFigure(selectedFigure, firstindexTo, secondindexTo);
                        board.DrawBoard();
                    }
                    Console.ReadLine();
                    break;
                case 'B':
                    Bishop bishop = new Bishop();
                    Position = GetPosition();
                    firstindex = Position[0] - 'a';
                    secondindex = int.Parse(Position[1].ToString()) - 1;
                    board.PlaceFigure(selectedFigure, firstindex, secondindex);
                    bishop.CalculatePossibleMoves(firstindex, secondindex);
                    board.DrawPosiibleMoves(bishop.PossibleMoves);
                    PositionTo = GetSecondPosition();
                    firstindexTo = PositionTo[0] - 'a';
                    secondindexTo = int.Parse(PositionTo[1].ToString()) - 1;
                    if (bishop.PossibleMoves[secondindexTo, firstindexTo])
                    {
                        board.PlaceFigure(' ', firstindex, secondindex);
                        board.PlaceFigure(selectedFigure, firstindexTo, secondindexTo);
                        board.DrawBoard();
                    }
                    Console.ReadLine();

                    break;
                case 'Q':
                    Queen queen = new Queen();
                    Position = GetPosition();
                    firstindex = Position[0] - 'a';
                    secondindex = int.Parse(Position[1].ToString()) - 1;
                    board.PlaceFigure(selectedFigure, firstindex, secondindex);
                    queen.CalculatePossibleMoves(firstindex, secondindex);
                    board.DrawPosiibleMoves(queen.PossibleMoves);
                    PositionTo = GetSecondPosition();
                    firstindexTo = PositionTo[0] - 'a';
                    secondindexTo = int.Parse(PositionTo[1].ToString()) - 1;
                    if (queen.PossibleMoves[secondindexTo, firstindexTo])
                    {
                        board.PlaceFigure(' ', firstindex, secondindex);
                        board.PlaceFigure(selectedFigure, firstindexTo, secondindexTo);
                        board.DrawBoard();
                    }
                    Console.ReadLine();
                    break;
                case 'K':
                    King king = new King();
                    Position = GetPosition();
                    firstindex = Position[0] - 'a';
                    secondindex = int.Parse(Position[1].ToString()) - 1;
                    board.PlaceFigure(selectedFigure, firstindex, secondindex);
                    king.CalculatePossibleMoves(firstindex, secondindex);
                    board.DrawPosiibleMoves(king.PossibleMoves);
                    PositionTo = GetSecondPosition();
                    firstindexTo = PositionTo[0] - 'a';
                    secondindexTo = int.Parse(PositionTo[1].ToString()) - 1;
                    if (king.PossibleMoves[secondindexTo, firstindexTo])
                    {
                        board.PlaceFigure(' ', firstindex, secondindex);
                        board.PlaceFigure(selectedFigure, firstindexTo, secondindexTo);
                        board.DrawBoard();
                    }
                    Console.ReadLine();
                    break;

            }

        }
        Console.ReadLine();
    }

    public static char ChooseTheFigure()
    {
        string chosenFigure = Console.ReadLine();
        string allowedFigures = "RNBQKrnbkq";
        if (allowedFigures.Contains(chosenFigure))
        {
            return chosenFigure[0];

        }
        else
        {
            Console.WriteLine("Choose the right figure");
            return ChooseTheFigure();
        }
    }

    public static bool IsValidPosition(string position)
    {
        if (position.Length != 2)
        {
            return false;
        }
        else
        {
            string letters = "abcdefghABCDEFGH";

            if (letters.Contains(position[0]))
            {
                if (!int.TryParse(position[1].ToString(), out int x))
                {
                    return false;
                }
                else if (x < 9 && x > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
    public static string GetPosition()
    {
        string result;
        Console.WriteLine("Choose The Position");
        result = Console.ReadLine();
        result = result.ToLower();
        if (IsValidPosition(result))
        {
            return result;
        }
        else return GetPosition();
    }
    public static string GetSecondPosition()
    {
        string result;
        Console.WriteLine("Where Do Yoy Want To Put It");
        result = Console.ReadLine();
        result = result.ToLower();
        if (IsValidPosition(result))
        {
            return result;
        }
        else return GetSecondPosition();
    }
}