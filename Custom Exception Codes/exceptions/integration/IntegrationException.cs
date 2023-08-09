using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Exception_Codes.exceptions.integration
{
    public class IntegrationException : GeneralException
    {
        private readonly int _code = 10000;
        
        // general inegration exception -> throw when specific error is not defined yet
        public IntegrationException(string message) : base(message)
        {
            ProcessException(message, _code);
        }

        // - integration exception with resource code -> throw when resource also uses custom codes and returns a code
        // - ex. remote resource returns 1110 for database timeout -> ingeration code will be 11110 to indicate a remote resource is unable to reach its DB
        // - in case a remote resource is having another integration that is failing to call its DB and returns 11110 ->
        //   this service will throw error code 21110 indicating the distance to the error
        // - when having an integration error, adding logs should help find the issue by searching for the exception name or code to find the details
        public IntegrationException(string message, int response_code) : base(message)
        {
            _code += response_code;
            ProcessException(message, _code);
        }

        public int GetCode()
        {
            return _code;
        }
    }
}
