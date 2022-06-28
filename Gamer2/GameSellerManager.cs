using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer2
{
    class GameSellerManager : IGameSellerService
    {
        public void Intoduce(Gamer gamer, Games games)
        {
            Console.WriteLine(gamer.FirstName+" için oyun açıklaması: "+games.Info);
        }

        public void Sell(Gamer gamer, Games games)
        {
            Console.WriteLine(gamer.FirstName+" "+games.GameName+" oyununu satın aldı.");
        }
    }
}
