using System;

namespace SyncCS
{
    public class InvalidContentException : Exception
    {
        public InvalidContentException(string message) : base(message) { }
    }
}
