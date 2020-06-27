using System;
using System.Runtime.Serialization;

namespace POOII_Module03_TraitementExceptions
{
    public class VoitureDejaDemarreeException : InvalidOperationException
    {
        public VoitureDejaDemarreeException()
        {; }

        public VoitureDejaDemarreeException(string message) : base(message)
        {; }

        public VoitureDejaDemarreeException(string message, Exception innerException) : base(message, innerException)
        {; }

        protected VoitureDejaDemarreeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {; }
    }
}