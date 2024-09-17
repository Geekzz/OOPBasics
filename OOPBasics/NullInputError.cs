using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    internal class NullInputError: UserError
    {
        public override string UEMessage()
        {
            return "You tried to submit an empty or null input. This fired an error!";
        }
    }
}
