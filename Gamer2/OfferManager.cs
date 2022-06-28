using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer2
{
    class OfferManager : IOfferService
    {
        public void Introduce(Games games,Offer offer)
        {
            Console.WriteLine(games.GameName+" urununune uygulanacak kampanya miktari %"+offer.OfferPercent*100);
        }

        public float MakeOffer(Games games, Offer offer)
        {
            float newPrice =games.Price-( games.Price * offer.OfferPercent);

            return newPrice;
        }
    }
}
