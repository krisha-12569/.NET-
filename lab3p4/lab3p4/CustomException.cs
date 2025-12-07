using System;
using System.Collections.Generic;
using System.Text;

namespace lab3p4
{
    internal class CustomException : Exception
    {
        public CustomException(string message) : base(message) { }
    }
}
