using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowValleyCinemaRoom
{
    internal class ErrorHandler : Exception
    {
        public class InvalidCredentialsException : Exception
        {

            public InvalidCredentialsException()
                : base(String.Format("User not found! please check your credentials and try again"))
            {

            }
        }

        public class EmptyFieldException : Exception
        {

            public EmptyFieldException(string fieldName)
                : base(String.Format("Please fill the {0} info!", fieldName))
            {

            }
        }
    }
}
