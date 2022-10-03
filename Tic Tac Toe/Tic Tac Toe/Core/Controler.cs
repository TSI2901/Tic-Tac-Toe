using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac.Core.Contracts;
using Tic_Tac.Models;
using Tic_Tac.Models.Contracts;
using Tic_Tac.Utilities.Messages;

namespace Tic_Tac.Core
{
    internal class Controler : IControler
    {
        
        public Controler()
        {
            
        }
        public void Player1Movement(int n,IBoard board)
        {
            int[] arr = board.MakeCordinates(n);
            if (board.IsInBoard(n))
            {
                if (board.IsEmpty(arr))
                {
                    int row = arr[0];
                    int col = arr[1];
                   
                    board.PlaceAMarker("X", row, col);
                    
                    Console.WriteLine(board.ShowTheBoard());
                    
                }
                else
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPossition);
                }
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidNumber);
            }
        }

        public void Player2Movement(int n,IBoard board)
        {
            
            int[] arr = board.MakeCordinates(n);
            if (board.IsInBoard(n))
            {
                if (board.IsEmpty(arr))
                {
                    int row = arr[0];
                    int col = arr[1];
                    
                    board.PlaceAMarker("O", row, col);
                    
                    Console.WriteLine(board.ShowTheBoard());
                    
                }
                else
                {
                    throw new ArgumentException(ExceptionMessages.InvalidPossition);
                }
            }
            else
            {
                throw new ArgumentException(ExceptionMessages.InvalidNumber);
            }
        }
    }
}
