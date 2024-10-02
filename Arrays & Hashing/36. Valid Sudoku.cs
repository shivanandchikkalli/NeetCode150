public static bool IsValidSudoku(char[][] board)
{
    Dictionary<int, HashSet<char>> rows = new();
    Dictionary<int, HashSet<char>> columns = new();
    Dictionary<int, HashSet<char>> squares = new();

    for (int row = 0; row < board.Length;row++)
    {
        for (int column = 0; column < board[row].Length; column++)
        {
            var cell = board[row][column];

            if (cell != '.')
            {
                int squareIdx = (row / 3) * 3 + (column / 3);

                if ((rows.TryGetValue(row, out var x) && x.TryGetValue(cell, out var y))
                    || (columns.TryGetValue(column, out var a) && a.TryGetValue(cell, out var b))
                    || (squares.TryGetValue(squareIdx, out var j) && j.TryGetValue(cell, out var k)))
                {
                    return false;
                }

                rows.TryAdd(row, new HashSet<char>());
                columns.TryAdd(column, new HashSet<char>());
                squares.TryAdd(squareIdx, new HashSet<char>());

                rows[row].Add(cell);
                columns[column].Add(cell);
                squares[squareIdx].Add(cell);
            }
        }
    }

    return true;
}