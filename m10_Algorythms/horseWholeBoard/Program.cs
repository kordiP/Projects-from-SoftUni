using System.Text;

namespace horseWholeBoard
{
    internal class Program
    {
        static void Main()
        {
            Dictionary<int, int> possibleKnightMoves = new Dictionary<int, int>
            {
                { -2, -1 },
                { -2, 1 },
                { -1, -2 },
                { -1, 2 },
                { 2, -1 },
                { 2, 1 },
                { 1, -2 },
                { 1, 2 }
            };
            ChessLogic chess = new ChessLogic();
            int currX = 0;
            int currY = 7;
            int nextX = 1;
            int nextY = 5;
            int moveCount = 1;
            while (chess.IsLegalMove(currX, currY, nextX, nextY))//not like this
            {
                chess.MovePiece(currX, currY, nextX, nextY);
                chess.chessBoard[nextX, nextY].Value = moveCount;
                Console.WriteLine(chess.PrintChessBoard());
                break;
            }
        }
    }
    internal class ChessPiece
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Value { get; set; }
        public bool IsGoneBy { get; set; }

        public ChessPiece(string name, string color, int value)
        {
            Name = name;
            Color = color;
            Value = value;
            IsGoneBy = false;
        }
    }
    internal class ChessLogic
    {
        ChessPiece none;
        ChessPiece knight_w;
        public ChessPiece[,] chessBoard;
        public Dictionary<string, ChessPiece> moves;
        public ChessLogic()
        {
            this.chessBoard = new ChessPiece[8, 8];
            moves = new Dictionary<string, ChessPiece>();
            none = new ChessPiece(" None ", "None", 0);
            knight_w = new ChessPiece("Knight", "White", 3);
            GenerateChessBoard();
        }
        public void GenerateChessBoard() // works :>
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    chessBoard[i, j] = none;
                }
            }
            chessBoard[0, 7] = knight_w;

        }
        public string PrintChessBoard() // works :>
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 7; i >= 0; i--)
            {
                stringBuilder.AppendLine("\n+--------+--------+--------+--------+--------+--------+--------+--------+");
                for (int j = 0; j < 8; j++)
                {
                    stringBuilder.Append("| " + chessBoard[j, i].Name + " ");
                }
                stringBuilder.Append("| " + (i + 1));
            }
            stringBuilder.AppendLine("\n+--------+--------+--------+--------+--------+--------+--------+--------+\n    a        b        c        d        e        f        g        h");
            return stringBuilder.ToString();
        }
        public bool IsLegalMove(int currX, int currY, int nextX, int nextY)
        {
            ChessPiece currPiece = chessBoard[currX, currY];
            switch (currPiece.Name)
            {
                case "Knight":
                    if (!chessBoard[nextX, nextY].Equals(none) && chessBoard[nextX, nextY].Color == currPiece.Color)
                        return false;
                    else if (Math.Abs(nextX - currX) > 2 || Math.Abs(nextX - currX) < 1)
                        return false;
                    else if (Math.Abs(nextY - currY) > 2 || Math.Abs(nextY - currY) < 1)
                        return false;
                    else if (Math.Abs(nextX - currX) + Math.Abs(nextY - currY) != 3)
                        return false;
                    else if (chessBoard[nextX, nextY].IsGoneBy)
                        return false;
                    break;
                
                default:
                    return false;
            }
            return true;
        }
        public void MovePiece(int currX, int currY, int nextX, int nextY)
        {
            ChessPiece currPiece = chessBoard[currX, currY];
            if (IsLegalMove(currX, currY, nextX, nextY))
            {
                chessBoard[nextX, nextY] = currPiece;
                chessBoard[nextX, nextY].IsGoneBy = true;
                chessBoard[currX, currY] = none;
                chessBoard[currX, currY].IsGoneBy = true;
                moves.Add($"{moves.Count + 1}.{(char)(currX + 97)}{currY + 1} -> {(char)(nextX + 97)}{nextY + 1}\t*{currPiece.Color}*", currPiece);
            }
        }
    }
}