using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gamer2
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
