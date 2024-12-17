using System.Formats.Asn1;

namespace APIeSistemTreinamento.Models
{
    public class UF : Entity
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string SiglaUF { get; set; }
        public int CodigoIBGE { get; set; }
        public bool Ativo { get; set; }
        public double AliqIcmsInterna { get; set; }   
        public List<Cidade> Cidades { get; set; }
        public int IdPais { get; set; }
        public Pais Pais { get; set; }

         //id integer NOT NULL DEFAULT nextval('estado_id_seq'::regclass),
         //id_pais integer NOT NULL DEFAULT 0,
         //nome character varying(100) NOT NULL DEFAULT ''::character varying,
         //sigla character varying(2) NOT NULL DEFAULT ''::character varying,
         //codigo_ibge integer NOT NULL DEFAULT 0,
         //ativo boolean NOT NULL DEFAULT false,
         //aliq_icms_interna numeric(18,2) NOT NULL DEFAULT 0,
         //CONSTRAINT "PK_public.estado" PRIMARY KEY(id),
         //CONSTRAINT "FK_public.estado_public.pais_id_pais" FOREIGN KEY(id_pais)
    }
}
