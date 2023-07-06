using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception_Codes.exceptions.integration
{
    public class IntegrationTimeoutException : IntegrationException
    {
        private readonly int _code;
        public IntegrationTimeoutException(string message) : base(message)
        {
            _code = base.GetCode() + Timeout;
            ProcessException(message, _code);
        }

        public new int GetCode()
        {
            return _code;
        }
    }
}
