using System.Collections.Generic;
using System.Linq;
using E = System.Linq.Enumerable;

namespace dotnetcore3.Challenges
{
    internal static class SudokuValidator
    {
        public static bool ValidateSolution(int[][] board)
        {
            var nums = board.SelectMany(x => x).ToArray();
            List<int> block = new List<int>();

            for (int i = 0; i < 9; i++)
            {
                if (board[i].Where(x => x != 0).Distinct().ToArray().Count() != 9)
                {
                    return false;  // Rows validation
                }

                List<int> column = new List<int>();  // Columns validation
                for (int j = 0; j < 9; j++)
                {
                    column.Add(nums[j * 9]);
                }
                if (column.Where(x => x != 0).Distinct().ToArray().Count() != 9)
                {
                    return false;
                }
            }

            for (int j = 0; j < 3; j++)
            {
                var blocksRow = nums.Skip(j * 27).Take((j + 1) * 27);
                List<List<int>> blocksRowList = new List<List<int>>();
                for (int k = 0; k < 3; k++)
                {
                    blocksRowList.Add(new List<int>());
                    for (int l = 0; l < 27; l += 9)
                    {
                        blocksRowList[k].AddRange(blocksRow.Skip(l + 3 * k).Take(3).ToList());

                    }
                    if (blocksRowList[k].Where(x => x != 0).Distinct().ToArray().Count() != 9)
                    {
                        return false;  // Blocks validation
                    }
                }
            }

            return true;
        }

        public static bool ValidateSolution_by_mpt(int[][] board)
        {
            // I am sorry
            return board.All(r => r.ToHashSet().Count == 9) && E.Repeat(0, 9).Select((_, i) => i).All(i => E.Repeat(0, 9).Select((_, c) => board[c][i]).ToHashSet().Count == 9 && E.Repeat(0, 9).Select((_, c) => board[(i % 3 * 3) + c % 3][(i / 3) * 3 + c / 3]).ToHashSet().Count == 9);
        }
    }
}
