using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace POOII_Module03_TraitementExceptions.Matrices
{
    public class DimensionsNonConcordantesException : ArgumentException
    {
        public DimensionsNonConcordantesException()
        {
        }

        public DimensionsNonConcordantesException(string message) : base(message)
        {
        }

        public DimensionsNonConcordantesException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public DimensionsNonConcordantesException(string message, string paramName) : base(message, paramName)
        {
        }

        public DimensionsNonConcordantesException(string message, string paramName, Exception innerException) : base(message, paramName, innerException)
        {
        }
    }
}
