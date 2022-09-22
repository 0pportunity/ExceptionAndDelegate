using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class UsersException : TimeoutException
    {
        public UsersException (string message) : base(message)
        {
        } 

    }
}
