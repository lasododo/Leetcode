using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionsWithTests.ValidSudoku
{
    public class Solution
    {
        public bool IsValidSudoku(char[][] board)
        {
            var dict = new Dictionary<char, HashSet<(int, int)>>();

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    if (board[i][j] == '.')
                    {
                        continue;
                    }

                    if (!dict.ContainsKey(board[i][j]))
                    {
                        dict[board[i][j]] = new();
                    }

                    dict[board[i][j]].Add((i, j));
                }
            }

            foreach (var set in dict.Values)
            {
                if (!OneNumberIsValid(set))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool OneNumberIsValid(HashSet<(int, int)> set)
        {
            // squares
            var helperSet = new HashSet<(int, int)>();
            // rows
            var rowSet = new HashSet<int>();
            // cols
            var colSet = new HashSet<int>();

            foreach (var (i, j) in set)
            {
                var additionResult = 
                    rowSet.Add(i)
                    && colSet.Add(j)
                    && helperSet.Add(((i / 3), (j / 3)));

                if (!additionResult)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
