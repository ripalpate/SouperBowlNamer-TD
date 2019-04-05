using System;
using System.Collections.Generic;
using System.Text;

namespace SuperBowlNamer
{
    class InvalidInputException: Exception
    {
        public InvalidInputException() : base("The input received was invalid. Please enter number greater than 0")
        { }
    }
}
