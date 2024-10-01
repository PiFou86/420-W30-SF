using AutoMapper;
using Module06_Formats_Echanges_PreparationCours.Depots.JSON.DTO;
using Module06_Formats_Echanges_PreparationCours.Entites;
//using Newtonsoft.Json;
using System.IO;
using System.Text.Json;

namespace Module06_Formats_Echanges_PreparationCours.Depots.JSON;

public class DepotDessinJSON : DepotDessin
{
    private string m_nomFichier;

    public DepotDessinJSON(string p_nomFichier)
    {
        this.m_nomFichier = p_nomFichier;
    }

    public void EnregistrerDessin(Dessin p_dessin)
    {
        // Méthode 2 : Bibliothèque automapper
        IMapper mapper = CreerOutilConversionEntity2DTO();
        DessinJSONDTO dessinDTO = mapper.Map<DessinJSONDTO>(p_dessin);

        //JsonSerializerSettings settings = new JsonSerializerSettings
        //{
        //    TypeNameHandling = TypeNameHandling.Auto,
        //    Formatting = Formatting.Indented
        //};
        //string chaineJson = JsonConvert.SerializeObject(dessinDTO, settings);
        JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions() { WriteIndented = true };
        string chaineJson = JsonSerializer.Serialize(dessinDTO, jsonSerializerOptions);
        File.WriteAllText(this.m_nomFichier, chaineJson);
    }

    public Dessin LireDepot()
    {
        IMapper mapper = CreerOutilConversionDTO2Entity();

        string chaineJson = File.ReadAllText(this.m_nomFichier);
        //JsonSerializerSettings settings = new JsonSerializerSettings
        //{
        //    TypeNameHandling = TypeNameHandling.Auto
        //};
        //DessinJSONDTO dessinDTO = JsonConvert.DeserializeObject<DessinJSONDTO>(chaineJson, settings);
        DessinJSONDTO dessinDTO = JsonSerializer.Deserialize<DessinJSONDTO>(chaineJson);

        Dessin dessin = mapper.Map<Dessin>(dessinDTO);

        return dessin;
    }

    private static IMapper CreerOutilConversionEntity2DTO()
    {
        MapperConfiguration mc = new MapperConfiguration(
            cfg =>
            {
                cfg.CreateMap<Dessin, DessinJSONDTO>();

                cfg.CreateMap<Point2D, Point2DJSONDTO>();

                cfg.CreateMap<Forme, FormeJSONDTO>()
                .Include<Cercle, CercleJSONDTO>()
                .Include<Polygone, PolygoneJSONDTO>();

                cfg.CreateMap<Polygone, PolygoneJSONDTO>();

                cfg.CreateMap<Cercle, CercleJSONDTO>();
            }
            );

        return mc.CreateMapper();
    }

    private static IMapper CreerOutilConversionDTO2Entity()
    {
        MapperConfiguration mc = new MapperConfiguration(
            cfg =>
            {
                cfg.CreateMap<DessinJSONDTO, Dessin>()
                .ForCtorParam("p_formes", opt => opt.MapFrom(src => src.Formes));

                cfg.CreateMap<Point2DJSONDTO, Point2D>();
                cfg.CreateMap<FormeJSONDTO, Forme>()
                .Include<CercleJSONDTO, Cercle>()
                .Include<PolygoneJSONDTO, Polygone>();

                cfg.CreateMap<PolygoneJSONDTO, Polygone>()
                .ForCtorParam("p_sommets", opt => opt.MapFrom(src => src.Sommets));

                cfg.CreateMap<CercleJSONDTO, Cercle>()
                .ForCtorParam("p_centre", opt => opt.MapFrom(src => src.Centre))
                .ForCtorParam("p_rayon", opt => opt.MapFrom(src => src.Rayon));
            }
            );

        return mc.CreateMapper();
    }
}
