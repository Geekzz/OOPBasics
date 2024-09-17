using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    internal class TextInputError: UserError
    {
        public override string UEMessage()
        {
            return "You tried to use a text input in a numberic only field. This fired an error!";
        }
    }
}
