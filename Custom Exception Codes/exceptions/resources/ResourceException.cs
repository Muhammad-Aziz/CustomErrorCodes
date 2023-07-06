using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception_Codes.exceptions.resources
{
    public class ResourceException : GeneralException
    {
        private readonly int _code = 1000;
        public ResourceException(string message) : base(message)
        {
            ProcessException(message, _code);
        }

        public int GetCode()
        {
            return _code;
        }
    }
}
