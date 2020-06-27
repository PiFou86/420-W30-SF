using System;
using System.Runtime.Serialization;

namespace POOII_Module03_TraitementExceptions
{
    public class VoitureDejaArreteeException : InvalidOperationException
    {
        public VoitureDejaArreteeException()
        {; }

        public VoitureDejaArreteeException(string message) : base(message)
        {; }

        public VoitureDejaArreteeException(string message, Exception innerException) : base(message, innerException)
        {; }
    }
}