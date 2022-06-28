using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer2
{
    interface IGameSellerService
    {
        void Sell(Gamer gamer,Games games );
        void Intoduce(Gamer gamer,Games games);
    }
}
