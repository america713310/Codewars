using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._4_Kyu
{
    class SudokuSolutionValidator
    {
        public static bool ValidateSolution(int[][] board)
        {
            List<int> _list = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    if (_list.Contains(board[i][j]))
                        _list.Remove(board[i][j]);
                }
                if (_list.Count > 0)
                    return false;
                _list = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            }
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    if (_list.Contains(board[j][i]))
                        _list.Remove(board[j][i]);
                }
                if (_list.Count > 0)
                    return false;
                _list = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            }
            for (int i = 3; i < 6; i++)
            {
                for (int j = 3; j < 6; j++)
                {
                    if (_list.Contains(board[i][j]))
                        _list.Remove(board[i][j]);
                }
            }
            if (_list.Count > 0)
                return false;
            _list = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            return true;
        }
    }
}
