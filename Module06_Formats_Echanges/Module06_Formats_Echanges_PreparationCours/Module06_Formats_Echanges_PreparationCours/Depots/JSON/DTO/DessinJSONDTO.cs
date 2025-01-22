using System.Collections.Generic;
using System.Linq;

using Module06_Formats_Echanges_PreparationCours.Entites;

namespace Module06_Formats_Echanges_PreparationCours.Depots.JSON.DTO
{
    public class DessinJSONDTO
    {
        public DessinJSONDTO()
        {
            ;
        }

        public DessinJSONDTO(Dessin p_dessin)
        {
            this.Formes = p_dessin.Formes.Select<Forme, FormeJSONDTO>(
                // PFL : ici le switch disgracieux est obligatoire à cause de l'héritage
                // Dans un cas plus simple on fait simplement f => new XXXJSONDTO(f)
                f =>
                {
                    switch (f)
                    {
                        case Cercle c:
                            return new CercleJSONDTO(c);
                        case Polygone p:
                            return new PolygoneJSONDTO(p);
                        default:
                            throw new System.NotImplementedException();
                    }
                }
            ).ToList();
        }

        public List<FormeJSONDTO> Formes { get; set; }

        public Dessin VersEntite()
        {
            return new Dessin(this.Formes.Select(f => f.VersEntite()));
        }
    }
}
