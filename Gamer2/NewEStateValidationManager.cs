using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer2
{
    class NewEStateValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.FirstName == "Ertugrul" && gamer.Lastname == "Aydinc" && gamer.BirthYear == 2002)
            {
                Console.WriteLine("Kayit basarili");
                return true;
            }
            else
            {
                Console.WriteLine("Kayit basarisiz");
                return false;
            }
        }
    }
}
