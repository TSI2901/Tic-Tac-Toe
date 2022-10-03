using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tic_Tac.Models.Contracts;

namespace Tic_Tac.Core.Contracts
{
    internal interface IControler
    {
        void Player1Movement(int n, IBoard board);
        void Player2Movement(int n, IBoard board);
    }
}
