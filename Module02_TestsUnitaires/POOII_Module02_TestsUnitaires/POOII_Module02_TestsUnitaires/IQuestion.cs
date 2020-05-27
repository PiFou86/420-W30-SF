using System;
using System.Collections.Generic;
using System.Text;

namespace POOII_Module02_TestsUnitaires
{
public interface IQuestion
{
    public int NombrePointsTotal { get; }
    public void PoserQuestion();
    public int CorrigerReponse();
}
}
