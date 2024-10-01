using System.Collections.Generic;

namespace WindowsFormsApp1;

internal class ListeObservableEvent<TypeElement>
{
    public TypeListeObservableEvent Type { get; set; }
    public IEnumerable<TypeElement> Donnees { get; set; }
}
