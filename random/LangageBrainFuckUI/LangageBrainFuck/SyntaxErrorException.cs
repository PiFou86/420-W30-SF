using System.Runtime.Serialization;
using System;

[Serializable]
internal class SyntaxErrorException : Exception
{
    public SyntaxErrorException()
    {
    }

    public SyntaxErrorException(string message) : base(message)
    {
    }

    public SyntaxErrorException(string message, Exception innerException) : base(message, innerException)
    {
    }

    protected SyntaxErrorException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}
