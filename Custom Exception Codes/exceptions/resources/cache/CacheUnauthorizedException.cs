using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception_Codes.exceptions.resources.cache
{
    public class CacheUnauthorizedException : CacheResourceException
    {
        private readonly int _code;
        public CacheUnauthorizedException(string message) : base(message)
        {
            _code = base.GetCode() + Unauthorized;
            ProcessException(message, _code);
        }

        public new int GetCode()
        {
            return _code;
        }
    }
}
