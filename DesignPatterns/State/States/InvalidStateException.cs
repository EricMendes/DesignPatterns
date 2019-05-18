using System;

namespace DesignPatterns.State
{
    public class InvalidStateException: Exception
    {
        public InvalidStateException(string state)
            :base("This state is invalid: ")
        {
        }
    }
}
