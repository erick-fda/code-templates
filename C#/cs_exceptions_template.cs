/*========================================================================================
    CustomExceptions
	
	Custom exception types.
	
    Copyright 2019 Erick Fernandez de Arteaga. All rights reserved.
        https://github.com/erick-fda
        https://www.linkedin.com/in/erick-fda
	
========================================================================================*/

namespace MyNamespace
{
    /*----------------------------------------------------------------------------------------
        Classes
    ----------------------------------------------------------------------------------------*/
    /*
        Exception due to <<exceptional situation>>.
    */
    public class MyException : System.Exception
    {
        private const string DEFAULT_EXCEPTION_MESSAGE = "";

        public MyException() : base(DEFAULT_EXCEPTION_MESSAGE) { }
        public MyException(string message) : base(message) { }
        public MyException(string message, Exception innerException) : base(message, innerException) { }
    }
}
