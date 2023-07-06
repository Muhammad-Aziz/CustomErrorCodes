using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Custom_Exception_Codes.exceptions.resources;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Custom_Exception_Codes.exceptions.resources.cache
{
    public class CacheResourceException : ResourceException
    {
        private readonly int _code = 100;
        public CacheResourceException(string message) : base(message)
        {
            _code += base.GetCode();
            ProcessException(message, _code);
        }

        public new int GetCode()
        {
            return _code;
        }
    }
}
