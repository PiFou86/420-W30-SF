using AutoMapper;
using Module06_Formats_Echanges_PreparationCours.Depots.XML.FormatAttributs.DTO;
using Module06_Formats_Echanges_PreparationCours.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Module06_Formats_Echanges_PreparationCours.Depots.XML.FormatAttributs
{
    class DepotDessinXMLFormatAttributs : DepotDessin
    {
        private string m_nomFichier;

        public DepotDessinXMLFormatAttributs(string p_nomFichier)
        {
            this.m_nomFichier = p_nomFichier;
        }

        public void EnregistrerDessin(Dessin p_dessin)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";

            using (XmlWriter doc = XmlWriter.Create(this.m_nomFichier, settings))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(DessinFormatAttributsDTO),
                    new Type[]
                    {
                        typeof(PolygoneFormatAttributsDTO),
                        typeof(CercleFormatAttributsDTO),
                    });

                // Transformation de Dession vers DessinDTO
                // Méthode 1 : Manuelle
                DessinFormatAttributsDTO dessinDTO = new DessinFormatAttributsDTO();
                dessinDTO.Formes = new List<FormeFormatAttributsDTO>();
                foreach (Forme forme in p_dessin.Formes)
                {
                    FormeFormatAttributsDTO formeDTO = null;
                    switch (forme)
                    {
                        case Polygone p:
                            formeDTO = new PolygoneFormatAttributsDTO()
                            {
                                Sommets = p.Sommets.Select(point2D =>
                                new Point2DFormatAttributsDTO()
                                {
                                    X = point2D.X,
                                    Y = point2D.Y
                                }).ToList()
                            };
                            break;
                        case Cercle c:
                            Point2D centre = c.Centre;
                            formeDTO = new CercleFormatAttributsDTO()
                            {
                                Centre = new Point2DFormatAttributsDTO()
                                {
                                    X = centre.X,
                                    Y = centre.Y
                                },
                                Rayon = c.Rayon
                            };
                            break;
                        default:
                            break;
                    }

                    dessinDTO.Formes.Add(formeDTO);
                }

                // Méthode 2 : Bibliothèque automapper
                //IMapper mapper = CreerOutilConversionEntity2DTO();
                //DessinDTO dessinDTO = mapper.Map<DessinDTO>(p_dessin);

                doc.WriteStartDocument();
                xmlSerializer.Serialize(doc, dessinDTO);
                doc.Close();
            }
        }

        public Dessin LireDepot()
        {
            IMapper mapper = CreerOutilConversionDTO2Entity();

            XmlReader doc = XmlReader.Create(this.m_nomFichier);

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DessinFormatAttributsDTO),
                    new Type[]
                    {
                        typeof(PolygoneFormatAttributsDTO),
                        typeof(CercleFormatAttributsDTO),
                    });

            DessinFormatAttributsDTO dessinDTO = xmlSerializer.Deserialize(doc) as DessinFormatAttributsDTO;

            Dessin dessin = mapper.Map<Dessin>(dessinDTO);

            return dessin;
        }

        private static IMapper CreerOutilConversionEntity2DTO()
        {
            MapperConfiguration mc = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<Dessin, DessinFormatAttributsDTO>();

                    cfg.CreateMap<Point2D, Point2DFormatAttributsDTO>();

                    cfg.CreateMap<Forme, FormeFormatAttributsDTO>()
                    .Include<Cercle, CercleFormatAttributsDTO>()
                    .Include<Polygone, PolygoneFormatAttributsDTO>();

                    cfg.CreateMap<Polygone, PolygoneFormatAttributsDTO>();

                    cfg.CreateMap<Cercle, CercleFormatAttributsDTO>();
                }
                );

            return mc.CreateMapper();
        }

        private static IMapper CreerOutilConversionDTO2Entity()
        {
            MapperConfiguration mc = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<DessinFormatAttributsDTO, Dessin>()
                    .ForCtorParam("p_formes", opt => opt.MapFrom(src => src.Formes));

                    cfg.CreateMap<Point2DFormatAttributsDTO, Point2D>();
                    cfg.CreateMap<FormeFormatAttributsDTO, Forme>()
                    .Include<CercleFormatAttributsDTO, Cercle>()
                    .Include<PolygoneFormatAttributsDTO, Polygone>();

                    cfg.CreateMap<PolygoneFormatAttributsDTO, Polygone>()
                    .ForCtorParam("p_sommets", opt => opt.MapFrom(src => src.Sommets));

                    cfg.CreateMap<CercleFormatAttributsDTO, Cercle>()
                    .ForCtorParam("p_centre", opt => opt.MapFrom(src => src.Centre))
                    .ForCtorParam("p_rayon", opt => opt.MapFrom(src => src.Rayon));
                }
                );

            return mc.CreateMapper();
        }


    }
}
