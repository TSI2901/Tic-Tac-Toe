using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac.Models.Contracts;

namespace Tic_Tac.Models
{
    internal class Board:IBoard
    {
        public string[][] board { get; set; }
        public Board()
        {
            board = new string[3][];
            board[0] = new string[3];
            board[1] = new string[3];
            board[2] = new string[3];
        }
        
        public string ShowTheEmptyBoard()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    board[i][j] = " ";
                }
                sb.AppendLine(String.Join(" | ", board[i]));
            }
            return sb.ToString();
        }
        public string ShowTheBoard()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < board.GetLength(0); i++)
            {
                sb.AppendLine(String.Join(" | ", board[i]));
            }
            return sb.ToString();
        }
        public void PlaceAMarker(string markerToPlace, int row, int coll)
        {
            this.board[row][coll] = markerToPlace;
        }
        public bool IsInBoard(int n)
        {
            return n >= 1 && n <= 9;
        }
        public int[] MakeCordinates(int n)
        {
            int[] result = new int[2];
            if (n == 1)
            {
                result[0] = 0;
                result[1] = 0;
            }
            else if(n == 2)
            {
                result[0] = 0;
                result[1] = 1;
            }
            else if (n == 3)
            {
                result[0] = 0;
                result[1] = 2;
            }
            else if (n == 4)
            {
                result[0] = 1;
                result[1] = 0;
            }
            else if (n == 5)
            {
                result[0] = 1;
                result[1] = 1;
            }
            else if (n == 6)
            {
                result[0] = 1;
                result[1] = 2;
            }
            else if (n == 7)
            {
                result[0] = 2;
                result[1] = 0;
            }
            else if (n == 8)
            {
                result[0] = 2;
                result[1] = 1;
            }
            else if (n == 9)
            {
                result[0] = 2;
                result[1] = 2;
            }
            return result;
        }
        public bool IsEmpty(int[] cordinates)
        {
            int row = cordinates[0];
            int coll = cordinates[1];
            if (board[row][coll] == " ")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsTheareAWiner()
        {
            if (this.board[0][0] == this.board[0][1] && this.board[0][0] == this.board[0][2] && this.board[0][0] != " ")
            {
                return true;
            }
            if (this.board[1][0] == this.board[1][1] && this.board[1][0] == this.board[1][2] && this.board[1][0] != " ")
            {
                return true;
            }
            if (this.board[2][0] == this.board[2][1] && this.board[2][0] == this.board[2][2] && this.board[2][0] != " ")
            {
                return true;
            }
            if (board[0][0] == board[1][0] && board[0][0] == board[2][0] && board[0][0] != " ")
            {
                return true;
            }
            if (board[0][1] == board[1][1] && board[0][1] == board[2][1] && board[0][1] != " ")
            {
                return true;
            }
            if (board[0][2] == board[1][2] && board[0][2] == board[2][2] && board[0][2] != " ")
            {
                return true;
            }
            if (board[0][0] == board[1][1] && board[0][0] == board[2][2] && board[0][0] != " ")
            {
                return true;
            }
            if (board[0][2] == board[1][1] && board[0][2] == board[2][0] && board[0][2] != " ")
            {
                return true;
            }
            return false;
            
        }
    }
}
