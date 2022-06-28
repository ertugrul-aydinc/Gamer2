using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateValidationManager());

            OfferManager offerManager = new OfferManager();

            offerManager.Introduce(new Games { GameName = "LOL" }, new Offer { OfferPercent = 0.4f });
            float a =offerManager.MakeOffer(new Games { GameName = "LOL", Price = 300 }, new Offer { OfferPercent = 0.4f });
            Console.WriteLine(a);


        }
    }
}
