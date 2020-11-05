using System;
using System.Collections.Generic;
using System.Text;

namespace Laba7_exceptions
{
    class ExceptionEmpty : Exception
    {

        public ExceptionEmpty(string msg) : base(msg)
        { }
    }
}
