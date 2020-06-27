using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module03_TraitementExceptions
{
    public class ErreurFonctionnelleException : Exception
    {
        public string CodeErreur { get;  }
        public ErreurFonctionnelleException(string p_codeErreur, string p_message, Exception p_exception) : base(p_message, p_exception)
        {
            this.CodeErreur = p_codeErreur;
        }
    }
}
