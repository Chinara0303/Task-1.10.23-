using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Exceptions
{
    public class EmailException : Exception
    {
        public EmailException(string msg):base(msg) { }
    
    }
}
