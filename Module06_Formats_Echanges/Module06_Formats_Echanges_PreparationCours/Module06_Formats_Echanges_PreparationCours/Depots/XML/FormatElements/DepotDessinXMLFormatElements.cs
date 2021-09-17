using AutoMapper;
using Module06_Formats_Echanges_PreparationCours.Depots.XML.FormatElements.DTO;
using Module06_Formats_Echanges_PreparationCours.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Module06_Formats_Echanges_PreparationCours.Depots.XML.FormatElements
{
    class DepotDessinXMLFormatElements : DepotDessin
    {
        private string m_nomFichier;

        public DepotDessinXMLFormatElements(string p_nomFichier)
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
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(DessinFormatElementsDTO),
                    new Type[]
                    {
                        typeof(PolygoneFormatElementsDTO),
                        typeof(CercleFormatElementsDTO),
                    });

                // Transformation de Dession vers DessinDTO
                // Méthode 1 : Manuelle
                DessinFormatElementsDTO dessinDTO = new DessinFormatElementsDTO();
                dessinDTO.Formes = new List<FormeFormatElementsDTO>();
                foreach (Forme forme in p_dessin.Formes)
                {
                    FormeFormatElementsDTO formeDTO = null;
                    switch (forme)
                    {
                        case Polygone p:
                            formeDTO = new PolygoneFormatElementsDTO()
                            {
                                Sommets = p.Sommets.Select(point2D =>
                                new Point2DFormatElementsDTO()
                                {
                                    X = point2D.X,
                                    Y = point2D.Y
                                }).ToList()
                            };
                            break;
                        case Cercle c:
                            Point2D centre = c.Centre;
                            formeDTO = new CercleFormatElementsDTO()
                            {
                                Centre = new Point2DFormatElementsDTO()
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

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DessinFormatElementsDTO),
                    new Type[]
                    {
                        typeof(PolygoneFormatElementsDTO),
                        typeof(CercleFormatElementsDTO),
                    });

            DessinFormatElementsDTO dessinDTO = xmlSerializer.Deserialize(doc) as DessinFormatElementsDTO;

            Dessin dessin = mapper.Map<Dessin>(dessinDTO);

            return dessin;
        }

        private static IMapper CreerOutilConversionEntity2DTO()
        {
            MapperConfiguration mc = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<Dessin, DessinFormatElementsDTO>();

                    cfg.CreateMap<Point2D, Point2DFormatElementsDTO>();

                    cfg.CreateMap<Forme, FormeFormatElementsDTO>()
                    .Include<Cercle, CercleFormatElementsDTO>()
                    .Include<Polygone, PolygoneFormatElementsDTO>();

                    cfg.CreateMap<Polygone, PolygoneFormatElementsDTO>();

                    cfg.CreateMap<Cercle, CercleFormatElementsDTO>();
                }
                );

            return mc.CreateMapper();
        }

        private static IMapper CreerOutilConversionDTO2Entity()
        {
            MapperConfiguration mc = new MapperConfiguration(
                cfg =>
                {
                    cfg.CreateMap<DessinFormatElementsDTO, Dessin>()
                    .ForCtorParam("p_formes", opt => opt.MapFrom(src => src.Formes));

                    cfg.CreateMap<Point2DFormatElementsDTO, Point2D>();
                    cfg.CreateMap<FormeFormatElementsDTO, Forme>()
                    .Include<CercleFormatElementsDTO, Cercle>()
                    .Include<PolygoneFormatElementsDTO, Polygone>();

                    cfg.CreateMap<PolygoneFormatElementsDTO, Polygone>()
                    .ForCtorParam("p_sommets", opt => opt.MapFrom(src => src.Sommets));

                    cfg.CreateMap<CercleFormatElementsDTO, Cercle>()
                    .ForCtorParam("p_centre", opt => opt.MapFrom(src => src.Centre))
                    .ForCtorParam("p_rayon", opt => opt.MapFrom(src => src.Rayon));
                }
                );

            return mc.CreateMapper();
        }


    }
}
