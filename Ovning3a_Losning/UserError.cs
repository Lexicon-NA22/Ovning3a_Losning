using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ovning3a_Losning
{
    public abstract class UserError
    {
        public abstract string UEMessage();
    }

    public class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return "Wrong wrong worng!";
        }
    }

    public class AnotherError : UserError
    {
        public override string UEMessage()
        {
            return "another error!";
        }
    }
}
