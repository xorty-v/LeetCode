public class Solution {
    public bool IsValidSudoku(char[][] board)
    {
        for (int row = 0; row < 9; row++)
        {
            var map = new HashSet<char>();
            for (int i = 0; i < 9; i++)
            {
                if (board[row][i] == '.') continue;
                if (map.Contains(board[row][i])) return false;
                map.Add(board[row][i]);
            }
        }

        for (int col = 0; col < 9; col++)
        {
            var map = new HashSet<char>();
            for (int i = 0; i < 9; i++)
            {
                if (board[i][col] == '.') continue;
                if (map.Contains(board[i][col])) return false;
                map.Add(board[i][col]);
            }
        }

        for (int square = 0; square < 9; square++)
        {
            var map = new HashSet<char>();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int row = (square / 3) * 3 + i;
                    int col = (square % 3) * 3 + j;
                    if (board[row][col] == '.') continue;
                    if (map.Contains(board[row][col])) return false;
                    map.Add(board[row][col]);
                }
            }
        }

        return true;
    }
}