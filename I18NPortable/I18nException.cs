using System;

namespace I18NPortablewithReverseLookup
{
    public class I18NException : Exception
    {
        public I18NException(string message, Exception innerException = null) : base(message, innerException)
        {
            
        }
    }
}
