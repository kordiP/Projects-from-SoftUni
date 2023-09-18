namespace maze
{
    
    internal class Program
    {
        static void Main()
        {
            int sizeX = int.Parse(Console.ReadLine());
            int sizeY = int.Parse(Console.ReadLine());

            var grid = GenerateGrid(sizeX, sizeY);
            PathFinding(grid);

        }
        static char[,] GenerateGrid(int sizeX, int sizeY)
        {
            Console.WriteLine("Input the grid row by row");
            char[,] grid = new char[sizeX, sizeY];

            for (int i = 0; i < sizeY; i++)
            {
                string inputForRow = Console.ReadLine();

                for (int j = 0; j < sizeX; j++)
                    grid[j, i] = inputForRow[j];
            }
            return grid;
        }
        static void PathFinding(char[,] grid)
        {
            char emptySpace = '-';
            char end = 'e';

            List<Way> correctWays = new List<Way>();
            List<char> possibleMoves = new List<char>();

            grid[0, 0] = 'x';

            if (correctWays.Count == 0) correctWays.Add(new Way("", 0, 0));
            while (correctWays.Any(x => x.CurrentChar != end))
            {
                for (int i = 0; i < correctWays.Count; i++)
                {
                    if (correctWays[i].CurrentY - 1 >= 0 && (grid[correctWays[i].CurrentX, correctWays[i].CurrentY - 1] == emptySpace || grid[correctWays[i].CurrentX, correctWays[i].CurrentY - 1] == end)) // up
                    {
                        possibleMoves.Add('U');
                    }

                    if (correctWays[i].CurrentY + 1 < grid.GetLength(1) && (grid[correctWays[i].CurrentX, correctWays[i].CurrentY + 1] == emptySpace || grid[correctWays[i].CurrentX, correctWays[i].CurrentY + 1] == end)) // down
                    {
                        possibleMoves.Add('D');
                    }

                    if (correctWays[i].CurrentX - 1 >= 0 && (grid[correctWays[i].CurrentX - 1, correctWays[i].CurrentY] == emptySpace || grid[correctWays[i].CurrentX - 1, correctWays[i].CurrentY] == end)) // left
                    {
                        possibleMoves.Add('L');
                    }

                    if (correctWays[i].CurrentX + 1 < grid.GetLength(1) && (grid[correctWays[i].CurrentX + 1, correctWays[i].CurrentY] == emptySpace || grid[correctWays[i].CurrentX + 1, correctWays[i].CurrentY] == end)) // right
                    {
                        possibleMoves.Add('R');
                    }

                    
                    switch (possibleMoves.Count)
                    {
                        case 0:
                            if (correctWays[i].CurrentChar != end)
                                correctWays.RemoveAt(correctWays.Count - 1);
                            break;
                        case 1:
                            correctWays[correctWays.Count - 1].Path += possibleMoves[0];
                            break;
                        case 2:
                            correctWays.Add(new Way("", correctWays[i].CurrentX, correctWays[i].CurrentY));
                            correctWays[correctWays.Count - 1].Path = correctWays[correctWays.Count - 2].Path;
                            correctWays[correctWays.Count - 1].Path += possibleMoves[0];
                            correctWays[correctWays.Count - 2].Path += possibleMoves[1];
                            break;
                        case 3:
                            correctWays.Add(new Way("", correctWays[i].CurrentX, correctWays[i].CurrentY));
                            correctWays[correctWays.Count - 1].Path = correctWays[correctWays.Count - 2].Path;
                            correctWays.Add(new Way("", correctWays[i].CurrentX, correctWays[i].CurrentY));
                            correctWays[correctWays.Count - 1].Path = correctWays[correctWays.Count - 2].Path;
                            correctWays[correctWays.Count - 1].Path += possibleMoves[0];
                            correctWays[correctWays.Count - 2].Path += possibleMoves[1];
                            correctWays[correctWays.Count - 3].Path += possibleMoves[2];
                            break;
                    }
                    possibleMoves.Clear();

                    switch (correctWays[i].Path.Last())
                    {
                        case 'U':
                            correctWays[i].CurrentY -= 1;
                            grid[correctWays[i].CurrentX, correctWays[i].CurrentY] = grid[correctWays[i].CurrentX, correctWays[i].CurrentY] == end ? end : 'x';
                            correctWays[i].CurrentChar = grid[correctWays[i].CurrentX, correctWays[i].CurrentY];

                            break;
                        case 'D':
                            correctWays[i].CurrentY += 1;
                            grid[correctWays[i].CurrentX, correctWays[i].CurrentY] = grid[correctWays[i].CurrentX, correctWays[i].CurrentY] == end ? end : 'x';
                            correctWays[i].CurrentChar = grid[correctWays[i].CurrentX, correctWays[i].CurrentY];

                            break;
                        case 'L':
                            correctWays[i].CurrentX -= 1;
                            grid[correctWays[i].CurrentX, correctWays[i].CurrentY] = grid[correctWays[i].CurrentX, correctWays[i].CurrentY] == end ? end : 'x';
                            correctWays[i].CurrentChar = grid[correctWays[i].CurrentX, correctWays[i].CurrentY];

                            break;
                        case 'R':
                            correctWays[i].CurrentX += 1;
                            grid[correctWays[i].CurrentX, correctWays[i].CurrentY] = grid[correctWays[i].CurrentX, correctWays[i].CurrentY] == end ? end : 'x';
                            correctWays[i].CurrentChar = grid[correctWays[i].CurrentX, correctWays[i].CurrentY];

                            break;                                 
                    }
                }
            }

            foreach (var way in correctWays)
            {
                Console.WriteLine(way.Path);
            }
        }
    }
    public class Way
    {
        private string path;
        private int currentX;
        private int currentY;
        private char currentChar;

        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        public int CurrentX
        {
            get { return currentX; }
            set { currentX = value; }
        }
        public int CurrentY
        {
            get { return currentY; }
            set { currentY = value; }
        }
        public char CurrentChar
        {
            get { return currentChar; }
            set { currentChar = value; }
        }

        public Way(string path, int currentX, int currentY)
        {
            this.Path = path;
            this.CurrentX = currentX;
            this.CurrentY = currentY;
        }
    }
}