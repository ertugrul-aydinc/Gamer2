using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer2
{
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" isimli kullanici silindi");
        }

        public bool Register(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " isimli kullanicinin bilgileri guncellendi");
        }
    }
}
