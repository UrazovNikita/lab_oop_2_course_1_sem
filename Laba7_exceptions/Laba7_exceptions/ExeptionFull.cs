using System;
using System.Collections.Generic;
using System.Text;

namespace Laba7_exceptions
{
    class ExceptionFull : Exception
    {
        public ExceptionFull(string inputMessage)

        {
            message = inputMessage;
        }

        public string message= "object is full";
    }


}

        
    

