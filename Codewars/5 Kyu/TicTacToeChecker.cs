using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars._5_Kyu
{
    class TicTacToeChecker
    {
        public static int IsSolved(int[,] board)
        {
            int _temp = 0;
            int _answer = 0;

            _answer = GetResult_X(board);
            if (_answer == 1)
                return 1;
            _answer = GetResult_0(board);
            if (_answer == 2)
                return 2;

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    if (board[i, j] == 0)
                    {
                        board[i, j] = 1;
                        _temp = GetResult_X(board);
                        if (_temp == 1)
                            return -1;
                        board[i, j] = 2;
                        _temp = GetResult_0(board);
                        if (_temp == 2)
                            return -1;
                    }
                }
            }
            return 0;
        }
        public static int GetResult_X(int[,] board)
        {
            if (board[0, 0] == 1 && board[0, 1] == 1 && board[0, 2] == 1)
                return 1;
            else if (board[1, 0] == 1 && board[1, 1] == 1 && board[1, 2] == 1)
                return 1;
            else if (board[2, 0] == 1 && board[2, 1] == 1 && board[2, 2] == 1)
                return 1;
            else if (board[0, 0] == 1 && board[1, 0] == 1 && board[2, 0] == 1)
                return 1;
            else if (board[0, 1] == 1 && board[1, 1] == 1 && board[2, 1] == 1)
                return 1;
            else if (board[0, 2] == 1 && board[1, 2] == 1 && board[2, 2] == 1)
                return 1;
            else if (board[0, 0] == 1 && board[1, 1] == 1 && board[2, 2] == 1)
                return 1;
            else if (board[0, 2] == 1 && board[1, 1] == 1 && board[2, 0] == 1)
                return 1;
            return 0;
        }
        public static int GetResult_0(int[,] board)
        {
            if (board[0, 0] == 2 && board[0, 1] == 2 && board[0, 2] == 2)
                return 2;
            else if (board[1, 0] == 2 && board[1, 1] == 2 && board[1, 2] == 2)
                return 2;
            else if (board[2, 0] == 2 && board[2, 1] == 2 && board[2, 2] == 2)
                return 2;
            else if (board[0, 0] == 2 && board[1, 0] == 2 && board[2, 0] == 2)
                return 2;
            else if (board[0, 1] == 2 && board[1, 1] == 2 && board[2, 1] == 2)
                return 2;
            else if (board[0, 2] == 2 && board[1, 2] == 2 && board[2, 2] == 2)
                return 2;
            else if (board[0, 0] == 2 && board[1, 1] == 2 && board[2, 2] == 2)
                return 2;
            else if (board[0, 2] == 2 && board[1, 1] == 2 && board[2, 0] == 2)
                return 2;
            return 0;
        }
    }
}
