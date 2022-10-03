using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac.Models.Contracts
{
    internal interface IBoard
    {
        void PlaceAMarker(string markerToPlace, int row, int coll);
        string ShowTheEmptyBoard();
        string ShowTheBoard();
        bool IsEmpty(int[] cordinates);
        bool IsInBoard(int n);
        bool IsTheareAWiner();
        int[] MakeCordinates(int n);
    }
}
