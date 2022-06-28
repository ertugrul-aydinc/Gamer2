using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer2
{
    interface IOfferService
    {
        float MakeOffer(Games games,Offer offer);

        void Introduce(Games games,Offer offer);
    }
}
